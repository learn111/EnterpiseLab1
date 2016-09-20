using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Contracts
{
    public interface IReportGenerationService
    {
        Task Generate(IEnumerable<DishCookModel> dishes, string path);
    }
}
