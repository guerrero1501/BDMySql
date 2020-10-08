using BDMySql.Data;
using BDMySql.DataSql;
using BDMySql.DTO;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMySql
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Ingrese C para actualizar categorias, A para actualizar los attributos o R para actualizar la relaciones.");
            Console.WriteLine("Ingrese letra y luego presione Enter: ");
            var response = Convert.ToChar(Console.Read());
            if (response == 'C')
            {
                Console.WriteLine("Inicio del proceso Categorias...");
                await InsertCategories();
            }
            else if (response == 'A')
            {
                Console.WriteLine("Inicio del proceso Atributos...");
                await InsertAttributes();
            }
            else if (response == 'R')
            {
                Console.WriteLine("Inicio del proceso Relación...");
                //Aqui va el metodo
            }
        }

        private static async Task InsertCategories() 
        {
            luegopagodevContext contextMySql = new luegopagodevContext();
            sellerContext contextSqlServer = new sellerContext();

            var dataSqlServer = await contextSqlServer.Categorias.Where(c => c.CategName != "").OrderBy(o => o.Orden).ToListAsync();

            var dataSqlServerAll = await contextSqlServer.Categorias.OrderBy(o => o.Orden).ToListAsync();

            var existingFData = await (
                from terms in contextMySql.WpTerms
                from termTaxonomy in contextMySql.WpTermTaxonomy.Where(w => w.Taxonomy == "product_cat" && w.TermId == terms.TermId)
                select new WpTermDTO
                {
                    TermId = terms.TermId,
                    Name = terms.Name,
                    Slug = terms.Slug,
                    Parent = termTaxonomy.Parent
                }
            ).ToListAsync();

            var register = -1;
            var showRegister = 1000;
            foreach (var data in dataSqlServer)
            {
                register++;
                var prentId = ulong.Parse(string.IsNullOrEmpty(data.ParentId) ? "0" : data.ParentId);
                var a = existingFData.FirstOrDefault(w => w.Name.ToLower() == data.CategName.ToLower() && w.Parent == prentId);
                if (a != null)
                {
                    var idCategory = data.CategId;

                    data.CategId = a.TermId.ToString();

                    dataSqlServer.Where(w => w.ParentId == idCategory).ToList().ForEach(f => f.ParentId = a.TermId.ToString());

                    dataSqlServerAll.Where(w => w.Id_ParentCategory.ToString() == idCategory).ToList().ForEach(f => f.Id_ParentCategory = a.TermId);

                }
                else
                {
                    WpTerms wpTerms = new WpTerms
                    {
                        TermId = ulong.Parse(data.CategId),
                        Name = data.CategName,
                        Slug = data.CategSlug,
                        TermGroup = 0
                    };

                    contextMySql.WpTerms.Add(wpTerms);

                    WpTermTaxonomy wpTermTaxonomy = new WpTermTaxonomy
                    {
                        TermTaxonomyId = ulong.Parse(data.CategId),
                        TermId = ulong.Parse(data.CategId),
                        Taxonomy = "product_cat",
                        Description = string.Empty,
                        Parent = ulong.Parse(string.IsNullOrEmpty(data.ParentId) ? "0" : data.ParentId)
                    };

                    contextMySql.WpTermTaxonomy.Add(wpTermTaxonomy);

                    List<WpTermmeta> wpTermmetaList = new List<WpTermmeta>();

                    for (int i = 0; i < 6; i++)
                    {
                        string[] key = new string[] { "order", "banner", "_banner", "display_type", "thumbnail_id", "product_count_product_cat" };
                        string[] value = new string[] { "0", "", "field_5d0065cd0e7f9", "", "0", "0" };
                        WpTermmeta wpTermmeta = new WpTermmeta
                        {
                            TermId = ulong.Parse(data.CategId),
                            MetaKey = key[i],
                            MetaValue = value[i]
                        };
                        wpTermmetaList.Add(wpTermmeta);
                    }
                    contextMySql.WpTermmeta.AddRange(wpTermmetaList);

                    contextMySql.SaveChanges();
                }
                if (register == showRegister)
                {
                    Console.WriteLine("Inserted Categories" + data.CategId + " count " + register + " % " + (register * 100 / dataSqlServer.Count()));
                    showRegister += 1000;
                }
            }

            await contextSqlServer.SaveChangesAsync();          
        }

        private static async Task InsertAttributes()
        {
            luegopagodevContext contextMySql = new luegopagodevContext();
            sellerContext contextSqlServer = new sellerContext();

            var dataSqlServer =  contextSqlServer.Categorias.ToList().GroupBy(g => new { g.NameAttribute, g.IdAttribute, g.NameValue, g.Slug_Attribute });//.ToListAsync();

            ulong OptionId = 20000;
            var register = -1;
            var showRegister = 200;

            foreach (var item in dataSqlServer)
            {
                register++;

                WpWoocommerceAttributeTaxonomies wpWoocommerceAttributeTaxonomies = new WpWoocommerceAttributeTaxonomies
                {
                    AttributeId = ulong.Parse(item.Key.IdAttribute),
                    AttributeName = item.Key.Slug_Attribute,
                    AttributeLabel = item.Key.NameAttribute,
                    AttributeType = "select",
                    AttributeOrderby = "menu_order",
                    AttributePublic = 0
                };

                await contextMySql.WpWoocommerceAttributeTaxonomies.AddAsync(wpWoocommerceAttributeTaxonomies);

                if (item.Key.NameValue!= null) 
                {
                    var options = item.Key.NameValue.Split(",");

                    foreach (var option in options)
                    {
                        WpTerms wpTerms = new WpTerms
                        {
                            TermId = OptionId,
                            Name = option,
                            Slug = RemoveDiacritics(option.ToLower().Replace(" ", "-")),
                            TermGroup = 0
                        };

                        await contextMySql.WpTerms.AddAsync(wpTerms);

                        WpTermTaxonomy wpTermTaxonomy = new WpTermTaxonomy
                        {
                            TermTaxonomyId = OptionId,
                            TermId = OptionId,
                            Taxonomy = "pa_" + item.Key.Slug_Attribute,
                            Parent = 0,
                            Description = string.Empty,
                            Count = 0
                        };

                        await contextMySql.WpTermTaxonomy.AddAsync(wpTermTaxonomy);

                        WpTermmeta wpTermmeta = new WpTermmeta
                        {
                            TermId = OptionId,
                            MetaKey = "order_pa_" + item.Key.Slug_Attribute,
                            MetaValue = "0"
                        };
                        
                        await contextMySql.WpTermmeta.AddAsync(wpTermmeta);

                        OptionId++;
                    }
                }

                await contextMySql.SaveChangesAsync();

                if (register == showRegister)
                {
                    Console.WriteLine("Inserted Attributes count " + register + " % " + (register * 100 / dataSqlServer.Count()));
                    showRegister += 200;
                }
            }

            //using (IDbConnection db = contextMySql.Database.GetDbConnection())
            //{
            //    var query = "UPDATE `luegopago`.`wp_woocommerce_attribute_taxonomies` SET `attribute_public` = 0 WHERE (`attribute_public` = 1);";
            //    db.Execute(query);
            //    MySqlCommand cmd = new MySqlCommand();
            //}
        }

        private static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public static void WriteToNewExcel(List<Categorias> excelExportModels, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            FileInfo filePath = new FileInfo(path);
            using (var libro = new ExcelPackage(filePath))
            {
                var worksheet = libro.Workbook.Worksheets.Add("Categorias");
                worksheet.Cells[1, 1].Value = "Nivel";
                worksheet.Cells[1, 2].Value = "Categ Id";
                worksheet.Cells[1, 3].Value = "Categ Name";
                worksheet.Cells[1, 4].Value = "Categ Slug";
                worksheet.Cells[1, 5].Value = "Parent Id";
                worksheet.Cells[1, 6].Value = "Orden";

                int rowGobal = 2;
                foreach (var itemExport in excelExportModels)
                {
                    worksheet.Cells[rowGobal, 1].Value = itemExport.Nivel;
                    worksheet.Cells[rowGobal, 2].Value = itemExport.CategId.ToString();
                    worksheet.Cells[rowGobal, 3].Value = itemExport.CategName.Trim();
                    worksheet.Cells[rowGobal, 4].Value = itemExport.CategSlug.ToString();
                    worksheet.Cells[rowGobal, 5].Value = itemExport.ParentId;
                    worksheet.Cells[rowGobal, 6].Value = itemExport.Orden;
                    rowGobal++;
                }

                // Agregar formato de tabla
                var tabla = worksheet.Tables.Add(new ExcelAddressBase(fromRow: 1, fromCol: 1, toRow: rowGobal, toColumn: 6), "CategoriasPrueba");
                tabla.ShowHeader = true;
                tabla.TableStyle = TableStyles.Light1;
                tabla.ShowFilter = false;

                libro.Save();
            }
        }

        public static void WriteToNewExcelWoocommerce(List<WpTermDTO> excelExportModels, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            FileInfo filePath = new FileInfo(path);
            using (var libro = new ExcelPackage(filePath))
            {
                var worksheet = libro.Workbook.Worksheets.Add("CategoriasWoo");
                worksheet.Cells[1, 1].Value = "Categ Id";
                worksheet.Cells[1, 2].Value = "Categ Name";
                worksheet.Cells[1, 3].Value = "Categ Slug";
                worksheet.Cells[1, 4].Value = "Parent Id";

                int rowGobal = 2;
                foreach (var itemExport in excelExportModels)
                {
                    worksheet.Cells[rowGobal, 1].Value = itemExport.TermId;
                    worksheet.Cells[rowGobal, 2].Value = itemExport.Name;
                    worksheet.Cells[rowGobal, 3].Value = itemExport.Slug;
                    worksheet.Cells[rowGobal, 4].Value = itemExport.Parent;
                    rowGobal++;
                }

                // Agregar formato de tabla
                var tabla = worksheet.Tables.Add(new ExcelAddressBase(fromRow: 1, fromCol: 1, toRow: rowGobal, toColumn: 4), "CategoriasPrueba");
                tabla.ShowHeader = true;
                tabla.TableStyle = TableStyles.Light1;
                tabla.ShowFilter = false;

                libro.Save();
            }
        }

        //--------- Funcionalidades Comentadas - descartadas temporalmente. ---------------

        //Console.WriteLine(JsonConvert.SerializeObject(contextMySql.WpTermTaxonomy.Where(t => t.Taxonomy == "product_cat").ToList()));

        //var categoriesName = dataSql.Select(s => s.CategName).ToList();

        //var existingFData = contextMySql.WpTerms.Where(w => categoriesName.Contains(w.Name)).ToList();

        //using (sellerContext context_SqlServer = new sellerContext())
        //{
        //    var y = context_SqlServer.Categorias.FirstOrDefault(w => w.CategId == idCategory);
        //    y.CategId = a.TermId.ToString();

        //    context_SqlServer.Update(y);
        //    context_SqlServer.SaveChanges();
        //}

        //using (sellerContext context_SqlServer = new sellerContext())
        //{
        //    await context_SqlServer.Categorias.Where(w => w.ParentId == idCategory).ForEachAsync(f => f.ParentId = a.TermId.ToString());

        //    await context_SqlServer.SaveChangesAsync();
        //}

        //string fullPath = Path.Combine(@"C:\Users\fabia\OneDrive\Documents\Proyectos Quality Code\AttributeImportByCategoryML\AttributeImportByCategoryML\ExcelDocument\", "CategoriasActializadas.xlsx");

        //WriteToNewExcel(dataSql, fullPath);

        //string fullPath = Path.Combine(@"C:\Users\fabia\OneDrive\Documents\Proyectos Quality Code\AttributeImportByCategoryML\AttributeImportByCategoryML\ExcelDocument\", "CategoriasWoocommerce.xlsx");

        //WriteToNewExcelWoocommerce(existingFData, fullPath);
    }
}
