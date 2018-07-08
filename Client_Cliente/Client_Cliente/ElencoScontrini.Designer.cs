namespace Client_Cliente
{
    partial class ElencoScontrini
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Client_Cliente.Properties.Resources.error__1_;
            this.closeButton.Location = new System.Drawing.Point(506, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 33);
            this.closeButton.TabIndex = 7;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // elencoScontriniButton
            // 
            this.elencoScontriniButton.Enabled = false;
            this.elencoScontriniButton.Location = new System.Drawing.Point(270, 8);
            this.elencoScontriniButton.Name = "elencoScontriniButton";
            this.elencoScontriniButton.Size = new System.Drawing.Size(219, 31);
            this.elencoScontriniButton.TabIndex = 6;
            this.elencoScontriniButton.Text = "Elenco Scontrini";
            this.elencoScontriniButton.UseVisualStyleBackColor = true;
            // 
            // ottieniPremioButton
            // 
            this.ottieniPremioButton.Location = new System.Drawing.Point(18, 8);
            this.ottieniPremioButton.Name = "ottieniPremioButton";
            this.ottieniPremioButton.Size = new System.Drawing.Size(246, 31);
            this.ottieniPremioButton.TabIndex = 5;
            this.ottieniPremioButton.Text = "Ottieni Premio";
            this.ottieniPremioButton.UseVisualStyleBackColor = true;
            this.ottieniPremioButton.Click += new System.EventHandler(this.ottieniPremioButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 191);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // ElencoScontrini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 275);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.elencoScontriniButton);
            this.Controls.Add(this.ottieniPremioButton);
            this.Name = "ElencoScontrini";
            this.Text = "ElencoScontrini";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button elencoScontriniButton;
        private System.Windows.Forms.Button ottieniPremioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}