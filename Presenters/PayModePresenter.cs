using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.Views;
using supermarket.Models;
using supermarket.Models.Common;

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
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.id = Convert.ToInt32(view.PayModelId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited succesfully";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode added succesfully";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                loadAllPayModeList();
                CleanViewFields();
            }
        }

        private void CleanViewFields()
        {
            view.PayModelId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)payModeBingingSource.Current;

                repository.Delete(payMode.id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode delted succesfully";
                loadAllPayModeList();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "an error ocurred, could not delet pay mode";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBingingSource.Current;

            view.PayModelId= payMode.id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeName = payMode.Observation;

            view.IsEdit =  true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
