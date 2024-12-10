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
using System.Xml;

namespace nLayeredDesign.Presentation
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EFCategoryDAL());
            InitializeComponent();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Adding is completed as successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int toBeDeletedId = int.Parse(txtCategoryId.Text);
            var toBeDeletedValue = _categoryService.TGetById(toBeDeletedId);
            _categoryService.TDelete(toBeDeletedValue);
            MessageBox.Show("Deleting Process is completed");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            
            int toBeGetById = int.Parse(txtCategoryId.Text); 
            var category = _categoryService.TGetById(toBeGetById); // Tek bir nesne döner

            // Tek nesneyi listeye çevirerek DataGridView'e bağla
            dataGridView1.DataSource = new List<Category> { category };
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;

            _categoryService.TUpdate(updatedValue);
        }
    }
}
