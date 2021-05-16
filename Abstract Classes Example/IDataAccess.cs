using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
    public interface IDataAccess
    {
        string LoadConnectionString(string name);

        void LoadData(string sql);
        
        void SaveData(string sql);
    }
}
