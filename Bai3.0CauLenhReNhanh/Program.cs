using System;
using System.Timers;

namespace Bai3._0CauLenhReNhanh
{
    internal class Program
    {
        /*
        * Bài 1.5 Câu điều kiện rẽ nhánh IF
        * ĐƯợc sử dụng để lập điều kiện và sẽ thực thi 1 hành động nào đó 
        * nếu thỏa mãn điều kiện.
    *
        * Công thức IF: if + tab
        *   if (<Điều kiện>)
    {
        If phải luôn đúng
        Một hành động được thi khi thỏa mãn điều kiện
    }
    */
        /*
        * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
        * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
        *
        * Cấu trúc:
        * if (true)
           {
               Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
           }
           else
           {
               Nếu không thỏa mãn IF thì mặc định là vào ELSE
           }
        */

        /*
       * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện
       * khác nhau và thực hiện hành động tương ứng với từng điều kiện. 
       * Else If phải luôn True thì mới thực hiện hành động bên trong nó.
       *
       * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong
       * điều kiện đó mà thôi.
       *
       * Công thức:
       *   if (true)
          {
              //Thực hiện 1 hành động nếu If đúng
          }else if (<Điều kiện 1>)
          {
              //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
          }else if (<Điều kiện 2>)
          {
              //Tương tự
          }else
          {
              //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
          }
       */
        static void Main(string[] args)
        {
            /////if
            //double diem = 2;
            //if(diem >=5)
            //{
            //    Console.WriteLine("Chúc mừng cấc bạn đã k mất 1300k");
            //}    
            //else
            //{
            //    Console.WriteLine("Chúc  mừng các bạn đã mat 672k");
            //}\

            //ví dụ: dùng else if
            /*
             * nếu qua môn net 101 cô thùy và thầy sẽ tặng các bạn
             * 5-6 điểm : iphone 11
             * 6-8 điểm : 13
             * 8-10 : 15 pro max
             */
            double diem = 8.5;
            if( diem >=5 && diem < 6)
            {
                Console.WriteLine("duoc tang ip 11");
            }
            else if( diem >=6 && diem < 8)
            {
                Console.WriteLine("tang ip 13");
            }
            else
            {
                Console.WriteLine("Tang ip 16");
            }
        }
    }
}
