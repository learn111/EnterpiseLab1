using DAL;

namespace BLL.Services
{
    public abstract class ServiceBase
    {
        protected readonly IDalService DalService;

        protected ServiceBase(IDalService dalService)
        {
            DalService = dalService;
        }
    }
}