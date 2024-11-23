using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst.EFProject
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        EFTravelDBEntities dB = new EFTravelDBEntities();

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            // Total Location Counts
            lblLocationCountsNumber.Text = dB.Locations.Count().ToString();
            
            // Total Capacity
            lblTotalCapacityNumber.Text = dB.Locations.Sum(x=>x.LocationCapacity).ToString();

            // Guide Counts
            lblGuideCountsNumber.Text= dB.Guides.Count().ToString();

            // Average Capacity (2 digits after point :d)
            lblAverageCapacityNumber.Text = $"{dB.Locations.Average(x => x.LocationCapacity):0.00}";

            // Average Trip Cost (2 digits after point :d)
            lblAverageTripCost.Text = $"{dB.Locations.Average(x => x.LocationPrice):0.00}" + " ₺";

            // Last Added Country
            int lastAddedCountryId = dB.Locations.Max(x => x.LocationId);
            lblLastAddedCountryName.Text = dB.Locations
                .Where(x => x.LocationId == lastAddedCountryId)
                .Select(y => y.LocationCountry)
                .FirstOrDefault();

            
            // Antalya Trip Capacity
            lblAntalyaTripCapacityNumber.Text = dB.Locations
                .Where(x => x.LocationCity == "Antalya")
                .Select(y => y.LocationCapacity)
                .FirstOrDefault().ToString();

            // Average Trip Capacities of Türkiye
            lblAvgCapacityOfTRTripsNumber.Text = dB.Locations
                .Where(x => x.LocationCountry == "Türkiye")
                .Average(y => y.LocationCapacity).ToString();

            // Guide of Rome's Trip
            var guideIdOfRome = dB.Locations
                .Where(x => x.LocationCity == "Rome")
                .Select(y => y.GuideId).FirstOrDefault();

            lblGuideOfRomeName.Text = dB.Guides.Where(x => x.GuideId == guideIdOfRome)
                .Select(y => y.GuidName + " " + y.GuidLastname)
                .FirstOrDefault().ToString();



            // Highest Capacity Trip
            var heighestCapacity = dB.Locations.Max(x => x.LocationCapacity);

            lblHeighestCapacityTripName.Text = dB.Locations
                .Where(x => x.LocationCapacity == heighestCapacity)
                .Select(y => y.LocationCity)
                .FirstOrDefault().ToString();


            // Most Expensive Trip
            var mostExpensiveTrip = dB.Locations.Max(x => x.LocationPrice);

            lblMostExpensiveTripName.Text = dB.Locations
                .Where(x => x.LocationPrice == mostExpensiveTrip)
                .Select(y => y.LocationCity)
                .FirstOrDefault().ToString();


            // The number of trips guided by Femke Bol
            var guideIdByNameFemkeBol = dB.Guides
                .Where(x => x.GuidName == "Femke" && x.GuidLastname == "Bol")
                .Select(y => y.GuideId)
                .FirstOrDefault();

         
            lblFemkeBolTripsNumber.Text = dB.Locations
                .Where(y => y.GuideId == guideIdByNameFemkeBol)
                .Count().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
