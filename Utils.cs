using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1Bim
{
    internal class Utils
    {
        public Utils() { }

        public bool Branco(Color cor)
        {
            return cor.R == 255 && cor.G == 255 && cor.B == 255;
        }

        public bool Preto(Color cor)
        {
            return cor.R == 0 && cor.G == 0 && cor.B == 0;
        }

        public bool temTransicao(Color color1, Color color2)
        {
            return Branco(color1) && Preto(color2);
        }
    }
}
