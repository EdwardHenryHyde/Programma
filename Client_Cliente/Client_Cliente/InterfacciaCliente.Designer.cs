namespace Client_Cliente
{
    partial class InterfacciaCliente
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
            this.ottieniPremioButton = new System.Windows.Forms.Button();
            this.elencoScontriniButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ottieniPremioButton
            // 
            this.ottieniPremioButton.Location = new System.Drawing.Point(22, 12);
            this.ottieniPremioButton.Name = "ottieniPremioButton";
            this.ottieniPremioButton.Size = new System.Drawing.Size(246, 31);
            this.ottieniPremioButton.TabIndex = 0;
            this.ottieniPremioButton.Text = "Ottieni Premio";
            this.ottieniPremioButton.UseVisualStyleBackColor = true;
            this.ottieniPremioButton.Click += new System.EventHandler(this.ottieniPremioButton_Click);
            // 
            // elencoScontriniButton
            // 
            this.elencoScontriniButton.Location = new System.Drawing.Point(290, 12);
            this.elencoScontriniButton.Name = "elencoScontriniButton";
            this.elencoScontriniButton.Size = new System.Drawing.Size(219, 31);
            this.elencoScontriniButton.TabIndex = 1;
            this.elencoScontriniButton.Text = "Elenco Scontrini";
            this.elencoScontriniButton.UseVisualStyleBackColor = true;
            this.elencoScontriniButton.Click += new System.EventHandler(this.elencoScontriniButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Client_Cliente.Properties.Resources.error__1_;
            this.closeButton.Location = new System.Drawing.Point(526, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 33);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // InterfacciaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 283);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.elencoScontriniButton);
            this.Controls.Add(this.ottieniPremioButton);
            this.Name = "InterfacciaCliente";
            this.Text = "InterfacciaCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ottieniPremioButton;
        private System.Windows.Forms.Button elencoScontriniButton;
        private System.Windows.Forms.Button closeButton;
    }
}