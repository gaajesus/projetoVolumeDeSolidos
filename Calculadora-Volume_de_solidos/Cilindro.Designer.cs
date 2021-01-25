namespace Calculadora_Volume_de_solidos
{
    partial class Cilindro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cilindro));
            this.picCilindro = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCilindro)).BeginInit();
            this.SuspendLayout();
            // 
            // picCilindro
            // 
            this.picCilindro.BackColor = System.Drawing.Color.Transparent;
            this.picCilindro.Image = ((System.Drawing.Image)(resources.GetObject("picCilindro.Image")));
            this.picCilindro.Location = new System.Drawing.Point(353, 181);
            this.picCilindro.Name = "picCilindro";
            this.picCilindro.Size = new System.Drawing.Size(94, 88);
            this.picCilindro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCilindro.TabIndex = 1;
            this.picCilindro.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(549, 107);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Cilindro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.picCilindro);
            this.Name = "Cilindro";
            this.Text = "Cilindro";
            ((System.ComponentModel.ISupportInitialize)(this.picCilindro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCilindro;
        private System.Windows.Forms.Button btnVoltar;
    }
}