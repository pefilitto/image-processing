using System.Windows.Forms;

namespace Trabalho1Bim
{
    public partial class FormPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirImagem(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png;*.webp)|*.jpg;*.gif;*.bmp;*.png;*.webp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                PictureBox1.Image = image;
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void AfinarImagem(object sender, EventArgs e)
        {

        }

        private void ExtracaoContornos(object sender, EventArgs e)
        {

        }

        private void RetanguloMinimo(object sender, EventArgs e)
        {

        }
    }
}
