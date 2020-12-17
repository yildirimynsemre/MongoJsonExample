using JsonExp004.DataAccess;
using JsonExp004.Models;

namespace JsonExp004.Data
{
    public class CompanyRepository : MongoRepository<Company>
    {
        public CompanyRepository() : base()
        {
        }

    }
}
