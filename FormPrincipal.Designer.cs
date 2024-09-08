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
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = SystemColors.ControlLightLight;
            PictureBox1.Location = new Point(12, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(600, 450);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = SystemColors.ControlLightLight;
            PictureBox2.Location = new Point(700, 12);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(600, 450);
            PictureBox2.TabIndex = 1;
            PictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 468);
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
            button2.Location = new Point(125, 468);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 3;
            button2.Text = "Afinar Imagem";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AfinarImagem;
            // 
            // button3
            // 
            button3.Location = new Point(238, 468);
            button3.Name = "button3";
            button3.Size = new Size(161, 23);
            button3.TabIndex = 4;
            button3.Text = "Extração de Contornos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ExtracaoContornos;
            // 
            // button4
            // 
            button4.Location = new Point(405, 468);
            button4.Name = "button4";
            button4.Size = new Size(137, 23);
            button4.TabIndex = 5;
            button4.Text = "Retangulo Mínimo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += RetanguloMinimo;
            // 
            // FormPrincipal
            // 
            ClientSize = new Size(1312, 830);
            Controls.Add(button4);
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
        private Button button4;
    }
}
