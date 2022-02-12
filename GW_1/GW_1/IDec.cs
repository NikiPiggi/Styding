using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW_1
{
    internal interface IDec
    {
        public string toString();
        public int AddLeft(int Ell);//добавления в начало
        
        public int AddRight(int Ell);//по анологии


        public int DeletLeft();


        public int DeletRight();
        
    }
}
