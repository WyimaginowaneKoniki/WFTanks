namespace WFTanks
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AllieTanksDesign = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllieTanksDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // AllieTanksDesign
            // 
            this.AllieTanksDesign.BackColor = System.Drawing.Color.Transparent;
            this.AllieTanksDesign.Image = ((System.Drawing.Image)(resources.GetObject("AllieTanksDesign.Image")));
            this.AllieTanksDesign.Location = new System.Drawing.Point(173, 114);
            this.AllieTanksDesign.Name = "AllieTanksDesign";
            this.AllieTanksDesign.Size = new System.Drawing.Size(30, 30);
            this.AllieTanksDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AllieTanksDesign.TabIndex = 0;
            this.AllieTanksDesign.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AllieTanksDesign);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);        
            ((System.ComponentModel.ISupportInitialize)(AllieTanksDesign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AllieTanksDesign;
    }
}

