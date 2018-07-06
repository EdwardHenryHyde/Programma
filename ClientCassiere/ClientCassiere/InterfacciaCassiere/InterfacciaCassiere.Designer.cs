namespace ClientCassiere
{
    partial class InterfacciaCassiere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cartaSi = new System.Windows.Forms.RadioButton();
            this.cartaNo = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cartaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.aggiungiProdotto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totaleLabel = new System.Windows.Forms.Label();
            this.fineButton = new System.Windows.Forms.Button();
            this.annullaButton = new System.Windows.Forms.Button();
            this.scontrinoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::ClientCassiere.Properties.Resources.error__1_;
            this.close.Location = new System.Drawing.Point(279, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(48, 44);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carta";
            // 
            // cartaSi
            // 
            this.cartaSi.AutoSize = true;
            this.cartaSi.Location = new System.Drawing.Point(108, 45);
            this.cartaSi.Name = "cartaSi";
            this.cartaSi.Size = new System.Drawing.Size(34, 17);
            this.cartaSi.TabIndex = 2;
            this.cartaSi.TabStop = true;
            this.cartaSi.Text = "Si";
            this.cartaSi.UseVisualStyleBackColor = true;
            this.cartaSi.CheckedChanged += new System.EventHandler(this.cartaSi_CheckedChanged);
            // 
            // cartaNo
            // 
            this.cartaNo.AutoSize = true;
            this.cartaNo.Location = new System.Drawing.Point(216, 45);
            this.cartaNo.Name = "cartaNo";
            this.cartaNo.Size = new System.Drawing.Size(39, 17);
            this.cartaNo.TabIndex = 3;
            this.cartaNo.TabStop = true;
            this.cartaNo.Text = "No";
            this.cartaNo.UseVisualStyleBackColor = true;
            this.cartaNo.CheckedChanged += new System.EventHandler(this.cartaNo_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 80);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 4;
            // 
            // cartaButton
            // 
            this.cartaButton.Enabled = false;
            this.cartaButton.Location = new System.Drawing.Point(279, 76);
            this.cartaButton.Name = "cartaButton";
            this.cartaButton.Size = new System.Drawing.Size(37, 23);
            this.cartaButton.TabIndex = 5;
            this.cartaButton.Text = "ok";
            this.cartaButton.UseVisualStyleBackColor = true;
            this.cartaButton.Click += new System.EventHandler(this.cartaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(106, 120);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 7;
            // 
            // aggiungiProdotto
            // 
            this.aggiungiProdotto.Location = new System.Drawing.Point(259, 169);
            this.aggiungiProdotto.Name = "aggiungiProdotto";
            this.aggiungiProdotto.Size = new System.Drawing.Size(68, 153);
            this.aggiungiProdotto.TabIndex = 8;
            this.aggiungiProdotto.Text = "Aggiungi";
            this.aggiungiProdotto.UseVisualStyleBackColor = true;
            this.aggiungiProdotto.Click += new System.EventHandler(this.aggiungiProdotto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Totale";
            // 
            // totaleLabel
            // 
            this.totaleLabel.AutoSize = true;
            this.totaleLabel.Location = new System.Drawing.Point(107, 343);
            this.totaleLabel.Name = "totaleLabel";
            this.totaleLabel.Size = new System.Drawing.Size(0, 13);
            this.totaleLabel.TabIndex = 10;
            // 
            // fineButton
            // 
            this.fineButton.BackColor = System.Drawing.Color.Lime;
            this.fineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineButton.Location = new System.Drawing.Point(42, 393);
            this.fineButton.Name = "fineButton";
            this.fineButton.Size = new System.Drawing.Size(75, 51);
            this.fineButton.TabIndex = 11;
            this.fineButton.Text = "Fine";
            this.fineButton.UseVisualStyleBackColor = false;
            this.fineButton.Click += new System.EventHandler(this.fineButton_Click);
            // 
            // annullaButton
            // 
            this.annullaButton.BackColor = System.Drawing.Color.Red;
            this.annullaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.annullaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annullaButton.Location = new System.Drawing.Point(216, 393);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(75, 51);
            this.annullaButton.TabIndex = 12;
            this.annullaButton.Text = "Annulla";
            this.annullaButton.UseVisualStyleBackColor = false;
            this.annullaButton.Click += new System.EventHandler(this.annullaButton_Click);
            // 
            // scontrinoPanel
            // 
            this.scontrinoPanel.AutoScroll = true;
            this.scontrinoPanel.ColumnCount = 3;
            this.scontrinoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.scontrinoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.scontrinoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.scontrinoPanel.Location = new System.Drawing.Point(16, 169);
            this.scontrinoPanel.Name = "scontrinoPanel";
            this.scontrinoPanel.RowCount = 1;
            this.scontrinoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scontrinoPanel.Size = new System.Drawing.Size(225, 153);
            this.scontrinoPanel.TabIndex = 13;
            // 
            // InterfacciaCassiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 493);
            this.ControlBox = false;
            this.Controls.Add(this.scontrinoPanel);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.fineButton);
            this.Controls.Add(this.totaleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aggiungiProdotto);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cartaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cartaNo);
            this.Controls.Add(this.cartaSi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Name = "InterfacciaCassiere";
            this.Text = "InterfacciaCassiere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cartaSi;
        private System.Windows.Forms.RadioButton cartaNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cartaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button aggiungiProdotto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totaleLabel;
        private System.Windows.Forms.Button fineButton;
        private System.Windows.Forms.Button annullaButton;
        private System.Windows.Forms.TableLayoutPanel scontrinoPanel;
    }
}