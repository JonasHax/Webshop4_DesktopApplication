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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Rockwell", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(223, 22);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(238, 49);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Webshop4";
            // 
            // btnOrderGUI
            // 
            this.btnOrderGUI.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderGUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderGUI.Location = new System.Drawing.Point(322, 30);
            this.btnOrderGUI.Name = "btnOrderGUI";
            this.btnOrderGUI.Size = new System.Drawing.Size(273, 107);
            this.btnOrderGUI.TabIndex = 4;
            this.btnOrderGUI.Text = "Ordremenu";
            this.btnOrderGUI.UseVisualStyleBackColor = false;
            this.btnOrderGUI.Click += new System.EventHandler(this.btnOrderGUI_Click);
            // 
            // btnProductGUI
            // 
            this.btnProductGUI.BackColor = System.Drawing.Color.Transparent;
            this.btnProductGUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductGUI.Location = new System.Drawing.Point(27, 30);
            this.btnProductGUI.Name = "btnProductGUI";
            this.btnProductGUI.Size = new System.Drawing.Size(262, 107);
            this.btnProductGUI.TabIndex = 3;
            this.btnProductGUI.Text = "Produktmenu";
            this.btnProductGUI.UseVisualStyleBackColor = false;
            this.btnProductGUI.Click += new System.EventHandler(this.btnProductGUI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductGUI);
            this.groupBox1.Controls.Add(this.btnOrderGUI);
            this.groupBox1.Location = new System.Drawing.Point(27, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(703, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnOrderGUI;
        private System.Windows.Forms.Button btnProductGUI;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}