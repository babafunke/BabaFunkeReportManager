using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BabaFunkeReportManager.Interfaces
{
    public interface IFileService<T>
    {
        Task<Stream> GenerateCsvFile(List<T> entities);
    }
}
