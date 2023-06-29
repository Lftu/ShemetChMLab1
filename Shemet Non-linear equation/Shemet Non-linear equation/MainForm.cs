using Shemet_Non_linear_equation.Classes.Strategies;
using Shemet_Non_linear_equation.CLasses;

namespace Shemet_Non_linear_equation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Output.List = IterationsListBox;
            Output.ClearList();
        }

        private void FindRootButton_Click(object sender, EventArgs e)
        {
            Output.ClearList();

            Strategy strategy;

            if (NewtonModOptionButton.Checked)
            {
                strategy = new NewtonStrategy();
            }
            else if (SimpleIterationOptionButton.Checked)
            {
                strategy = new SimpleIterationStrategy();
            }
            else
            {
                strategy = new RelaxationStrategy();
            }

            double.TryParse(textBox1.Text, out strategy.precision);
            double.TryParse(textBox2.Text, out strategy.approximateX);

            if (strategy.precision == 0)
            {
                strategy.precision = 0.0000001;
            }
            strategy.FindRoot1();
        }
    }
}