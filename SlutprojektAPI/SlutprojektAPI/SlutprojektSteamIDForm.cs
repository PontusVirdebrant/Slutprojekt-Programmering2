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
        public Panel activePanel = new Panel(); // Detta låter mig lättare kontrollera de olika panelerna och skifta mellan dem

        public SlutprojektSteamIDForm()
        {
            InitializeComponent();
            activePanel = panelStart;
        }
        private void StartButton_Click(object sender, EventArgs e) // Vad som händer när man trycker på "Start" knappen
        {
            ID = IDTextBox.Text.ToString();
            SteamIDError.Clear();
            Profil(ID); //Hämtar offentlig information om en profil genom min metod som ligger under
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
                ID = menu.response.players[0].steamid;
                activePanel.Visible = false;
                activePanel = panelVisaData; // Byter Panel som visas
                activePanel.Visible = true;
                PersonaNameLabel.Text = menu.response.players[0].personaname;
                if(menu.response.players[0].communityvisibilitystate == 0 || menu.response.players[0].communityvisibilitystate == 1 || menu.response.players[0].communityvisibilitystate == 2)
                {
                    PrivatKontoLabel.Text = "Användarens konto är privat eller endast tillgängligt för personens vänner";
                }
                else
                {
                    ProfilePicture64.Visible = true;
                    ProfilePicture64.ImageLocation = menu.response.players[0].avatarmedium;
                }
            }
            catch
            {
                IDTextBox.ResetText();
                SteamIDError.SetError(IDTextBox, "Felaktigt SteamID"); // Om SteamID som angetts inte är korrekt visas ett felmeddelande
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelInputHelp_Click(object sender, EventArgs e) //Skickar användaren till en hemsida där de kan hämta sitt 64-bit SteamID genom användarens standardwebbläsare
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://steamidfinder.com/");
            Process.Start(sInfo);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Rensa();
            activePanel.Visible = false;
            activePanel = panelStart;
            activePanel.Visible = true;

        }

        private void Rensa()
        {
            IDTextBox.Clear();
            PersonaNameLabel.ResetText();
            PrivatKontoLabel.ResetText();
            ProfilePicture64.Dispose();
        }
    }
}
