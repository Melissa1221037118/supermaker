using supermarket.Models;
using supermarket.Models.Interfaces;
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
    public partial class CategoriaView : Form, ICategoriaModelView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategoriaView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabPage.TabPages.Remove(tabPagePayModeList);
                tabPage.TabPages.Add(tabPageModeDetail);
                tabPageModeDetail.Text = "Add new Pay mode";
            };

            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabPage.TabPages.Remove(tabPagePayModeList);
                tabPage.TabPages.Add(tabPageModeDetail);
                tabPageModeDetail.Text = "Edit Categoria Mode";
            };
            BtnDelete.Click += delegate {

                var result = MessageBox.Show(
                    "Are sure you want to delete the selected Pay Mode",
                    "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabPage.TabPages.Remove(tabPageModeDetail);
                    tabPage.TabPages.Add(tabPagePayModeList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabPage.TabPages.Remove(tabPageModeDetail);
                tabPage.TabPages.Add(tabPagePayModeList);

            };
        }


        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string CategoriaModelId {
            get { return tabPage.Text; }
            set { tabPage.Text = value; }
        }
        public string CategoriaModeName {
            get { return TxtCategoryName.Text; }
            set { TxtCategoryName.Text = value; }
        }
        public string CategoriaModeDescription {
            get { return TxtPayModeDescription.Text; }
            set { TxtCategoryDescription.Text = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgCategoriaMode.DataSource = payModeList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtPayModeObservation_TextChanged(object sender, EventArgs e)
        {

        }

        private static CategoriaView instance;


        public static CategoriasModel GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriaView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        public void SetCategoriaModeListBildingSource(BindingSource payModeList)
        {
            throw new NotImplementedException();
        }
    }
}

