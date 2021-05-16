using System;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
    public class SqliteDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);

            return output += " (from SQLite)";            
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Sqlite Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to Sqlite.");
        }
    }
}
