using supermarket.Models;
using supermarket.Models.Common;
using supermarket.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Presenters
{
    internal class ProductModePresenter
    {
        private IProductModelView view;
        private IProductModeRepository repository;
        private BindingSource ProductModeBingingSource;
        private IEnumerable<ProductModel> productModelList;

        public ProductModePresenter(IProductModelView view, IProductModeRepository repository)
        {
            this.ProductModeBingingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProductMode;
            this.view.AddNewEvent += AddNewProductMode;
            this.view.EditEvent += LoadSelectProductModeToEdit;
            this.view.DeleteEvent += DeleteSelectProductMode;
            this.view.SaveEvent += SaveProductMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductModeListBildingSource(ProductModeBingingSource);

            loadAllPayModeList();
        }

        private void loadAllPayModeList()
        {
            productModelList = repository.GetAll();
            ProductModeBingingSource.DataSource = productModelList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.ProductModelId = "0";
            view.ProductModeName = "";
            view.ProductModePrice = "";
            view.ProductModeStock = "0";
            view.ProductModeCategoryId = "0";
        }

        private void DeleteSelectProductMode(object? sender, EventArgs e)
        {
            try
            {
                var productMode = (ProductModel)ProductModeBingingSource.Current;

                repository.Delete(productMode.id);
                view.IsSuccessful = true;
                view.Message = "Product delted succesfully";
                loadAllPayModeList();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "an error ocurred, could not delet product";
            }
        }

        private void LoadSelectProductModeToEdit(object? sender, EventArgs e)
        {
            var productMode = (ProductModel)ProductModeBingingSource.Current;

            view.ProductModelId = productMode.id.ToString();
            view.ProductModeName = productMode.name;
            view.ProductModePrice = productMode.price.ToString();
            view.ProductModeStock = productMode.stock.ToString();
            view.ProductModeCategoryId = productMode.category_id.ToString();   

            view.IsEdit = true;
        }
        private void AddNewProductMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProductMode(object? sender, EventArgs e)
        {

        }

        private void SaveProductMode(object? sender, EventArgs e)
        {
            var productMode = new ProductModel();
            productMode.id = Convert.ToInt32(view.ProductModelId);
            productMode.name = view.ProductModeName;
            productMode.price = Convert.ToInt32(view.ProductModePrice);
            productMode.stock = Convert.ToInt32(view.ProductModeStock);
            productMode.category_id = Convert.ToInt32(view.ProductModeCategoryId);

            try
            {
                new ModelDataValidation().Validate(productMode);
                if (view.IsEdit)
                {
                    repository.Edit(productMode);
                    view.Message = "Product edited succesfully";
                }
                else
                {
                    repository.Add(productMode);
                    view.Message = "Product added succesfully";
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
    }
}