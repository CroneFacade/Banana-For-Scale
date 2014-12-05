using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BananaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateBananas_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            decimal bananaLengthinCM = 20.32m;

            switch (comboBoxMeasuringUnit.Text)
            {
                case "Meters":
                    decimal multiplier = 0.2032m;
                    decimal inputResult = (int.Parse(textBoxLengthInput.Text));
                    decimal inputInCM = inputResult * 100;
                    decimal bananas = inputInCM / bananaLengthinCM;
                    listBox1.Items.Add("It is about " + (int)bananas + " bananas.");
                    break;
                case "Decimeters":

                    break;
                case "Centimeters":

                    break;
                case "Millimeters":

                    break;
                default:
                    break;
            }
        }
    }
}
