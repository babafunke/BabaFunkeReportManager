using BabaFunkeReportManager.Interfaces;
using BabaFunkeReportManager.Models;
using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace BabaFunkeReportManager.Services
{
    /// <summary>
    /// Creates a CSV file containing the customers data
    /// </summary>
    public class FileService : IFileService<Customer>
    {
        public async Task<Stream> GenerateCsvFile(List<Customer> customers)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            await csv.WriteRecordsAsync(customers);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}
