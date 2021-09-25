using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat1
{
    class CongThuc
    {
        private static double a,b; //Khai Báo Các Biến 

        public static double A { get => a; set => a = value; }
        public static double B { get => b; set => b = value; }
        
        public static double tinhChuVi()
        {
            //test push
            //hello! mình đẩy lên nhé!
            return (a + b) / 2; // chu vi hinh cn
        }
    }
}
