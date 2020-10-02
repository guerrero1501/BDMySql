using BDMySql.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using BDMySql.DTO;

namespace BDMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            luegopagodevContext context = new luegopagodevContext();
            Console.WriteLine(JsonConvert.SerializeObject(context.WpTermTaxonomy.Where(t => t.Taxonomy == "product_cat").ToList()));

            string path = Directory.GetParent(@"Upload\ExcelDocument\").FullName + @"\CategoriasAtributos.xlsx";

            //var excel = ReadCategoriesExcel(path).OrderBy(o => o.Nivel);
            //var nameList = ReadCategoriesExcel(path).OrderBy(o => o.Nivel).Select(s=>s.Name).ToList();
            var wpTerms = context.WpTerms.Where(t => t.Name.Contains('c'));

            foreach (var term in wpTerms) 
            {
                
            }
            //private List<WpTermDTO> ReadCategoriesExcel(string path)
            //{
            //    ExcelPackage.LicenseContext = LicenseContext.Commercial;

            //    using (var excelPack = new ExcelPackage())
            //    {
            //        using (var stream = File.OpenRead(path))
            //        {
            //            excelPack.Load(stream);
            //        }

            //        List<CategoryImportDTO> Category = new List<CategoryImportDTO>();
            //        List<AttributesImportDTO> Attributes = new List<AttributesImportDTO>();
            //        CategoryImportDTO mercadoLibreCategories = null;

            //        foreach (ExcelWorksheet ws in excelPack.Workbook.Worksheets)
            //        {
            //            if (ws.Name == "Categorias")
            //            {
            //                for (int rowNum = 2; rowNum <= ws.Dimension.End.Row; rowNum++)
            //                {
            //                    if (!string.IsNullOrEmpty(ws.Cells[rowNum, 2].Value.ToString()))
            //                    {
            //                        if (mercadoLibreCategories != null)
            //                        {
            //                            mercadoLibreCategories.attributesImports = Attributes;
            //                            Attributes = new List<AttributesImportDTO>();
            //                        }
            //                        mercadoLibreCategories = new CategoryImportDTO
            //                        {
            //                            Nivel = ws.Cells[rowNum, 1].Value.ToString(),
            //                            CategId = ws.Cells[rowNum, 2].Value.ToString(),
            //                            Name = ws.Cells[rowNum, 3].Value.ToString(),
            //                            ParentId = ws.Cells[rowNum, 4].Value.ToString()
            //                        };
            //                        Category.Add(mercadoLibreCategories);
            //                    }
            //                    AttributesImportDTO mercadoLibreAttributes = new AttributesImportDTO
            //                    {
            //                        AttributeId = ws.Cells[rowNum, 5].Value.ToString(),
            //                        Name = ws.Cells[rowNum, 6].Value.ToString(),
            //                        Slug = ws.Cells[rowNum, 7].Value?.ToString(),
            //                        ValueId = ws.Cells[rowNum, 8].Value?.ToString(),
            //                        ValueName = ws.Cells[rowNum, 9].Value?.ToString()
            //                    };
            //                    Attributes.Add(mercadoLibreAttributes);
            //                }
            //                mercadoLibreCategories.attributesImports = Attributes;
            //            }
            //        }
            //        return Category;
            //    }
            //}
        }
    }
}
