using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rakos
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        

    }
    public class mult
        {
            public virtual int something(int numb)
            {
                return numb * 5;
            }
            public double plusmin(int bignum,int smalnum)
            {
                return (bignum + smalnum) / smalnum;
            }

        }
        public class overridemult:mult
        {
            public override int something(int numb)
            {
                return numb*7;
            }
            public double sum(double numb1,double numb2,double numb3)
            {
                return numb1 + numb2 + numb3;
            }
        }
}
