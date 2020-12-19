using CSVHelperGeneric.GenericServices;
using CSVHelperGeneric.Mappers;
using CSVHelperGeneric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperGeneric.Services
{
    interface IUserService:ICsvParserService<User, UserMap>
    {
    }
}
