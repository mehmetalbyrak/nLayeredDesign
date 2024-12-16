using nLayeredDesign.Business.Abstract;
using nLayeredDesign.Business.Concrete;
using nLayeredDesign.DataAccess.EntityFramework;
using nLayeredDesign.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nLayeredDesign.Presentation
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDAL());
            _categoryService = new CategoryManager(new EFCategoryDAL());
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnListv2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int toBeDeletedId = int.Parse(txtProductId.Text);
            var toBeDeletedValue = _productService.TGetById(toBeDeletedId);
            _productService.TDelete(toBeDeletedValue);
            MessageBox.Show("Deleting Process is Completed");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbProductCategory.DataSource = values;
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            product.ProductPrice = int.Parse(txtProductPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductDescription = txtProductDescription.Text;
            product.ProductStock = int.Parse(txtProductStock.Text);

            _productService.TInsert(product);
            MessageBox.Show("Addition process is done :d");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            dataGridView1.DataSource = value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var toBeUpdatedValue = _productService.TGetById(id);

            toBeUpdatedValue.ProductDescription = txtProductDescription.Text;
            toBeUpdatedValue.CategoryId = int.Parse(cmbProductCategory.SelectedIndex.ToString());
            toBeUpdatedValue.ProductPrice = int.Parse(txtProductPrice.Text);
            toBeUpdatedValue.ProductStock = int.Parse(txtProductStock.Text);
            toBeUpdatedValue.ProductName = txtProductName.Text;

            _productService.TUpdate(toBeUpdatedValue);
            MessageBox.Show("Updating process is completed :d ");
        }
    }
}
