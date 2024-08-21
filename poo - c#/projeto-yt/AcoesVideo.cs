using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_yt
{
    public interface AcoesVideo
    {
        public abstract void play();
        
        public abstract void pause();

        public abstract void like();
        
    }
}
