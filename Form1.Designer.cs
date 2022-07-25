namespace CraftDemonstration
{
    partial class DesktopApplication
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imagePanelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchLabel.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(370, 54);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(90, 25);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search Image";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchTextbox.Location = new System.Drawing.Point(466, 59);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(400, 20);
            this.SearchTextbox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(615, 98);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1142, 638);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // imagePanelLabel
            // 
            this.imagePanelLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imagePanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePanelLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.imagePanelLabel.Location = new System.Drawing.Point(543, 139);
            this.imagePanelLabel.Name = "imagePanelLabel";
            this.imagePanelLabel.Size = new System.Drawing.Size(216, 37);
            this.imagePanelLabel.TabIndex = 5;
            this.imagePanelLabel.Text = "Image Panel";
            this.imagePanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imagePanelLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 101);
            this.label1.TabIndex = 6;
            this.label1.Text = "INTUIT LENS";
            // 
            // DesktopApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePanelLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.searchLabel);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "DesktopApplication";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label imagePanelLabel;
        private System.Windows.Forms.Label label1;
    }
}

