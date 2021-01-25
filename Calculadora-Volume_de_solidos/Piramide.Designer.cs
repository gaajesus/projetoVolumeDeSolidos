namespace Calculadora_Volume_de_solidos
{
    partial class Piramide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Piramide));
            this.picPiramide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPiramide)).BeginInit();
            this.SuspendLayout();
            // 
            // picPiramide
            // 
            this.picPiramide.BackColor = System.Drawing.Color.Transparent;
            this.picPiramide.Image = ((System.Drawing.Image)(resources.GetObject("picPiramide.Image")));
            this.picPiramide.Location = new System.Drawing.Point(353, 181);
            this.picPiramide.Name = "picPiramide";
            this.picPiramide.Size = new System.Drawing.Size(94, 88);
            this.picPiramide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPiramide.TabIndex = 6;
            this.picPiramide.TabStop = false;
            // 
            // Piramide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPiramide);
            this.Name = "Piramide";
            this.Text = "Piramide";
            ((System.ComponentModel.ISupportInitialize)(this.picPiramide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPiramide;
    }
}