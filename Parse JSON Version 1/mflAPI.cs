using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asyncLibrary;

namespace Parse_JSON_Version_1
{
    public partial class mflAPI : Form
    {
        public mflAPI()
        {
            InitializeComponent();
        }

        private async void uxAccessMFL_Click(object sender, EventArgs e)
        {
            MFLPlayerModel.ApiAllPlayerObject allPlayers = await MFLPlayerProcessor.LoadPlayerInformation();

            foreach (MFLPlayerModel.ApiAllPlayerObject.ApiPlayerObject mflPlayer in allPlayers.Player)
            {
                //debugOutput(player.name.ToString() + " - " + player.id.ToString());
                uxPlayerList.Items.Add(mflPlayer.Name);
            }
        }
    }
}
