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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EFTravelDBEntities db = new EFTravelDBEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Locations
                .Select(location => new
                {
                    location.LocationId,
                    location.LocationCity,
                    location.LocationCountry,
                    location.LocationCapacity,
                    location.LocationPrice,
                    location.DayNight,
                    location.GuideId,
                    GuideName = location.Guide.GuidName + " " + location.Guide.GuidLastname
                })
                .ToList();

            dataGridView1.DataSource = values;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guides.Select(x=>new
            {
                Fullname = x.GuidName + " " + x.GuidLastname,
                x.GuideId
            }).ToList();

            cmbGuideId.DisplayMember = "Fullname";
            cmbGuideId.ValueMember = "GuideId";
            cmbGuideId.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity = byte.Parse(numUpDownCapacity.Value.ToString());
            location.LocationCity = txtLocationCity.Text;
            location.LocationCountry = txtLocationCountry.Text;
            location.LocationPrice = decimal.Parse(txtLocationPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuideId.SelectedValue.ToString());
            db.Locations.Add(location);
            db.SaveChanges();
            MessageBox.Show("Adding process is completed as successfully :d");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var deletedValue = db.Locations.Find(id);
            db.Locations.Remove(deletedValue);
            db.SaveChanges();

            MessageBox.Show("done :d");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var updatedValue = db.Locations.Find(id);

            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.LocationPrice = decimal.Parse(txtLocationPrice.Text);
            updatedValue.LocationCapacity = byte.Parse(numUpDownCapacity.Value.ToString());
            updatedValue.LocationCity = txtLocationCity.Text;
            updatedValue.LocationCountry = txtLocationCountry.Text;
            updatedValue.GuideId = int.Parse(cmbGuideId.SelectedValue.ToString());

            db.SaveChanges();
            MessageBox.Show("update process is done :d");
        }
    }
}
