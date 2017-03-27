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
using System.IO;
using System.Text.RegularExpressions;

namespace Web_Crawler
{
    public partial class Form1 : Form
    {
        string url = "http://torrentsmd.com";

        public Form1()
        {
            InitializeComponent();
            textBoxHops.Text = "10";
            textBoxUrl.Text = "http://google.com";
        }

        private void textBoxHops_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)) e.Handled=true;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (!textBoxUrl.Text.StartsWith("http://") && !textBoxUrl.Text.StartsWith("ftp://") && !textBoxUrl.Text.StartsWith("https://")) textBoxUrl.Text = "http://" + textBoxUrl.Text;
            for (int i = 0; i < Convert.ToInt32(textBoxHops.Text);i++)
            {
                WebRequest newRequest = WebRequest.Create(url);
                WebResponse newResponse = newRequest.GetResponse();
                Stream newStream = newResponse.GetResponseStream();
                StreamReader newReader = new StreamReader(newStream);
                richTextBoxResult.AppendText("\n" + url + "  Status " + ((HttpWebResponse)newResponse).StatusCode);

                string pattern = @"(((http|https|ftp)+\:/\/)[&#95;a-z0-9\/&#95;:@=.+?,##%&~-]*[^.|\'|""|\# |!|\(|?|,| |>|<|;|\)])";
                MatchCollection links = Regex.Matches(newReader.ReadToEnd(), pattern, RegexOptions.Singleline);

                index:
                Random rand = new Random();
                url = links[rand.Next(links.Count)].Value;
                if (((HttpWebResponse)newResponse).StatusCode.ToString() != "OK") goto index;

                newResponse.Close();
                newReader.Close();


            }

            /*if (richTextBoxResult.Text != "") richTextBoxResult.Text = "";
            if (!textBoxUrl.Text.StartsWith("http://") && !textBoxUrl.Text.StartsWith("ftp:/") && !textBoxUrl.Text.StartsWith("https://")) textBoxUrl.Text = "http://" + textBoxUrl.Text;

            WebRequest request = WebRequest.Create(textBoxUrl.Text);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string status = ((HttpWebResponse)response).StatusDescription;
            richTextBoxResult.AppendText("Checking>.. " + textBoxUrl.Text + " Status " + status + "\n");
            string pattern = @"(((http|https|ftp)+\:/\/)[&#95;a-z0-9\/&#95;:@=.+?,##%&~-]*[^.|\'|""|\# |!|\(|?|,| |>|<|;|\)])";
            MatchCollection links = Regex.Matches(reader.ReadToEnd(), pattern, RegexOptions.Singleline);
            Random rand = new Random();
            richTextBoxResult.AppendText(links[rand.Next(links.Count)].Value + " \n");
            
            for (int i = 0; i < Convert.ToInt32(textBoxHops.Text); i++)
            {   
                
                Random rand = new Random();
                string link = links[i].Value;
                richTextBoxResult.AppendText(links + " \n");
                
                //.Groups[rand.Next(Convert.ToInt32(links))].Value;
            }*/
        }


    }
}
