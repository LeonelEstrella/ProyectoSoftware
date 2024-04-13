using AccessData.DataBaseInfraestructure.DBContext;

namespace AccessData.Util
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
