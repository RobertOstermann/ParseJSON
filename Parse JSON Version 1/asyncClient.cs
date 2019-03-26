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
        /// <summary>
        /// Initialize the asyncClient form.
        /// </summary>
        public asyncClient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method is async, which means the UI can still run
        /// while the program is awaiting the response from the FootballPlayerProcessor.
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
    }
}
