using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговый_проект.Plugins
{
    public class TempExchange <T>
    {
        public T Ob;

        public TempExchange()
        {
            Ob = default(T);
        }
        public TempExchange(T ob)
        {
            Ob = ob;
        }

        public void Get(T ob)
        {
            Ob = ob;
        }
        public T Set()
        {
            return Ob;
        }
    }
}
