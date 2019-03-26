/* restClient.cs
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
using System.Net;

namespace Parse_JSON_Version_1
{
    public partial class restClient : Form
    {
        /// <summary>
        /// Initialize the restClient form.
        /// </summary>
        public restClient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initializes an apiClient.
        /// Sets the endPoint to the text from uxResURL textbox.
        /// Writes the response using debugOutput.
        /// </summary>
        /// <param name="sender">Go Button</param>
        /// <param name="e"></param>
        private void uxGo_Click(object sender, EventArgs e)
        {
            apiClient client = new apiClient();
            client.endPoint = uxRestURL.Text;

            debugOutput("REST Client Created");

            string response = string.Empty;

            response = client.makeRequest();

            debugOutput(response);
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
