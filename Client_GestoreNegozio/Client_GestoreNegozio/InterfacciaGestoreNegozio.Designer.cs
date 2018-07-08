namespace Client_GestoreNegozio
{
    partial class InterfacciaGestoreNegozio
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
            this.closeButton = new System.Windows.Forms.Button();
            this.elencoScontriniButton = new System.Windows.Forms.Button();
            this.ottieniPremioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Client_GestoreNegozio.Properties.Resources.error__1_;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(503, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 33);
            this.closeButton.TabIndex = 10;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // elencoScontriniButton
            // 
            this.elencoScontriniButton.Location = new System.Drawing.Point(267, 13);
            this.elencoScontriniButton.Name = "elencoScontriniButton";
            this.elencoScontriniButton.Size = new System.Drawing.Size(219, 31);
            this.elencoScontriniButton.TabIndex = 9;
            this.elencoScontriniButton.Text = "Per data";
            this.elencoScontriniButton.UseVisualStyleBackColor = true;
            this.elencoScontriniButton.Click += new System.EventHandler(this.elencoScontriniButton_Click);
            // 
            // ottieniPremioButton
            // 
            this.ottieniPremioButton.Location = new System.Drawing.Point(15, 13);
            this.ottieniPremioButton.Name = "ottieniPremioButton";
            this.ottieniPremioButton.Size = new System.Drawing.Size(246, 31);
            this.ottieniPremioButton.TabIndex = 8;
            this.ottieniPremioButton.Text = "Report Mensile";
            this.ottieniPremioButton.UseVisualStyleBackColor = true;
            this.ottieniPremioButton.Click += new System.EventHandler(this.ottieniPremioButton_Click);
            // 
            // InterfacciaGestoreNegozio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 300);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.elencoScontriniButton);
            this.Controls.Add(this.ottieniPremioButton);
            this.Name = "InterfacciaGestoreNegozio";
            this.Text = "InterfacciaGestoreNegozio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button elencoScontriniButton;
        private System.Windows.Forms.Button ottieniPremioButton;
    }
}