using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace linkChecker
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            textBoxUrl.Text = "http://google.com";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {   
                if (richTextBoxResult.Text != "")  richTextBoxResult.Text="";
                if (!textBoxUrl.Text.StartsWith("http://") && !textBoxUrl.Text.StartsWith("ftp:/") && !textBoxUrl.Text.StartsWith("https://")) textBoxUrl.Text = "http://" + textBoxUrl.Text;
                if (label2.Text != "Result:") label2.Text = "Result:";
                WebRequest request = WebRequest.Create(textBoxUrl.Text);
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string status = ((HttpWebResponse)response).StatusDescription;
                richTextBoxResult.Text = "Checking>.. " + textBoxUrl.Text + " Status " + status + "\n";

                string pattern = @"(((http|https|ftp)+\:/\/)[&#95;a-z0-9\/&#95;:@=.+?,##%&~-]*[^.|\'|""|\# |!|\(|?|,| |>|<|;|\)])";

                MatchCollection numberoflinks = Regex.Matches(reader.ReadToEnd(), pattern,RegexOptions.Singleline);
                label2.Text = "Results found " + numberoflinks;

                int counter = 0;
                foreach (Match m in numberoflinks)
                {
                    string link = m.Groups[1].Value;
                    try
                    {
                        WebRequest newrequest = WebRequest.Create(link);
                        WebResponse newresponse = newrequest.GetResponse();
                        richTextBoxResult.AppendText("\n" + link + "  Status " + ((HttpWebResponse)newresponse).StatusCode);
                        newresponse.Close();
                        counter++;
                        label2.Text = "Results found " + counter;
                    }
                    catch (Exception ex)
                    {
                        richTextBoxResult.AppendText("\n" + link + " " + ex.Message);
                        counter++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
