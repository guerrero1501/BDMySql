using BDMySql.Data;
using BDMySql.DataSql;
using BDMySql.DTO;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BDMySql
{
    class Program
    {
        static async Task Main(string[] args)
        {
            luegopagodevContext contextMySql = new luegopagodevContext();
            sellerContext contextSqlServer = new sellerContext();

            var dataSqlServer = await contextSqlServer.Categorias.Where(c => c.CategName != "").OrderBy(o => o.Orden).ToListAsync();

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

            foreach (var data in dataSqlServer)
            {
                var prentId = ulong.Parse(string.IsNullOrEmpty(data.ParentId) ? "0" : data.ParentId);
                var a = existingFData.FirstOrDefault(w => w.Name.ToLower() == data.CategName.ToLower() && w.Parent == prentId);
                if (a != null)
                {
                    var idCategory = data.CategId;

                    data.CategId = a.TermId.ToString();

                    dataSqlServer.Where(w => w.ParentId == idCategory).ToList().ForEach(f => f.ParentId = a.TermId.ToString());
                }
                else
                {
                    WpTerms wpTerms = new WpTerms
                    {
                        TermId = ulong.Parse(data.CategId),
                        Name = data.CategName,
                        Slug = data.CategSlug
                    };

                    contextMySql.WpTerms.Add(wpTerms);

                    WpTermTaxonomy wpTermTaxonomy = new WpTermTaxonomy
                    {
                        TermId = ulong.Parse(data.CategId),
                        Taxonomy = "product_cat",
                        Parent = ulong.Parse(data.ParentId)
                    };

                    contextMySql.WpTermTaxonomy.Add(wpTermTaxonomy);

                    contextMySql.SaveChanges();
                }
            }

            await contextSqlServer.SaveChangesAsync();

        }

        public async Task InsertAttributes()
        {
            luegopagodevContext contextMySql = new luegopagodevContext();
            sellerContext contextSqlServer = new sellerContext();

            var dataSqlServer = await contextSqlServer.Categorias.OrderBy(o => o.Orden).ToListAsync();
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
