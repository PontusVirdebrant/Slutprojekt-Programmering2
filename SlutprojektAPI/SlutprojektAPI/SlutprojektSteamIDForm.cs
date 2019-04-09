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
// Steam API key 3E9DFE3D214B158BD401D83E7BE7ECE4
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
            Profil(); //Hämtar offentlig information om en profil genom min metod som ligger under
            Friendslist(); // Hämtar och lägger in Vänlisteinfo samtidigt som den personliga profilen. Gör att all datainladdning görs i början istället för när användaren trycker på knappen för vänlistan.
            // !!NOTERA!! Friendslist tar extremt lång tid att hämta/ ladda in då programmet måste byta mellan två API:er för att omvandla ett SteamID till användarnamn
        }
        private void LiteSearchButton_Click(object sender, EventArgs e) // Söker endast upp en profil utan vänlista för att minska laddtid.
        {
            ID = IDTextBox.Text.ToString();
            SteamIDError.Clear();
            Profil();
        }

        private void Profil()
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
                    ProfilePicture184.Visible = true;
                    ProfilePicture184.ImageLocation = menu.response.players[0].avatarfull;
                }
                if (menu.response.players[0].realname != null)
                {
                    RealName.Text = menu.response.players[0].realname;
                }
                else
                {
                    RealName.Text = "Inte angett";
                }
                TimeCreated.Text ="Konto skapades: " + DateTimeOffset.FromUnixTimeSeconds(menu.response.players[0].timecreated).ToString(); // Timecreated i Unix tid görs om till vanlig tideräkning och visas i TimeCreated labeln
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
            ProfilePicture184.ResetText();
            RealName.ResetText();
            TimeCreated.ResetText();
            FriendsListBox.Items.Clear();
        }

        private void ButtonVänlista_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = panelVänlista;
            activePanel.Visible = true;
        }
        public void Friendslist()
        {
            try { 
                var client = new RestClient("http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=3E9DFE3D214B158BD401D83E7BE7ECE4&steamid=" + ID); // Klient för vänlisteAPIn
                var request = new RestRequest("/", Method.GET);
                IRestResponse friendslist = client.Execute(request);
                String content = friendslist.Content;
                Vänner vänner = JsonConvert.DeserializeObject<Vänner>(content);
                int vänIndex = 0;
                string SteamId;
                List<String> IDs = new List<String>(); // Gör en lista för alla personens vänners SteamIDs

                foreach (object Friend in vänner.friendslist.friends)
                {
                    SteamId = vänner.friendslist.friends[vänIndex].steamid; // Går igenom datan som man får från API:n och lägger alla IDs i listan
                    IDs.Add(SteamId);
                    vänIndex++;
                }
                foreach (String items in IDs)
                {
                    FriendsListBox.Items.Add(AliasName(items)); // kallar en separat metod för att hämta användarnamn från användares SteamIDs
                }
            }
            catch{} // Tom catch för att förhindra kraschar. Felet hanteras redan i en annan Try-Catch
        }

        public string AliasName(string ID) // Skapar en ny klient för varje ID som fanns i listan
        {
            var client = new RestClient("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=3E9DFE3D214B158BD401D83E7BE7ECE4&steamids=" + ID);
            var request = new RestRequest("/", Method.GET);
            IRestResponse response = client.Execute(request);
            String content = response.Content;
            Profil menu = JsonConvert.DeserializeObject<Profil>(content);
            string personaName = menu.response.players[0].personaname;
            return personaName;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = panelVisaData;
            activePanel.Visible = true;
        }

        private void FriendsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var client = new RestClient("http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=3E9DFE3D214B158BD401D83E7BE7ECE4&steamid=" + ID); 
            var request = new RestRequest("/", Method.GET);
            IRestResponse friendslist = client.Execute(request);
            String content = friendslist.Content;
            Vänner vänner = JsonConvert.DeserializeObject<Vänner>(content);
            List<String> IDs = new List<String>();

            ID = vänner.friendslist.friends[FriendsListBox.SelectedIndex].steamid; // Sätter ID att hämta data från till det ID som man trycker på i listan. Hämtar in både profil och vänlista
            Rensa();
            Profil();
            Friendslist();
        }


    }
}
