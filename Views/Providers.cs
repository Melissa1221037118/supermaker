using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket.Views
{
    public partial class Providers : Form
    {
        public Providers()
        {
            InitializeComponent();
        }
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        private List<Product> productList; // Lista para almacenar los productos

        private IProductDataProvider dataProvider;

        public ProductView(IProductDataProvider dataProvider)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            btnClose.Click += delegate { this.Close(); };

            this.dataProvider = dataProvider;
            this.productList = dataProvider.GetProducts();
        }

        // Resto del código de la clase...

        public void SetProductListBindingSource(BindingSource productBindingSource)
        {
            productBindingSource.DataSource = productList;
            DgProduct.DataSource = productBindingSource;
        }

        // Actualizar la lista de productos desde el proveedor de datos
        private void RefreshProductList()
        {
            productList = dataProvider.GetProducts();
        }

        // Actualizar el método AddNewEvent para agregar un nuevo producto
        btnsave.Click += delegate
    {
        Product newProduct = new Product
        {
            Name = ProductModeName,
            Description = ProductModeDescription
        };

        if (dataProvider.AddProduct(newProduct))
        {
            isSuccessful = true;
            message = "Product added successfully.";
            RefreshProductList();
    }
        else
        {
            isSuccessful = false;
            message = "Failed to add the product.";
        }

tabControl1.TabPages.Remove(tabPageProductDetail);
tabControl1.TabPages.Add(tabPageProductList);
tabPageProductDetail.Text = "Add new Product";

MessageBox.Show(message);
    };

// Actualizar el método EditEvent para editar un producto
btnEdit.Click += delegate
{
    // Obtener el producto actual
    int productId = int.Parse(ProductModelId);
    Product productToUpdate = productList.FirstOrDefault(p => p.Id == productId);

    if (productToUpdate != null)
    {
        productToUpdate.Name = ProductModeName;
        productToUpdate.Description = ProductModeDescription;

        if (dataProvider.UpdateProduct(productToUpdate))
        {
            isSuccessful = true;
            message = "Product updated successfully.";
            RefreshProductList();
        }
        else
        {
            isSuccessful = false;
            message = "Failed to update the product.";
        }
    }
    else
    {
        isSuccessful = false;
        message = "Product not found.";
    }

    tabControl1.TabPages.Remove(tabPageProductList);
    tabControl1.TabPages.Add(tabPageProductDetail);
    tabPageProductDetail.Text = "Edit Product Mode";

    MessageBox.Show(message);
};

// Actualizar el método DeleteEvent para eliminar un producto
btnDelet.Click += delegate
{
    // Obtener el producto actual
    int productId = int.Parse(ProductModelId);

    if (dataProvider.DeleteProduct(productId))
    {
        isSuccessful = true;
        message = "Product deleted successfully.";
        RefreshProductList();
    }
    else
    {
        isSuccessful = false;
        message = "Failed to delete the product.";
    }

    MessageBox.Show(message);
};

   
