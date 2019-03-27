/* asyncClient.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asyncLibrary;

namespace Parse_JSON_Version_1
{
    public partial class asyncClient : Form
    {
        private Dictionary<int, PlayerInformationAVL> _playerAVL = new Dictionary<int, PlayerInformationAVL>();

        /// <summary>
        /// Initialize the asyncClient form.
        /// </summary>
        public asyncClient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method is async, which means the UI can still run.
        /// The program is awaiting the response from the FootballPlayerProcessor.
        /// Utilizes a foreach loop to displays the player names on the uxList.
        /// </summary>
        /// <param name="sender">Go Button</param>
        /// <param name="e"></param>
        private async void uxGo_Click(object sender, EventArgs e)
        {
            FootballPlayerModel allPlayers = await FootballPlayerProcessor.LoadPlayerInformation(uxAsyncURL.Text);
            
            foreach (FootballPlayerModel.allPlayers player in allPlayers.player)
            {
                //debugOutput(player.name.ToString() + " - " + player.id.ToString());
                uxList.Items.Add(player.name);
            }
        }
        /// <summary>
        /// This method is async, which means the UI can still run.
        /// This method creates an AVL tree sorted by player id numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void uxAVLTree_Click(object sender, EventArgs e)
        {
            FootballPlayerModel allPlayers = await FootballPlayerProcessor.LoadPlayerInformation(uxAsyncURL.Text);

            foreach (FootballPlayerModel.allPlayers player in allPlayers.player)
            {
                //int id = Convert.ToInt32(player.id);
                int id = player.id;
                string name = player.name;
                string position = player.Position;
                player.rosterStatus = "POWER!";
                string rosterStatus = player.rosterStatus;
                _playerAVL.Add(id, new PlayerInformationAVL(name, position, rosterStatus));
            }
        }

        private void uxSearchAVL_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<int, PlayerInformationAVL>> list = new List<KeyValuePair<int, PlayerInformationAVL>>();
            /*
            _playerAVL.CopyTo(list);
            foreach(KeyValuePair<int, PlayerInformationAVL> information in list)
            {
                uxList.Items.Add(information.Value.ToString());
            }
            */
            for (int i = 0151; i < 14053; i++)
            {
                if (_playerAVL.TryGetValue(i, out PlayerInformationAVL playerInformation))
                {
                    uxList.Items.Add(playerInformation.ToString());
                }
                else
                {
                    uxList.Items.Add("No Player Found with id of " + i);
                }
            }  
        }

        private void uxAllPlayerURL_Click(object sender, EventArgs e)
        {
            uxAsyncURL.Text = "http://www54.myfantasyleague.com/2018/export?TYPE=players&DETAILS=&SINCE=&PLAYERS=&JSON=1";
        }

        private void uxAllRosterURL_Click(object sender, EventArgs e)
        {
            uxAsyncURL.Text = "http://www54.myfantasyleague.com/2018/export?TYPE=rosters&L=30916&APIKEY=ahBp1sybvuKnx1OmO1nIYDQeHLox&FRANCHISE=&JSON=1";
        }

    }
}
