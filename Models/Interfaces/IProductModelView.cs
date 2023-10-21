using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Models.Interfaces
{
    internal interface IProductModelView
    {
        string ProductModelId { get; set; }
        string ProductModeName { get; set; }
        string ProductModePrice { get; set; }
        string ProductModeStock { get; set; }
        string ProductModeCategoryId { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductModeListBildingSource(BindingSource payModeList);

        void Show();
    }
}
