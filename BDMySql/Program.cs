using BDMySql.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using BDMySql.DTO;
using BDMySql.DataSql;

namespace BDMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            luegopagodevContext contextMySql = new luegopagodevContext();
            sellerContext contextSqlServer = new sellerContext();
            Console.WriteLine(JsonConvert.SerializeObject(contextMySql.WpTermTaxonomy.Where(t => t.Taxonomy == "product_cat").ToList()));

            string path = Directory.GetParent(@"Upload\ExcelDocument\").FullName + @"\CategoriasAtributos.xlsx";

                   
        }
    }
}
