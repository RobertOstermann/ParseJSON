/* JSONParser.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using asyncLibrary;

namespace Parse_JSON_Version_1
{
    public partial class JSONParser : Form
    {
        /// <summary>
        /// Initialize the JSONParser form.
        /// Initialize the apiAsyncClient, which is a static object(only initialize once).
        /// </summary>
        public JSONParser()
        {            
            InitializeComponent();
            apiAsyncClient.InitializeClient();
        }
        /// <summary>
        /// Call the deserializeJSON function.
        /// </summary>
        /// <param name="sender">Deserialize Button</param>
        /// <param name="e"></param>
        private void uxDeserialize_Click(object sender, EventArgs e)
        {
            deserializeJSON(uxSerializedString.Text);
        }
        /// <summary>
        /// Clear the output window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClearDebug_Click(object sender, EventArgs e)
        {
            uxOutput.Text = string.Empty;
        }
        /// <summary>
        /// Loop through the football players and add each name/id using debugOutput.
        /// </summary>
        /// <param name="strJSON">Text from uxSerializedString textbox.</param>
        private void deserializeJSON(string strJSON)
        {
            try
            {
                /*jsonPersonArray jPerson = JsonConvert.DeserializeObject<jsonPersonArray>(strJSON);
                debugOutput("Here is our JSON object: " + jPerson.ToString());
                debugOutput("Here is the firstname: " + jPerson.firstname.ToString());
                debugOutput("Here is the street address: " + jPerson.address.streetAddress);
                debugOutput("Attempting to print phone numbers...");
                foreach(jsonPersonArray.phoneNum num in jPerson.phoneNumbers)
                {
                    debugOutput(num.type.ToString() + " - " + num.number.ToString());
                }*/

                FootballPlayer mflPlayer = JsonConvert.DeserializeObject<FootballPlayer>(strJSON);

                foreach(FootballPlayer.PlayerInfo.allPlayers player in mflPlayer.players.player)
                {
                    debugOutput(player.name.ToString() + " - " + player.id.ToString());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Writes text to the uxOutput textbox. 
        /// </summary>
        /// <param name="debugText">String to write to uxOutput.</param>
        private void debugOutput(string debugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(debugText + Environment.NewLine);
                uxOutput.Text = uxOutput.Text + debugText + Environment.NewLine;
                uxOutput.SelectionStart = uxOutput.TextLength;
                uxOutput.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        /// <summary>
        /// Initializes the restClient.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRest_Click(object sender, EventArgs e)
        {
            restClient client = new restClient();
            client.ShowDialog();
        }
        /// <summary>
        /// Initializes the asyncClient.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAsync_Click(object sender, EventArgs e)
        {
            asyncClient client = new asyncClient();
            client.ShowDialog();
        }
    }
}
