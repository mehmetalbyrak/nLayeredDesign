using nLayeredDesign.Business.Abstract;
using nLayeredDesign.Business.Concrete;
using nLayeredDesign.DataAccess.EntityFramework;
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
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDAL());
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

        }
    }
}
