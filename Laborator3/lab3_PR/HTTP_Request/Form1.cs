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

namespace lab1HTTP
{
    public partial class Form1 : Form
    {
        string Url = "http://google.com";
        string postUrl = "http://www.contoso.com/PostAccepter.aspx ";
        string postData = "This is a test that posts this string to a Web server.";

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBoxUrl.Text = "http://google.md/";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            if (comboBox1.SelectedIndex == 2){
                Url = textBoxUrl.Text;
                textBoxUrl.Text = postUrl;
                textBoxData.Text = postData;
                labelData.Visible = true;
                textBoxData.Visible = true;
            }
            else if (comboBox1.SelectedIndex != 2){
                if (labelData.Visible == true || textBoxData.Visible == true){
                    textBoxUrl.Text = Url;
                    labelData.Visible = false;
                    textBoxData.Visible = false;
                }
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (!textBoxUrl.Text.StartsWith("http://") && !textBoxUrl.Text.StartsWith("ftp:/") && !textBoxUrl.Text.StartsWith("https://")) textBoxUrl.Text = "http://" + textBoxUrl.Text;

            if (comboBox1.SelectedIndex == 0)
            {
                try
                {   
                    WebRequest request = WebRequest.Create(textBoxUrl.Text);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = request.GetResponse();
                    richTextBoxResult.AppendText("Status " + ((HttpWebResponse)response).StatusDescription + "\n\n");
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    richTextBoxResult.AppendText(reader.ReadToEnd());
                    reader.Close();
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    WebRequest request = WebRequest.Create(textBoxUrl.Text);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    request.Method = "HEAD";
                    WebResponse response = request.GetResponse();
                    richTextBoxResult.AppendText("Status " + ((HttpWebResponse)response).StatusDescription + "\n\n");
                    richTextBoxResult.AppendText(response.Headers.ToString());
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    postData = textBoxData.Text;
                    WebRequest request = WebRequest.Create(postUrl);
                    request.Method = "POST";
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    request.ContentType = "application/x-www-form-urlencoded"; //multipart/form-data  
                    request.ContentLength = byteArray.Length;
                    Stream dataStream = request.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                    WebResponse response = request.GetResponse();
                    richTextBoxResult.AppendText("Status " + ((HttpWebResponse)response).StatusDescription + "\n\n");
                    dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    richTextBoxResult.AppendText(reader.ReadToEnd());
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
        }

    }
}
