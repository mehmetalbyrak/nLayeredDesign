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
        public FrmProduct()
        {
            InitializeComponent();
        }

        ProductManager productManager = new ProductManager(new EFProductDAL());

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = productManager.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnListv2_Click(object sender, EventArgs e)
        {
            var values = productManager.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
