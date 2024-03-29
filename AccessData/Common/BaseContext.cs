using AccessData.DataBaseInfraestructure.DBContext;

namespace AccessData.Common
{
    public class BaseContext
    {
        protected readonly RetailStoreDBContext _context;

        public BaseContext(RetailStoreDBContext context)
        {
            _context = context;
        }
    }
}
