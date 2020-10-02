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
            //Console.WriteLine(JsonConvert.SerializeObject(contextMySql.WpTermTaxonomy.Where(t => t.Taxonomy == "product_cat").ToList()));

            var dataSql = contextSqlServer.Categorias.Where(c=>c.CategName !="").Select(c=>c.CategName).ToList();

            //var existingFData = contextMySql.WpTerms.Where(w => w.Name);

            //foreach (var ) 
            //{
                
            //}

        }
    }
}
