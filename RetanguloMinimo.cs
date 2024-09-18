using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1Bim
{
    internal class RetanguloMinimo
    {
        public Utils utils = new Utils();
        public RetanguloMinimo() { }

        public void DesenharRetanguloMinimo(Bitmap imageDest, int xMenor, int yMenor, int xMaior, int yMaior)
        {
            for (int x = xMenor; x <= xMaior; x++)
            {
                imageDest.SetPixel(x, yMenor, Color.Green);
                imageDest.SetPixel(x, yMaior, Color.Green);
            }

            for (int y = yMenor; y <= yMaior; y++)
            {
                imageDest.SetPixel(xMenor, y, Color.Green);
                imageDest.SetPixel(xMaior, y, Color.Green);
            }
        }

        public void AtualizarRetanguloMinimo(int x, int y, ref int xMenor, ref int yMenor, ref int xMaior, ref int yMaior)
        {
            if (x < xMenor)
                xMenor = x;
            if (y < yMenor)
                yMenor = y;
            if (x > xMaior)
                xMaior = x;
            if (y > yMaior)
                yMaior = y;
        }
    }
}
