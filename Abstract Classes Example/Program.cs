using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> databases = new List<DataAccess>()
            {
                new SQLDataAccess(),
                new SqliteDataAccess()
            };

            foreach(var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
            }

            Console.ReadLine();
        }
    }
}
