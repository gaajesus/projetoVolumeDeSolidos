namespace Calculadora_Volume_de_solidos
{
    partial class Esfera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Esfera));
            this.picEsfera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEsfera)).BeginInit();
            this.SuspendLayout();
            // 
            // picEsfera
            // 
            this.picEsfera.BackColor = System.Drawing.Color.Transparent;
            this.picEsfera.Image = ((System.Drawing.Image)(resources.GetObject("picEsfera.Image")));
            this.picEsfera.Location = new System.Drawing.Point(353, 181);
            this.picEsfera.Name = "picEsfera";
            this.picEsfera.Size = new System.Drawing.Size(94, 88);
            this.picEsfera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEsfera.TabIndex = 3;
            this.picEsfera.TabStop = false;
            // 
            // Esfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picEsfera);
            this.Name = "Esfera";
            this.Text = "Esfera";
            ((System.ComponentModel.ISupportInitialize)(this.picEsfera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picEsfera;
    }
}