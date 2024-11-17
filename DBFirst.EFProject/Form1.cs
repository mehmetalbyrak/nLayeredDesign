using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EFTravelDBEntities db = new EFTravelDBEntities();
        private void btnList_Click(object sender, EventArgs e)
        { 
            var values = db.Guides.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuidName = txtGuideName.Text;
            guide.GuidLastname = txtGuideLastname.Text;
            db.Guides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide is added as successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideId.Text);
            var toBeDeletedValue = db.Guides.Find(id);
            db.Guides.Remove(toBeDeletedValue);
            db.SaveChanges();
            MessageBox.Show("Guide is deleted as successfully :d");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideId.Text);
            var toBeUpdatedValue = db.Guides.Find(id);
            toBeUpdatedValue.GuidName = txtGuideName.Text;
            toBeUpdatedValue.GuidLastname= txtGuideLastname.Text;
            db.SaveChanges();
            MessageBox.Show("Guide is updated as successfully :d", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideId.Text);
            var values = db.Guides.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
