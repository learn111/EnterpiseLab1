using System;
using System.Windows.Forms;
using Presentation.Views;

namespace CookBook.Views
{
    public partial class MainForm : Form, IMainView
    {
        private readonly ApplicationContext _applicationContext;

        public MainForm(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            InitializeComponent();
        }

        public new void ShowDialog()
        {
            _applicationContext.MainForm = this;
            Application.Run(_applicationContext);
        }

        public event Action FoodstuffsClicked;
        public event Action MeasurementUnitsClicked;

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void ингридиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodstuffsClicked?.Invoke();
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementUnitsClicked?.Invoke();
        }
    }
}