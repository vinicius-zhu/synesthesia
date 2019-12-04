using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synesthesia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxLight.Text) & !String.IsNullOrEmpty(textBoxSound.Text))
                {
                    textBoxLight.Text = Math.Floor(Converter.SoundToLight(Double.Parse(textBoxSound.Text))).ToString();
                    textBoxSound.Text = "";
                    pictureBoxColor.BackColor = Converter.GetColorFromFrequency(Convert.ToDouble(textBoxLight.Text));
                }
                else if (String.IsNullOrEmpty(textBoxSound.Text) & !String.IsNullOrEmpty(textBoxLight.Text))
                {
                    textBoxSound.Text = Math.Floor(Converter.LightToSound(Double.Parse(textBoxLight.Text))).ToString();
                    pictureBoxColor.BackColor = Converter.GetColorFromFrequency(Convert.ToDouble(textBoxLight.Text));
                    textBoxLight.Text = "";
                }
            }
            catch { }
        }
    }
}
