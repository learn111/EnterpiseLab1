using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using Presentation.Views;

namespace CookBook.Views
{
    public partial class DishTypesForm : Form, IDishTypesView
    {
        public DishTypesForm()
        {
            InitializeComponent();
            dgvDishTypes.DataSource = bsDishTypes;
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public IEnumerable<DishTypeModel> DishTypes
        {
            get { return (IEnumerable<DishTypeModel>) bsDishTypes.DataSource; }
            set { bsDishTypes.DataSource = value.ToList(); }
        }

        public event Action SaveClicked;

        private void DishTypesForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke();
        }
    }
}