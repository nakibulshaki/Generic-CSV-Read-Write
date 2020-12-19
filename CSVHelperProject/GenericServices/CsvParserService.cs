using CsvHelper;
using CsvHelper.Configuration;
using CSVHelperGeneric.GenericServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVHelperGeneric.Services
{
    public abstract class CsvParserService<T, TMap> : ICsvParserService<T, TMap>  where T : class where TMap : ClassMap<T>
    {
            public  virtual  IList<T>ReadCsvFileToList(string path)
            {
                try
                {
                    using (var reader = new StreamReader(path))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Configuration.RegisterClassMap<TMap>();
                        var records = csv.GetRecords<T>().ToList();
                        return records;
                    }
                }
                catch (UnauthorizedAccessException e)
                {
                    throw new Exception(e.Message);
                }
                catch (FieldValidationException e)
                {
                    throw new Exception(e.Message);
                }
                catch (CsvHelperException e)
                {
                    throw new Exception(e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

        public virtual void WriteCsvFile(string path, IList<T> list)
        {
            using (StreamWriter sw = new StreamWriter(path))
            using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                cw.WriteHeader<T>();
                cw.NextRecord();
                foreach (T item in list)
                {
                    cw.WriteRecord<T>(item);
                    cw.NextRecord();
                }
            }
        }
    }
}

