using System;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
    public class SQLDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);

            return output += " (from SQL)";
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to SQL.");
        }
    }
}
