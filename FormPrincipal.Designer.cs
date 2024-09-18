namespace Trabalho1Bim
{
    partial class FormPrincipal
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

        private void InitializeComponent()
        {
            PictureBox1 = new PictureBox();
            PictureBox2 = new PictureBox();
            button1 = new Button();
            openFileDialog = new OpenFileDialog();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = SystemColors.ControlLightLight;
            PictureBox1.Location = new Point(12, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(836, 450);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = SystemColors.ControlLightLight;
            PictureBox2.Location = new Point(854, 12);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(932, 450);
            PictureBox2.TabIndex = 1;
            PictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(11, 479);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 2;
            button1.Text = "Abrir Imagem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AbrirImagem;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // button2
            // 
            button2.Location = new Point(124, 479);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 3;
            button2.Text = "Afinar Imagem";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AfinarImagem;
            // 
            // button3
            // 
            button3.Location = new Point(237, 479);
            button3.Name = "button3";
            button3.Size = new Size(296, 23);
            button3.TabIndex = 4;
            button3.Text = "Extração de Contornos e Retangulo Minimo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ExtracaoContornos;
            // 
            // FormPrincipal
            // 
            ClientSize = new Size(1798, 795);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            Name = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ResumeLayout(false);
        }

        private PictureBox PictureBox1;
        private PictureBox PictureBox2;
        private Button button1;
        private OpenFileDialog openFileDialog;
        private Button button2;
        private Button button3;
    }
}
