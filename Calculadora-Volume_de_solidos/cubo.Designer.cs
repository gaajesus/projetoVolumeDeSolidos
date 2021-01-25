namespace Calculadora_Volume_de_solidos
{
    partial class cubo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cubo));
            this.picCubo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCubo)).BeginInit();
            this.SuspendLayout();
            // 
            // picCubo
            // 
            this.picCubo.BackColor = System.Drawing.Color.Transparent;
            this.picCubo.Image = ((System.Drawing.Image)(resources.GetObject("picCubo.Image")));
            this.picCubo.Location = new System.Drawing.Point(353, 181);
            this.picCubo.Name = "picCubo";
            this.picCubo.Size = new System.Drawing.Size(94, 88);
            this.picCubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCubo.TabIndex = 2;
            this.picCubo.TabStop = false;
            // 
            // cubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCubo);
            this.Name = "cubo";
            this.Text = "cubo";
            ((System.ComponentModel.ISupportInitialize)(this.picCubo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCubo;
    }
}