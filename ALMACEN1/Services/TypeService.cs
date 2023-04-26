using DatabaseProject.Models;
using Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TypeService : TypeServiceInterface
    {
        AlmacenDbContext almacenDbContext;

        public TypeService()
        {
            this.almacenDbContext = new AlmacenDbContext();
        }

        public DatabaseProject.Models.Type GetType(int id)
        {
            return almacenDbContext.Types.ToList().Find(x => x.Id == id);
        }

        public IEnumerable<DatabaseProject.Models.Type> GetTypes()
        {
            return almacenDbContext.Types.ToList();
        }
    }


}
