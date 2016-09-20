using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using Common;
using Presentation.Views;

namespace CookBook.Views
{
    public partial class DishesToFoodstuffsForm : Form, IDishesToFoodstuffsView
    {
        public DishesToFoodstuffsForm()
        {
            InitializeComponent();
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public IEnumerable<KeyValueStringInt> Dishes
        {
            set { bsDishes.DataSource = value.ToList(); }
        }

        public IEnumerable<DishToFoodstuffsModel> DishesToFoodstuffs
        {
            get { return (IEnumerable<DishToFoodstuffsModel>) bsDishesToFoodstuffs.DataSource; }
            set { bsDishesToFoodstuffs.DataSource = value.ToList(); }
        }

        public int DishId => (int) cmbDishes.SelectedValue;
        public event Action<int> DishChanged;
        public event Action SaveClicked;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke();
        }

        private void cmbDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishChanged?.Invoke((int) cmbDishes.SelectedValue);
        }
    }
}