using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Models.Interfaces
{
    internal interface IProvidersRepository
    {
        string ProvierlId { get; set; }
        string ProvierName { get; set; }
        string ProvierDescription { get; set; }

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

        void SetProvidersListBildingSource(BindingSource payModeList);

        void Show();

    }
}
