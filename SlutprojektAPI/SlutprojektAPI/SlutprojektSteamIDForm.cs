using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlutprojektAPI
{
    public partial class SlutprojektSteamIDForm : Form
    {
        public String ID = "";

        public SlutprojektSteamIDForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) // Vad som händer när man trycker på "Start" knappen
        {
            ID = IDTextBox.Text.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SteamIDFinder(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://steamidfinder.com/");
            Process.Start(sInfo);
        }
    }
}
