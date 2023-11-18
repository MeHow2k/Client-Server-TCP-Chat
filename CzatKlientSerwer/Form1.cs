using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Windows.Controls;

namespace CzatKlientSerwer
{
    public partial class Serwer : Form
    {
        //Prywatne pola Serwera
        private TcpListener serwer;
        private TcpClient klient;
        public StreamReader streamreader;
        public StreamWriter streamwriter;
        public string odebrana;
        public string wysylana;
        private int connecterr;
        private IPEndPoint IP;
        private IPAddress adresIP;
        public Serwer()
        {
            InitializeComponent();
        }

        private void Serwer_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            connecterr= 0;
            
            try
            {
                adresIP = IPAddress.Parse(adresBox.Text);
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP!", "Błąd");
                labelStan.Text = "Błąd! Błędny format adresu IP!";
                adresBox.Text = String.Empty;
                return;
            }

            int port = System.Convert.ToInt16(portUpDown.Value);
            labelStan.Text = "";

            try
            {               
                serwer = new TcpListener(adresIP, port);                
                serwer.Start();             
                klient = serwer.AcceptTcpClient();             
                IP = (IPEndPoint)klient.Client.RemoteEndPoint;
                streamreader = new StreamReader(klient.GetStream());
                streamwriter = new StreamWriter(klient.GetStream());
                streamwriter.AutoFlush = true;
                WysylanieWorker.WorkerSupportsCancellation = true;
                OdbieranieWorker.WorkerSupportsCancellation = true;
                komunikatyListBox.Items.Add("[" + IP.ToString() + "] : Nawiązano połączenie.");
                //przewijanie na sam dół
                komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                labelStan.Text = "Połączono z klientem: "+IP.ToString();
                startButton.Enabled = false;
                stopButton.Enabled = true;
                sendButton.Enabled = true;
                OdbieranieWorker.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                komunikatyListBox.Items.Add("Błąd tworzenia serwera!");
                //przewijanie na sam dół
                komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                MessageBox.Show("Błąd tworzenia serwera!", "Błąd");
                labelStan.Text = "Błąd tworzenia serwera! ";
            }

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            OdbieranieWorker.CancelAsync();
            komunikatyListBox.Items.Add("Zakończono pracę serwera.");
            //przewijanie na sam dół
            komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
            labelStan.Text = "Zakończono pracę serwera. ";            
            wysylana = null;
            WysylanieWorker.RunWorkerAsync();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            sendButton.Enabled = false;
            serwer.Stop();
            klient.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (sendTextBox.Text != " ")
            {
                wysylana = sendTextBox.Text;
                WysylanieWorker.RunWorkerAsync();
            }
            sendTextBox.Text = " ";
        }
        //wysylanieworker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (klient.Connected)
            {
                streamwriter.WriteLine(wysylana);
                this.komunikatyListBox.Invoke(new MethodInvoker(delegate ()
                {
                    if(wysylana!=null) komunikatyListBox.Items.Add("Ja: " + wysylana + "\n");
                    //przewijanie na sam dół
                    komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                }));
            }
            else
            {
                MessageBox.Show("Wysyłanie nie powiodło się");
            }
            WysylanieWorker.CancelAsync();
        }

        private void OdbieranieWorker_DoWork(object sender, DoWorkEventArgs e)
        {          
            while (klient.Connected && connecterr!=2)
            {

                try
                {
                    odebrana = streamreader.ReadLine();
                    this.komunikatyListBox.Invoke(new MethodInvoker(delegate ()
                    {
                        komunikatyListBox.Items.Add(adresIP+": " + odebrana + "\n");
                        //przewijanie na sam dół
                        komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                    }));
                    odebrana = " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Połączenie z klientem zostało przerwane!");
                    this.komunikatyListBox.Invoke(new MethodInvoker(delegate ()
                    {
                    komunikatyListBox.Items.Add("Połączenie z klientem zostało przerwane!");
                    komunikatyListBox.Items.Add("Uruchom ponownie serwer.");
                        //przewijanie na sam dół
                        komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                        labelStan.Text = "Połączenie zostało przerwane!";
                    }));
                   
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            komunikatyListBox.Items.Clear();
        }

        private void emojiButton1_Click(object sender, EventArgs e)
        {
            sendTextBox.AppendText("😀");
        }

        private void emojiButton2_Click(object sender, EventArgs e)
        {
            sendTextBox.AppendText("😂");
        }

        private void emojiButton3_Click(object sender, EventArgs e)
        {
            sendTextBox.AppendText("😍");
        }

        private void emojiButton4_Click(object sender, EventArgs e)
        {
            sendTextBox.AppendText("😭");
        }

        private void emojiButton5_Click(object sender, EventArgs e)
        {
            sendTextBox.AppendText("😎");
        }

        private void emojiButton6_Click(object sender, EventArgs e)
        {
            sendTextBox.AppendText("😱");
        }
    }
}
