namespace CzatKlient
{
    partial class Klient
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.komunikatyListBox = new System.Windows.Forms.ListBox();
            this.portUpDown = new System.Windows.Forms.NumericUpDown();
            this.adresBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.WysylanieWorker = new System.ComponentModel.BackgroundWorker();
            this.OdbieranieWorker = new System.ComponentModel.BackgroundWorker();
            this.clearButton = new System.Windows.Forms.Button();
            this.emojiButton1 = new System.Windows.Forms.Button();
            this.emojiButton2 = new System.Windows.Forms.Button();
            this.emojiButton3 = new System.Windows.Forms.Button();
            this.emojiButton4 = new System.Windows.Forms.Button();
            this.emojiButton5 = new System.Windows.Forms.Button();
            this.emojiButton6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // komunikatyListBox
            // 
            this.komunikatyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikatyListBox.FormattingEnabled = true;
            this.komunikatyListBox.ItemHeight = 20;
            this.komunikatyListBox.Location = new System.Drawing.Point(12, 57);
            this.komunikatyListBox.Name = "komunikatyListBox";
            this.komunikatyListBox.Size = new System.Drawing.Size(386, 124);
            this.komunikatyListBox.TabIndex = 14;
            // 
            // portUpDown
            // 
            this.portUpDown.Location = new System.Drawing.Point(251, 19);
            this.portUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portUpDown.Name = "portUpDown";
            this.portUpDown.Size = new System.Drawing.Size(63, 20);
            this.portUpDown.TabIndex = 13;
            this.portUpDown.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // adresBox
            // 
            this.adresBox.Location = new System.Drawing.Point(55, 19);
            this.adresBox.Name = "adresBox";
            this.adresBox.Size = new System.Drawing.Size(155, 20);
            this.adresBox.TabIndex = 12;
            this.adresBox.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adres:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(326, 16);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(12, 258);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(302, 20);
            this.sendTextBox.TabIndex = 15;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(326, 255);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 16;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // WysylanieWorker
            // 
            this.WysylanieWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // OdbieranieWorker
            // 
            this.OdbieranieWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OdbieranieWorker_DoWork);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 206);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Wyczyść czat";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // emojiButton1
            // 
            this.emojiButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiButton1.Location = new System.Drawing.Point(137, 200);
            this.emojiButton1.Name = "emojiButton1";
            this.emojiButton1.Size = new System.Drawing.Size(39, 30);
            this.emojiButton1.TabIndex = 22;
            this.emojiButton1.Text = "😀";
            this.emojiButton1.UseVisualStyleBackColor = true;
            this.emojiButton1.Click += new System.EventHandler(this.emojiButton_Click);
            // 
            // emojiButton2
            // 
            this.emojiButton2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiButton2.Location = new System.Drawing.Point(182, 200);
            this.emojiButton2.Name = "emojiButton2";
            this.emojiButton2.Size = new System.Drawing.Size(39, 30);
            this.emojiButton2.TabIndex = 23;
            this.emojiButton2.Text = "😂";
            this.emojiButton2.UseVisualStyleBackColor = true;
            this.emojiButton2.Click += new System.EventHandler(this.emojiButton2_Click);
            // 
            // emojiButton3
            // 
            this.emojiButton3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiButton3.Location = new System.Drawing.Point(227, 200);
            this.emojiButton3.Name = "emojiButton3";
            this.emojiButton3.Size = new System.Drawing.Size(39, 30);
            this.emojiButton3.TabIndex = 24;
            this.emojiButton3.Text = "😍";
            this.emojiButton3.UseVisualStyleBackColor = true;
            this.emojiButton3.Click += new System.EventHandler(this.emojiButton3_Click);
            // 
            // emojiButton4
            // 
            this.emojiButton4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiButton4.Location = new System.Drawing.Point(272, 200);
            this.emojiButton4.Name = "emojiButton4";
            this.emojiButton4.Size = new System.Drawing.Size(39, 30);
            this.emojiButton4.TabIndex = 25;
            this.emojiButton4.Text = "😭";
            this.emojiButton4.UseVisualStyleBackColor = true;
            this.emojiButton4.Click += new System.EventHandler(this.emojiButton4_Click);
            // 
            // emojiButton5
            // 
            this.emojiButton5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiButton5.Location = new System.Drawing.Point(317, 200);
            this.emojiButton5.Name = "emojiButton5";
            this.emojiButton5.Size = new System.Drawing.Size(39, 30);
            this.emojiButton5.TabIndex = 26;
            this.emojiButton5.Text = "😎";
            this.emojiButton5.UseVisualStyleBackColor = true;
            this.emojiButton5.Click += new System.EventHandler(this.emojiButton5_Click);
            // 
            // emojiButton6
            // 
            this.emojiButton6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiButton6.Location = new System.Drawing.Point(362, 200);
            this.emojiButton6.Name = "emojiButton6";
            this.emojiButton6.Size = new System.Drawing.Size(39, 30);
            this.emojiButton6.TabIndex = 27;
            this.emojiButton6.Text = "😱";
            this.emojiButton6.UseVisualStyleBackColor = true;
            this.emojiButton6.Click += new System.EventHandler(this.emojiButton6_Click);
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 301);
            this.Controls.Add(this.emojiButton6);
            this.Controls.Add(this.emojiButton5);
            this.Controls.Add(this.emojiButton4);
            this.Controls.Add(this.emojiButton3);
            this.Controls.Add(this.emojiButton2);
            this.Controls.Add(this.emojiButton1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.komunikatyListBox);
            this.Controls.Add(this.portUpDown);
            this.Controls.Add(this.adresBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Name = "Klient";
            this.Text = "Klient";
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox komunikatyListBox;
        private System.Windows.Forms.NumericUpDown portUpDown;
        private System.Windows.Forms.TextBox adresBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.ComponentModel.BackgroundWorker WysylanieWorker;
        private System.ComponentModel.BackgroundWorker OdbieranieWorker;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button emojiButton1;
        private System.Windows.Forms.Button emojiButton2;
        private System.Windows.Forms.Button emojiButton3;
        private System.Windows.Forms.Button emojiButton4;
        private System.Windows.Forms.Button emojiButton5;
        private System.Windows.Forms.Button emojiButton6;
    }
}

