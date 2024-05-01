namespace pryEtapa3Ambordt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAuto = new Button();
            btnBarco = new Button();
            btnAvion = new Button();
            pctImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctImagen).BeginInit();
            SuspendLayout();
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(12, 230);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(75, 23);
            btnAuto.TabIndex = 0;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(328, 230);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(75, 23);
            btnBarco.TabIndex = 1;
            btnBarco.Text = "Barco";
            btnBarco.UseVisualStyleBackColor = true;
            btnBarco.Click += btnBarco_Click;
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(164, 230);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(75, 23);
            btnAvion.TabIndex = 2;
            btnAvion.Text = "Avion";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // pctImagen
            // 
            pctImagen.Location = new Point(12, 12);
            pctImagen.Name = "pctImagen";
            pctImagen.Size = new Size(391, 194);
            pctImagen.SizeMode = PictureBoxSizeMode.AutoSize;
            pctImagen.TabIndex = 3;
            pctImagen.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 287);
            Controls.Add(pctImagen);
            Controls.Add(btnAvion);
            Controls.Add(btnBarco);
            Controls.Add(btnAuto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAuto;
        private Button btnBarco;
        private Button btnAvion;
        private PictureBox pctImagen;
    }
}
