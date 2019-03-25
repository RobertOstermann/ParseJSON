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
        public asyncClient()
        {
            InitializeComponent();
        }

        private async void uxGo_Click(object sender, EventArgs e)
        {
            FootballPlayerModel allPlayers = await FootballPlayerProcessor.LoadPlayerInformation();
            
            foreach (FootballPlayerModel.allPlayers player in allPlayers.player)
            {
                //debugOutput(player.name.ToString() + " - " + player.id.ToString());
                uxList.Items.Add(player.name);
            }
        }

        private void debugOutput(string debugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(debugText + Environment.NewLine);
                uxResponse.Text = uxResponse.Text + debugText + Environment.NewLine;
                uxResponse.SelectionStart = uxResponse.TextLength;
                uxResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
