using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.Exemplos
{
    public class BaseA
    {
        public static int numero { get; set; }
        public virtual void M() { }
    }
    public class Derivada : BaseA
    {
        public static int numero { get; set; }
        public override void M() { }
    }
}
