namespace Calculadora_Volume_de_solidos
{
    partial class Prisma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prisma));
            this.picPrisma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPrisma)).BeginInit();
            this.SuspendLayout();
            // 
            // picPrisma
            // 
            this.picPrisma.BackColor = System.Drawing.Color.Transparent;
            this.picPrisma.Image = ((System.Drawing.Image)(resources.GetObject("picPrisma.Image")));
            this.picPrisma.Location = new System.Drawing.Point(353, 181);
            this.picPrisma.Name = "picPrisma";
            this.picPrisma.Size = new System.Drawing.Size(94, 88);
            this.picPrisma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrisma.TabIndex = 5;
            this.picPrisma.TabStop = false;
            // 
            // Prisma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPrisma);
            this.Name = "Prisma";
            this.Text = "Prisma";
            ((System.ComponentModel.ISupportInitialize)(this.picPrisma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPrisma;
    }
}