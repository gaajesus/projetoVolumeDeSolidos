namespace Calculadora_Volume_de_solidos
{
    partial class Cone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cone));
            this.picCone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCone)).BeginInit();
            this.SuspendLayout();
            // 
            // picCone
            // 
            this.picCone.BackColor = System.Drawing.Color.Transparent;
            this.picCone.Image = ((System.Drawing.Image)(resources.GetObject("picCone.Image")));
            this.picCone.Location = new System.Drawing.Point(353, 181);
            this.picCone.Name = "picCone";
            this.picCone.Size = new System.Drawing.Size(94, 88);
            this.picCone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCone.TabIndex = 4;
            this.picCone.TabStop = false;
            // 
            // Cone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCone);
            this.Name = "Cone";
            this.Text = "Cone";
            ((System.ComponentModel.ISupportInitialize)(this.picCone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCone;
    }
}