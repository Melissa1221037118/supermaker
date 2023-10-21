using supermarket.Models.Common;
using supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.Models.Interfaces;

namespace supermarket.Presenters
{
    internal class ProviderModelPresenters
    {
        private IProvidersModelView view;
        private IProvidersRepository repository;
        private BindingSource providersModeBingingSource;
        private IEnumerable<ProvidersModel> providersModelList;

        public ProviderModelPresenters(IProvidersModelView view, IProductModeRepository repository)
        {
            this.payModeBingingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

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
            providersModelList = repository.GetAll();
            providersModeBingingSource.DataSource = providersModelList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new ProvidersModel();
            payMode.id = Convert.ToInt32(view.PayModelId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "Providers edited succesfully";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "Providers added succesfully";
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
            view.ProvidersId = "0";
            view.ProvidersName = "";
            view.ProvidersDesccription = "";
        }

        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)providersModeBingingSource.Current;

                repository.Delete(payMode.id);
                view.IsSuccessful = true;
                view.Message = "providers Mode delted succesfully";
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
            var payMode = (PayModeModel)providersModeBingingSource.Current;

            view.PayModelId = payMode.id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeDescription = payMode.Description;

            view.IsEdit = true;
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
}
