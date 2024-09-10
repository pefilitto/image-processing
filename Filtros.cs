using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1Bim
{
    internal class Filtros
    {
        public Filtros() { }
        public void ConverterParaPretoBranco(Bitmap imageOriginal, Bitmap imageDest, int limiar)
        {
            for (int x = 0; x < imageOriginal.Width; x++)
            {
                for (int y = 0; y < imageOriginal.Height; y++)
                {
                    Color pixel = imageOriginal.GetPixel(x, y);

                    int brilho = (pixel.R + pixel.G + pixel.B) / 3;

                    if (brilho < limiar)
                    {
                        imageDest.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        imageDest.SetPixel(x, y, Color.White);
                    }
                }
            }
        }
    }
}
