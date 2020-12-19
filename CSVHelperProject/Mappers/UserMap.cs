using CsvHelper.Configuration;
using CSVHelperGeneric.Models;

namespace CSVHelperGeneric.Mappers
{
    public sealed class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.Firstname).Name(EmpCSVConstants.CsvHeaders.Firstname);
            Map(m => m.Lastname).Name(EmpCSVConstants.CsvHeaders.Lastname);
            Map(m => m.Address).Name(EmpCSVConstants.CsvHeaders.Address);
            Map(m => m.City).Name(EmpCSVConstants.CsvHeaders.City);
        }
    }
}
