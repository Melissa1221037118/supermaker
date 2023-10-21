using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Models.Interfaces
{
    internal interface ICategoriaModelView
    {
        string CategoriaModelId { get; set; }
        string CategoriaModeName { get; set; }
        string CategoriaModeDescription { get; set; }
      
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

        void SetCategoriaModeListBildingSource(BindingSource payModeList);

        void Show();
    }
}

