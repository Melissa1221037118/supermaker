using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Models.Interfaces
{
    internal interface IProvidersModelView
    {
        void Add(PayModeModel payModelModel);
        void Edit(PayModeModel payModelModel);
        void Delete(int id);

        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
