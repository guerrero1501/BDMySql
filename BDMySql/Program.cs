using BDMySql.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using BDMySql.DTO;
using BDMySql.DataSql;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Dapper;

namespace BDMySql
{
    class Program
    {
        static async Task Main(string[] args)
        {
            luegopagodevContext contextMySql = new luegopagodevContext();
            sellerContext contextSqlServer = new sellerContext();
            //Console.WriteLine(JsonConvert.SerializeObject(contextMySql.WpTermTaxonomy.Where(t => t.Taxonomy == "product_cat").ToList()));

            var dataSql = await contextSqlServer.Categorias.Where(c => c.CategName != "").ToListAsync();
            var cateName = dataSql.Select(c => c.CategName);
            //var existingFData = contextMySql.WpTerms.AsNoTracking().Where(w => cateName.Contains(w.Name));
            var existingFData = await (
                from terms in contextMySql.WpTerms
                from termTaxonomy in contextMySql.WpTermTaxonomy.Where(w => w.Taxonomy == "product_cat" && w.TermId == terms.TermId)
                select new
                {
                    TermId = terms.TermId,
                    Name = terms.Name,
                    Slug = terms.Slug,
                    Parent = termTaxonomy.Parent
                }
            ).ToListAsync();

            var existingFData2 = new List<WpTermDTO>();
            foreach (var row in dataSql)
            {
                var response = existingFData.FirstOrDefault(w => w.Name == row.CategName);
                if (response != null)
                {
                    var Data = new WpTermDTO()
                    {
                        Id = int.Parse(response.TermId.ToString()),
                        Name = response.Name,
                        OriginIdSql = int.Parse(row.CategId)
                    };
                    existingFData2.Add(Data);
                }
            }

            using (IDbConnection db = contextSqlServer.Database.GetDbConnection())
            {
                var query = "";
                foreach (var data in existingFData2)
                {
                     query += " UPDATE Categorias SET [Categ Id] = " + data.Id + " FROM Categorias WHERE [Categ Id] =" + data.OriginIdSql + " AND [Categ Id] <> " + data.Id + " ; UPDATE Categorias SET [Parent Id] = " + data.Id + " FROM Categorias WHERE [Parent Id] =" + data.OriginIdSql + " AND [Parent Id] <> " + data.Id+";";
                }
                db.Execute(query);
            }
            //await existingFData.ForEachAsync(c =>
            //{
            //    dataSql.FirstOrDefault(c => c.)
            //});

            //var newDataSql = dataSql.Select(cateName => new WpTerms { 

            //}).ToList();
        }
    }
}
