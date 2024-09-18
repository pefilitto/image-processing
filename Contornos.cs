using System;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace Trabalho1Bim
{
    internal class Contornos
    {
        public Utils utils = new Utils();
        public RetanguloMinimo retanguloMinimo = new RetanguloMinimo();

        public Contornos() { }

        public void ExtracaoContornos(Bitmap imageOriginal, Bitmap imageDest)
        {
            for (int y = 1; y < imageOriginal.Height - 1; y++)
            {
                for (int x = 1; x < imageOriginal.Width - 1; x++)
                {
                    Color pixelAtual = imageOriginal.GetPixel(x, y);
                    Color proximoPixel = imageOriginal.GetPixel(x + 1, y);

                    if (utils.temTransicao(pixelAtual, proximoPixel))
                    {
                        if (imageDest.GetPixel(x, y) != Color.Red)
                        {
                            int xMenor = x, yMenor = y, xMaior = x, yMaior = y;

                            ContornarLetra(imageOriginal, imageDest, x, y, ref xMenor, ref yMenor, ref xMaior, ref yMaior);

                            retanguloMinimo.DesenharRetanguloMinimo(imageOriginal, xMenor, yMenor, xMaior, yMaior);
                        }
                    }
                }
            }

            RemoveTodosOsPretos(imageOriginal);
        }

        private void ContornarLetra(Bitmap imageOriginal, Bitmap imageDest, int xInicial, int yInicial, ref int xMenor, ref int yMenor, ref int xMaior, ref int yMaior)
        {
            int xAux = xInicial, yAux = yInicial;
            bool pintou;
            (Color, int, int)[] vizinhosPixelInicial;

            do
            {
                pintou = false;

                vizinhosPixelInicial = Obter8Vizinhos(imageOriginal, xAux, yAux);

                for (int j = 0; j < vizinhosPixelInicial.Length - 1 && !pintou; j++)
                {
                    if (utils.temTransicao(vizinhosPixelInicial[j].Item1, vizinhosPixelInicial[j + 1].Item1))
                    {
                        if (!(j == 1 && utils.Preto(vizinhosPixelInicial[0].Item1)))
                        {
                            imageDest.SetPixel(vizinhosPixelInicial[j].Item2, vizinhosPixelInicial[j].Item3, Color.Red);
                            imageOriginal.SetPixel(vizinhosPixelInicial[j].Item2, vizinhosPixelInicial[j].Item3, Color.Red);

                            retanguloMinimo.AtualizarRetanguloMinimo(vizinhosPixelInicial[j].Item2, vizinhosPixelInicial[j].Item3, ref xMenor, ref yMenor, ref xMaior, ref yMaior);

                            xAux = vizinhosPixelInicial[j].Item2;
                            yAux = vizinhosPixelInicial[j].Item3;

                            pintou = true;
                        }
                    }
                }

                if (!pintou && utils.temTransicao(vizinhosPixelInicial[vizinhosPixelInicial.Length - 1].Item1, vizinhosPixelInicial[0].Item1))
                {
                    imageDest.SetPixel(vizinhosPixelInicial[7].Item2, vizinhosPixelInicial[7].Item3, Color.Red);
                    imageOriginal.SetPixel(vizinhosPixelInicial[7].Item2, vizinhosPixelInicial[7].Item3, Color.Red);

                    retanguloMinimo.AtualizarRetanguloMinimo(vizinhosPixelInicial[7].Item2, vizinhosPixelInicial[7].Item3, ref xMenor, ref yMenor, ref xMaior, ref yMaior);

                    xAux = vizinhosPixelInicial[7].Item2;
                    yAux = vizinhosPixelInicial[7].Item3;

                    pintou = true;
                }

            } while ((xAux != xInicial || yAux != yInicial) && pintou);
        }

        private (Color cor, int x, int y)[] Obter8Vizinhos(Bitmap imageOriginal, int x, int y)
        {
            return new (Color, int, int)[]
            {
                (imageOriginal.GetPixel(x + 1, y), x + 1, y),
                (imageOriginal.GetPixel(x + 1, y - 1), x + 1, y - 1),
                (imageOriginal.GetPixel(x, y - 1), x, y - 1),
                (imageOriginal.GetPixel(x - 1, y - 1), x - 1, y - 1),
                (imageOriginal.GetPixel(x - 1, y), x - 1, y),
                (imageOriginal.GetPixel(x - 1, y + 1), x - 1, y + 1),
                (imageOriginal.GetPixel(x, y + 1), x, y + 1),
                (imageOriginal.GetPixel(x + 1, y + 1), x + 1, y + 1)
            };
        }

        private void RemoveTodosOsPretos(Bitmap imageDest)
        {
            for (int x = 0; x < imageDest.Width; x++)
            {
                for (int y = 0; y < imageDest.Height; y++)
                {
                    if (utils.Preto(imageDest.GetPixel(x, y)))
                    {
                        imageDest.SetPixel(x, y, Color.White);
                    }
                }
            }
        }
    }
}
