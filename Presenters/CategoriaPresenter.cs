using supermarket.Models.Interfaces;
using supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using supermarket.Models.Common;

namespace supermarket.Presenters
{
    internal class CategoriaPresenter
    {
        private ICategoriaModelView view;
        private ICategoriaModelRepository repository;
        private BindingSource categoriaModeBingingSource;
        private IEnumerable<CategoriasModel> categoriasModelList;

        public CategoriaPresenter(ICategoriaModelView view, ICategoriaModelRepository repository)
        {
            this.categoriaModeBingingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategoriaMode;
            this.view.AddNewEvent += AddNewCategoriaMode;
            this.view.EditEvent += LoadSelectCategoriaModeToEdit;
            this.view.DeleteEvent += DeleteSelectCategoriaMode;
            this.view.SaveEvent += SaveCategoriaMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriaModeListBildingSource(categoriaModeBingingSource);

            loadAllPayModeList();
        }

        private void loadAllPayModeList()
        {
            categoriasModelList = repository.GetAll();
            categoriaModeBingingSource.DataSource = categoriasModelList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.CategoriaModelId = "0";
            view.CategoriaModeName = "";
            view.CategoriaModeDescription = "";
        }

        private void DeleteSelectCategoriaMode(object? sender, EventArgs e)
        {
            try
            {
                var productMode = (ProductModel)categoriaModeBingingSource.Current;

                repository.Delete(productMode.id);
                view.IsSuccessful = true;
                view.Message = "Categoria delted succesfully";
                loadAllPayModeList();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "an error ocurred, could not delet product";
            }
        }

        private void SaveCategoriaMode(object? sender, EventArgs e)
        {
            var productMode = new CategoriasModel();
            productMode.id = Convert.ToInt32(view.CategoriaModelId);
            productMode.name = view.CategoriaModeName;
            productMode.description = view.CategoriaModeDescription;
    

            try
            {
                new ModelDataValidation().Validate(productMode);
                if (view.IsEdit)
                {
                    repository.Edit(productMode);
                    view.Message = "Categoria edited succesfully";
                }
                else
                {
                    repository.Add(productMode);
                    view.Message = "Categoria added succesfully";
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

        private void SearchCategoriaMode(object? sender, EventArgs e)
        {

        }

        private void AddNewCategoriaMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectCategoriaModeToEdit(object? sender, EventArgs e)
        {
            var categoriaMode = (CategoriasModel)categoriaModeBingingSource.Current;

            view.CategoriaModelId = categoriaMode.id.ToString();
            view.CategoriaModeName = categoriaMode.name;
            view.CategoriaModeDescription = categoriaMode.description;
    

            view.IsEdit = true;
        }
    }
}
