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
                {  // Går att få 4 svar från APIn men 0, 1 och 2 innebär samma för en icke inloggad åtkomst av APIn
                    PrivatKontoLabel.Text = "Användarens konto är privat eller endast tillgängligt för personens vänner";
                }
                else
                {
                    ProfilePicture64.Visible = true;
                    ProfilePicture64.ImageLocation = menu.response.players[0].avatarmedium;
                }
                if (menu.response.players[0].realname != null)
                {
                    RealName.Text = menu.response.players[0].realname;
                }
                TimeCreated.Text = DateTimeOffset.FromUnixTimeSeconds(menu.response.players[0].timecreated).ToString(); // Timecreated i Unix tid görs om till vanlig tideräkning och visas i TimeCreated labeln
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
            ProfilePicture64.ResetText();
            RealName.ResetText();
            TimeCreated.ResetText();
            FriendsListBox.Items.Clear();
        }

        private void ButtonVänlista_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = panelVänlista;
            activePanel.Visible = true;

            var client = new RestClient("http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=3E9DFE3D214B158BD401D83E7BE7ECE4&steamid=" + ID);
            var request = new RestRequest("/", Method.GET);
            IRestResponse friendslist = client.Execute(request);
            String content = friendslist.Content;
            Vänner vänner = JsonConvert.DeserializeObject<Vänner>(content);
            int vänIndex = 0;
            string SteamId;
            List<String> IDs = new List<String>();
            
            foreach (object Friend in vänner.friendslist.friends)
            {
                SteamId = vänner.friendslist.friends[vänIndex].steamid;
                IDs.Add(SteamId);
                vänIndex++;
            }
            foreach (String items in IDs)
            {
                FriendsListBox.Items.Add(AliasName(IDs));
            }
        }

        public string AliasName(string ID)
        {
            var client = new RestClient("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=3E9DFE3D214B158BD401D83E7BE7ECE4&steamids=" + ID);
            var request = new RestRequest("/", Method.GET);
            IRestResponse response = client.Execute(request);
            String content = response.Content;
            Profil menu = JsonConvert.DeserializeObject<Profil>(content);
            string personaName = menu.response.players[0].personaname;
            return personaName;
        }
    }
}
