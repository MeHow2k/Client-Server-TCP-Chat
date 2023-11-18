using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;


namespace CzatKlient
{
    public partial class Klient : Form  
    {
        private TcpClient klient;
        public StreamReader streamreader;
        public StreamWriter streamwriter;
        private string host;
        public string odebrana;
        public string wysylana;
        private int connecterr;
        public Klient()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            host = adresBox.Text;
            int port = System.Convert.ToInt16(portUpDown.Value);
            try
            {
                connecterr= 0;
                klient = new TcpClient(host, port);
               
            }
            catch (Exception ex)
            {
                komunikatyListBox.Items.Add("Błąd: Nie udało się nawiązać połączenia z serwerem!");
                //przewijanie na sam dół
                komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                MessageBox.Show("Nie udało się nawiązać połączenia z serwerem!", "Błąd");
                connecterr= 1;
            }
            if (klient!=null && klient.Connected && connecterr!=1) {
                komunikatyListBox.Items.Add("Nawiązano połączenie z: " + host + " na porcie: " + port);
                //przewijanie na sam dół
                komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                streamreader = new StreamReader(klient.GetStream());
                streamwriter = new StreamWriter(klient.GetStream());
                streamwriter.AutoFlush = true;
                WysylanieWorker.WorkerSupportsCancellation = true;
                OdbieranieWorker.WorkerSupportsCancellation = true;
                OdbieranieWorker.RunWorkerAsync();
                connectButton.Enabled= false;
                sendButton.Enabled = true;
            }

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
                    komunikatyListBox.Items.Add("Ja: " + wysylana + "\n");
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
                    if (odebrana == null) {                        
                        connecterr = 2;                       
                    }
                    this.komunikatyListBox.Invoke(new MethodInvoker(delegate ()
                    {
                        if (connecterr == 2) {
                            komunikatyListBox.Items.Add("Połączenie zostało przerwane!\n");                        
                            connectButton.Enabled = true;
                            sendButton.Enabled = false;
                        }
                        else komunikatyListBox.Items.Add(host+": " + odebrana + "\n");
                        //przewijanie na sam dół
                        komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                    }));
                    odebrana = " ";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Połączenie z serwerem zostało przerwane!");
                    this.komunikatyListBox.Invoke(new MethodInvoker(delegate ()
                    {
                        komunikatyListBox.Items.Add("Połączenie z serwerem zostało przerwane!\n");
                        //przewijanie na sam dół
                        komunikatyListBox.TopIndex = komunikatyListBox.Items.Count - 1;
                        connectButton.Enabled = true;
                        sendButton.Enabled = false;
                    }));
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            komunikatyListBox.Items.Clear();
        }

        private void emojiButton_Click(object sender, EventArgs e)
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
