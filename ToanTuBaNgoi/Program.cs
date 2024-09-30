using System;
using System.Runtime.Intrinsics.Arm;

namespace ToanTuBaNgoi
{
    internal class Program
    {
        /*
         * Toán tử 3 ngôi: nó là dạng viết tắt của if else
         * <Đk hoặc nhiều đk> ? <KQ nếu đk đúng> : <KQ nếu Đk sai>
         */

        static void Main(string[] args)
        {
            //string tem;
            //if(5>6)
            //{
            //    tem = "Sai";
            //    Console.WriteLine(tem);
            //}

            //else
            //{
            //    tem = "dung";
            //    Console.WriteLine(tem);
            //}

            ////toán tử 3 xử lí
            //string tem2 = 5 > 6 ? "Đúng" : "sAI";
            //Console.WriteLine(tem2) ;
            /*
           * Bài tập: Viết chưng trình khi nhập thông tin 1 người xác định được
           * ANH, CHỊ, EM TRAI, EM GÁI, BẠN
           * Cố định lai tuổi và giới tính của bản thân
           */
            // yêu cầu nhập năM sinh, tên, giới tính và thực hiện lời chào.
            int nsBanThan = 2005, gioitinh = 1; //1 nam , 0 nữ 
            int nsNguoi, gioiTinhNguoi;
            string tenNguoi;
            do
            {
                Console.WriteLine("Tên bạn là gì");
                tenNguoi = Console.ReadLine();
                Console.WriteLine("Năm sinh của bạn bn");
                nsNguoi = int.Parse(Console.ReadLine());
                Console.WriteLine("giới tính là gì:");
                gioiTinhNguoi = int.Parse(Console.ReadLine());
                string loichao  = ((nsNguoi < nsBanThan) && gioiTinhNguoi == 1) ? "anh trai"
                    : ((nsNguoi < nsBanThan) && gioiTinhNguoi == 0) ? "chi gái"
                    : ((nsNguoi > nsBanThan) && gioiTinhNguoi == 1) ? "em trai"
                    : ((nsNguoi > nsBanThan) && gioiTinhNguoi == 0) ? "em gái"
                    : "Bạh";
                Console.WriteLine($"Chào {loichao} {tenNguoi}");
            } while (true);
        }
    }
}
