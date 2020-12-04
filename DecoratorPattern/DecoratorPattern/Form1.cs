using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        ICar car;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddExtra_Click(object sender, EventArgs e)
        {
            if (radioButtonFord.Checked)
            {
                car = new Ford("Ford", 45000.75);
            }

            if (radioButtonBmw.Checked)
            {
                car = new BMW("BMW", 55000.98);
            }

            if (radioButtonFerrari.Checked)
            {
                car = new Ferrari("Ferrari", 70000);
            }

            if (checkBoxArco.Checked)
            {
                car = new Arco(car);
            }

            if (checkBoxBullbar.Checked)
            {
                car = new Bullbar(car);
            }

            if (checkBoxSnowtyre.Checked)
            {
                car = new SnowTyres(car);
            }

            textBoxTp.Text = Convert.ToString(car.getPrice());
            listBox1.Items.Add(car.getDescription());
        }
    }
}
