using System.Drawing.Imaging;
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
            Bitmap imageOriginal = new Bitmap(image);

            Bitmap imageDest = new Bitmap(imageOriginal.Width, imageOriginal.Height);

            Bitmap imageDest2 = new Bitmap(imageOriginal.Width, imageOriginal.Height);

            Filtros filtros = new Filtros();

            filtros.ConverterParaPretoBranco(imageOriginal, imageDest, 221);

            ZhangSuen zhangSuen = new ZhangSuen();

            zhangSuen.AfinarImagem(imageDest, imageDest2);

            PictureBox2.Image = imageDest;

            imageDest.Save("C:\\Users\\Pedro Filitto\\Desktop\\6 Termo\\TOPICOS1\\Trabalho1Bim\\resultados\\ImagemZhangSuen.png", ImageFormat.Png);
        }

        private void ExtracaoContornos(object sender, EventArgs e)
        {
            Bitmap imageOriginal = new Bitmap(this.image);

            Bitmap imageDest = new Bitmap(imageOriginal.Width, imageOriginal.Height);

            Bitmap imageDest2 = new Bitmap(imageOriginal.Width, imageOriginal.Height);

            using (Graphics g = Graphics.FromImage(imageDest2))
            {
                g.Clear(Color.White);
            }

            Contornos contornos = new Contornos();
            Filtros filtros = new Filtros();

            filtros.ConverterParaPretoBranco(imageOriginal, imageDest, 221);

            contornos.ExtracaoContornos(imageDest, imageDest2);

            PictureBox2.Image = imageDest;

            imageDest2.Save("C:\\Users\\Pedro Filitto\\Desktop\\6 Termo\\TOPICOS1\\Trabalho1Bim\\resultados\\ImagemContornos.png", ImageFormat.Png);

            imageDest.Save("C:\\Users\\Pedro Filitto\\Desktop\\6 Termo\\TOPICOS1\\Trabalho1Bim\\resultados\\RetanguloMinimo.png", ImageFormat.Png);
        }

    }
}
