using CsvHelper.Configuration;
using CSVHelperGeneric.Models;
using System.Collections.Generic;

namespace CSVHelperGeneric.GenericServices
{
    public interface ICsvParserService<T,TMap> where T : class where TMap : ClassMap<T>
    {
        IList<T> ReadCsvFileToList(string path);
        void WriteCsvFile(string path, IList<T> models);
    }
}
