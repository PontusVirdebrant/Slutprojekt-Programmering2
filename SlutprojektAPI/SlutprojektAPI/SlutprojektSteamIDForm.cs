using Newtonsoft.Json;
using RestSharp;
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
            SteamIDError.Clear();
            Profil(ID); //Hämtar offentlig information om en profil
        }
        // Steam API key 3E9DFE3D214B158BD401D83E7BE7ECE4

        private void Profil(String ID)
        {
            var client = new RestClient("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=3E9DFE3D214B158BD401D83E7BE7ECE4&steamids=" + ID);
            var request = new RestRequest("/", Method.GET);
            IRestResponse response = client.Execute(request);
            String content = response.Content;
            Profil menu = JsonConvert.DeserializeObject<Profil>(content);

            try
            {
                if (ID == menu.response.players[0].steamid)
                {
                    PersonaNameLabel.Text = menu.response.players[0].personaname;
                }
            }
            catch
            {
                IDTextBox.Text = "";
                SteamIDError.SetError(this.IDTextBox, "Felaktigt SteamID");
            }
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
