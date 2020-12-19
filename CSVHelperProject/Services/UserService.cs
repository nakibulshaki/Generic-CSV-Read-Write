using CSVHelperGeneric.Mappers;
using CSVHelperGeneric.Models;
using CSVHelperGeneric.GenericServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperGeneric.Services
{
     public class UserService:CsvParserService<User, UserMap>, IUserService
    {
    }
}
