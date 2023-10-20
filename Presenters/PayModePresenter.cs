using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.Views;
using supermarket.Models;

namespace supermarket.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBingingSource;
        private IEnumerable<PayModeModel> payModelList;

        public PayModePresenter(IPayModeView view,IPayModeRepository repository){
            this.payModeBingingSource = new BindingSource();

            this.view=view;
            this.repository= repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBingingSource);

            loadAllPayModeList();
        }

        private void loadAllPayModeList()
        {
            payModelList = repository.GetAll();
            payModeBingingSource.DataSource = payModelList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
