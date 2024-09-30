using System;
using System.Text;

namespace Bai2_NhapXuat
{
    internal class Program
    {
        /*
        * Bai 1.2: Nhập xuát dữ liệu từ bàn phím
        * 1. Xuất dữ liệu ( xuất cái mình cần hiển thị) ra bàn phím
        *    + : Phím tắt: cw + tab tab
        *    + Console.WriteLine(): Ghi xong sẽ tự động xuống dòng
        *    + Console.Write(): Ghi xong và k tự động xuống dòng
        * 2. Nhập dữ liệu từ bàn phím
        * + Console.Read(): Đọc 1 kí tự từ bàn phím nhưng là số ASII
        * + Console.ReadLine(): Đọc nhiều kí tự từ bàn phím và kiểu dữ liệu   
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // giúp đọc được tiếng việt
            Console.WriteLine("Chào các bạn nhé các bạn đã ăn cơm chưa");
            int a=1;
            int a1;
            double b=3;
            string c="hi";
            Console.WriteLine("Mời bạn nhập số a:");

            //CÁC KIIEERU INT, BOOL, DOUBLE .... ĐỀU CONVERT 
            //cách 1: parse: [kieu du lieu ].Parse(console.realine))
            //a= int.Parse(Console.ReadLine());
            ////cách 2: convert
            //Console.WriteLine("Mời bạn nhập số a2:");
            //a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mời bạn nhập b");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap c đi");
            //c=Console.ReadLine();

            //IN
            Console.WriteLine("sỐ A LÀ : " + a);
            Console.Write($"số b là {b}");
            Console.WriteLine("c là " + c);
           
        }
    }
}

/*
       * 4 Loại toán tử trong lập trình
       *  1. Toán tử số học:
       *  (+ - * / % ++ --)
       *      +: Tính tổng của 2 số hoặc dùng để cộng chuỗi
       *      -: Phép trừ của 2 số
       *      *: Phép nhân của 2 số
       *      %: Phép chia lấy dư của 2 số
       *      ++: Tăng lên 1 đơn vị
       *      --: Giảm 1 đơn vị
       *  2. Toán tử so sánh:
       *  (> < >= <= == !=)
       *      >: Lớn hơn
       *      <: nhỏ hơn
       *      >=: lớn hơn hoặc bằng
       *      <=: nhỏ hơn hoặc bằng
       *      ==: so sánh bằng
       *      !=: so sánh khác
       *  3. Toán tử Logic:
       * (&& || !)
       *      &&: Yêu cầu các mệnh đề phải luôn đúng  ( toán tử đồng thời
       *      ||: Yêu cầu 1 trong các mệnh đề dúng là được  ( toán tử hoặc
       *      !: Lấy giá trị phủ định của mệnh đề.   !0 => lấy gtri khác 0
       *  4. Toán tử gán:
       * (= += -= *= /= %=)
       *      +=: Cộng tiếp với vế bên phải các phép còn lại tương tự   
       */
