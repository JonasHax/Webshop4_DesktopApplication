namespace DesktopApplication.Presentation {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btnOrderGUI = new System.Windows.Forms.Button();
            this.btnProductGUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(309, 35);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(59, 13);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Webshop4";
            // 
            // btnOrderGUI
            // 
            this.btnOrderGUI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOrderGUI.Location = new System.Drawing.Point(385, 100);
            this.btnOrderGUI.Name = "btnOrderGUI";
            this.btnOrderGUI.Size = new System.Drawing.Size(268, 114);
            this.btnOrderGUI.TabIndex = 4;
            this.btnOrderGUI.Text = "Ordremenu";
            this.btnOrderGUI.UseVisualStyleBackColor = false;
            this.btnOrderGUI.Click += new System.EventHandler(this.btnOrderGUI_Click);
            // 
            // btnProductGUI
            // 
            this.btnProductGUI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProductGUI.Location = new System.Drawing.Point(36, 100);
            this.btnProductGUI.Name = "btnProductGUI";
            this.btnProductGUI.Size = new System.Drawing.Size(273, 114);
            this.btnProductGUI.TabIndex = 3;
            this.btnProductGUI.Text = "Produktmenu";
            this.btnProductGUI.UseVisualStyleBackColor = false;
            this.btnProductGUI.Click += new System.EventHandler(this.btnProductGUI_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 296);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnOrderGUI);
            this.Controls.Add(this.btnProductGUI);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnOrderGUI;
        private System.Windows.Forms.Button btnProductGUI;
    }
}