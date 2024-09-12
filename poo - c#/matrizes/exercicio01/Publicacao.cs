using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    public interface Publicacao
    {
        void abrir();
        void fechar();
        void folhear(int p);
        void avançarPag();
        void voltarPag();

    }
}
