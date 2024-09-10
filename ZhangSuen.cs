using System;
using System.Collections.Generic;
using System.Drawing;

namespace Trabalho1Bim
{
    internal class ZhangSuen
    {
        public void AfinarImagem(Bitmap imageOriginal, Bitmap imageDest)
        {
            List<(int x, int y)> coordenadasPixels = new List<(int x, int y)>();
            bool flag = true;

            while (flag)
            {
                flag = false;

                for (int x = 1; x < imageOriginal.Width - 1; x++)
                {
                    for (int y = 1; y < imageOriginal.Height - 1; y++)
                    {
                        Color pixel = imageOriginal.GetPixel(x, y);

                        if (Preto(pixel))
                        {
                            if (Conectividade1(imageOriginal, x, y))
                            {
                                var vizinhosPretos = QuantidadeVizinhosPretos(imageOriginal, x, y);
                                if (vizinhosPretos >= 2 && vizinhosPretos <= 6)
                                {
                                    if (VerificaHorizontalESuperior(imageOriginal, x, y, true))
                                    {
                                        if (VerificaVerticalELateral(imageOriginal, x, y, true))
                                        {
                                            coordenadasPixels.Add((x, y));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (coordenadasPixels.Count > 0)
                {
                    foreach (var coordenadas in coordenadasPixels)
                    {
                        imageDest.SetPixel(coordenadas.x, coordenadas.y, Color.White);
                        imageOriginal.SetPixel(coordenadas.x, coordenadas.y, Color.White);
                    }

                    coordenadasPixels.Clear();
                }

                for (int x = 1; x < imageOriginal.Width - 1; x++)
                {
                    for (int y = 1; y < imageOriginal.Height - 1; y++)
                    {
                        Color pixel = imageOriginal.GetPixel(x, y);

                        if (Preto(pixel))
                        {
                            if (Conectividade1(imageOriginal, x, y))
                            {
                                var vizinhosPretos = QuantidadeVizinhosPretos(imageOriginal, x, y);
                                if (vizinhosPretos >= 2 && vizinhosPretos <= 6)
                                {
                                    if (VerificaHorizontalESuperior(imageOriginal, x, y, false))
                                    {
                                        if (VerificaVerticalELateral(imageOriginal, x, y, false))
                                        {
                                            coordenadasPixels.Add((x, y));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (coordenadasPixels.Count > 0)
                {
                    foreach (var coordenadas in coordenadasPixels)
                    {
                        imageDest.SetPixel(coordenadas.x, coordenadas.y, Color.White);
                        imageOriginal.SetPixel(coordenadas.x, coordenadas.y, Color.White);
                    }

                    coordenadasPixels.Clear();
                    flag = true;
                }
            }
        }

        private bool Conectividade1(Bitmap image, int x, int y)
        {
            Color[] vizinhos = ObterVizinhos(image, x, y);
            int transicoes = 0;

            for (int i = 0; i < vizinhos.Length - 1; i++)
            {
                if (Branco(vizinhos[i]) && Preto(vizinhos[i + 1]))
                {
                    transicoes++;
                }
            }

            if (Branco(vizinhos[vizinhos.Length - 1]) && Preto(vizinhos[0]))
            {
                transicoes++;
            }

            return transicoes == 1;
        }

        private int QuantidadeVizinhosPretos(Bitmap image, int x, int y)
        {
            int contadorPretos = 0;
            for (int i = y - 1; i <= y + 1; i++)
            {
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (!(i == y && j == x) && Preto(image.GetPixel(j, i)))
                    {
                        contadorPretos++;
                    }
                }
            }
            return contadorPretos;
        }

        private Color[] ObterVizinhos(Bitmap image, int x, int y)
        {
            return new Color[]
            {
                image.GetPixel(x - 1, y - 1),
                image.GetPixel(x, y - 1),     
                image.GetPixel(x + 1, y - 1), 
                image.GetPixel(x + 1, y),     
                image.GetPixel(x + 1, y + 1), 
                image.GetPixel(x, y + 1),     
                image.GetPixel(x - 1, y + 1), 
                image.GetPixel(x - 1, y)      
            };
        }

        private bool VerificaHorizontalESuperior(Bitmap image, int x, int y, bool PrimeiraSubIteracao)
        {
            if (PrimeiraSubIteracao)
            {
                return Branco(image.GetPixel(x, y + 1)) || Branco(image.GetPixel(x - 1, y)) || Branco(image.GetPixel(x, y - 1));
            }
            else
            {
                return Branco(image.GetPixel(x - 1, y)) || Branco(image.GetPixel(x, y + 1)) || Branco(image.GetPixel(x + 1, y));
            }
        }

        private bool VerificaVerticalELateral(Bitmap image, int x, int y, bool PrimeiraSubIteracao)
        {
            if (PrimeiraSubIteracao)
            {
                return Branco(image.GetPixel(x - 1, y)) || Branco(image.GetPixel(x + 1, y)) || Branco(image.GetPixel(x, y - 1));
            }
            else
            {
                return Branco(image.GetPixel(x, y + 1)) || Branco(image.GetPixel(x + 1, y)) || Branco(image.GetPixel(x, y - 1));
            }
        }

        private bool Branco(Color cor)
        {
            return cor.R == 255 && cor.G == 255 && cor.B == 255;
        }

        private bool Preto(Color cor)
        {
            return cor.R == 0 && cor.G == 0 && cor.B == 0;
        }
    }
}
