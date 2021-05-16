using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
    public abstract class DataAccess
    {
        //Given the default method the virtual keyword allows the method to be overriden
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        //Force the inheriting class to implement the method with the "abstract" keyword
        public abstract void LoadData(string sql);

        //Force the inheriting class to implement the method with the "abstract" keyword
        public abstract void SaveData(string sql);
    }
}
