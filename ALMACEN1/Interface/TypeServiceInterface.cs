
namespace Interface
{
    public interface TypeServiceInterface
    {
        public IEnumerable<DatabaseProject.Models.Type> GetTypes();

        public DatabaseProject.Models.Type GetType(int id);
    }
}
