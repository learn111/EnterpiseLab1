using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using Presentation.Views;

namespace CookBook.Views
{
    public partial class MeasurementUnitsForm : Form, IMeasurementUnitsView
    {
        public MeasurementUnitsForm()
        {
            InitializeComponent();
            dgvMeasurementUnits.DataSource = bsMeasurementUnits;
        }


        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public event Action SaveClicked;

        public IEnumerable<MeasurementUnitModel> MeasurementUnitModels
        {
            get { return (IEnumerable<MeasurementUnitModel>) bsMeasurementUnits.DataSource; }
            set { bsMeasurementUnits.DataSource = value.ToList(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke();
        }
    }
}