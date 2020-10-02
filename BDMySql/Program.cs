using BDMySql.Data;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;

namespace BDMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            luegopagodevContext context = new luegopagodevContext();
            Console.WriteLine(JsonConvert.SerializeObject(context.WpTermTaxonomy.Where(t => t.Taxonomy == "product_cat").ToList()));
        }
    }
}
