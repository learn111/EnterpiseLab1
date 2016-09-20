using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using Common;
using Presentation.Views;

namespace CookBook.Views
{
    public partial class FoodstuffsForm : Form, IFoodstuffView
    {
        public FoodstuffsForm()
        {
            InitializeComponent();
            dgvFoodstuffs.DataError += (s, e) => { };
            dgvFoodstuffs.DataSource = bsFoodstuffs;
            var measurementUnitsColumn = dgvFoodstuffs.Columns.OfType<DataGridViewComboBoxColumn>()
                .Single(x => x.DataPropertyName.Equals(nameof(FoodstuffModel.MeasurementUnitId)));
            measurementUnitsColumn.DataSource = bsMeasurementUnits;
            measurementUnitsColumn.ValueMember = "Value";
            measurementUnitsColumn.DisplayMember = "Key";
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public IEnumerable<FoodstuffModel> Foodstuffs
        {
            get { return (IEnumerable<FoodstuffModel>) bsFoodstuffs.DataSource; }
            set { bsFoodstuffs.DataSource = value.ToList(); }
        }

        public IEnumerable<KeyValueStringInt> MeasurementUnits
        {
            set { bsMeasurementUnits.DataSource = value.ToList(); }
        }

        public event Action SaveClicked;

        private void FoodstuffsForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke();
        }
    }
}