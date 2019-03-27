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
        public Dictionary<int, ImmutablePlayerInfo> _playerAVL = new Dictionary<int, ImmutablePlayerInfo>();

        public mflAPI()
        {
            InitializeComponent();
        }

        private async void uxAccessMFL_Click(object sender, EventArgs e)
        {
            MFLPlayerModel.ApiAllPlayerObject allPlayers = await MFLPlayerProcessor.LoadPlayerInformation();
            
            foreach(MFLPlayerModel.ApiAllPlayerObject.ApiPlayerObject mflPlayer in allPlayers.Player)
            {
                //debugOutput(player.name.ToString() + " - " + player.id.ToString());
                //uxPlayerList.Items.Add(mflPlayer.Name);
                ImmutablePlayerInfo playerInfo = new ImmutablePlayerInfo(mflPlayer.Name, Convert.ToInt32(mflPlayer.Id), null, null, 0.00M, mflPlayer.Position[0], false);
                _playerAVL.Add(Convert.ToInt32(mflPlayer.Id), playerInfo);
            }
            
            MFLPlayerModel.ApiRosterObject allRosters = await MFLPlayerProcessor.LoadRosterInformation();

            foreach(MFLPlayerModel.ApiRosterObject.APIRosterFranchiseObject mflRoster in allRosters.Franchise)
            {
                uxPlayerList.Items.Add(mflRoster.Id);
            }
            
            MFLPlayerModel.ApiLeagueObject allLeague = await MFLPlayerProcessor.LoadLeagueInformation();

            foreach(MFLPlayerModel.ApiLeagueObject.ApiAllFranchiseObject.ApiFranchiseObject mflFranchise in allLeague.Franchises.Franchise)
            {
                uxPlayerList.Items.Add(mflFranchise.Name.PadRight(30) + mflFranchise.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uxPlayerList.DataSource = null;
            List<KeyValuePair<int, ImmutablePlayerInfo>> list = new List<KeyValuePair<int, ImmutablePlayerInfo>>();
            _playerAVL.CopyTo(list);
            uxPlayerList.DataSource = list;
            uxPlayerList.DisplayMember = "Key";
        }
    }
}
