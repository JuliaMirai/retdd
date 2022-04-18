using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using retdd.Model;

namespace retdd.Service
{
    interface IResService
    {
        Task<List<Entries>> GetDataAsync();
    }
}
