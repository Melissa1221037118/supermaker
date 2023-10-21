using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Models
{
    internal interface IPayModeRepository
    {
        void Add(PayModeModel payModelModel);
        void Edit(PayModeModel payModelModel);
        void Delete(int id);

        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
