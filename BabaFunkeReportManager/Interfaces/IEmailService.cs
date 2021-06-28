using System.Collections.Generic;
using System.Threading.Tasks;

namespace BabaFunkeReportManager.Interfaces
{
    public interface IEmailService<T>
    {
        Task SendEmail(List<T> entities);
    }
}
