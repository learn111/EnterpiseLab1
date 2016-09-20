using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using Common;
using Presentation.Views;

namespace CookBook.Views
{
    public partial class DishesForm : Form, IDishesView
    {
        public DishesForm()
        {
            InitializeComponent();
            dgvDishes.DataError += (s, e) => { };
            dgvDishes.DataSource = bsDishes;
            var measurementUnitsColumn = dgvDishes.Columns.OfType<DataGridViewComboBoxColumn>()
                .Single(x => x.DataPropertyName.Equals(nameof(DishModel.DishTypeId)));
            measurementUnitsColumn.DataSource = bsDishTypes;
            measurementUnitsColumn.ValueMember = "Value";
            measurementUnitsColumn.DisplayMember = "Key";
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public IEnumerable<KeyValueStringInt> DishTypes
        {
            set { bsDishTypes.DataSource = value.ToList(); }
        }

        public IEnumerable<DishModel> Dishes
        {
            get { return (IEnumerable<DishModel>) bsDishes.DataSource; }
            set { bsDishes.DataSource = value.ToList(); }
        }

        public event Action SaveClicked;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke();
        }
    }
}