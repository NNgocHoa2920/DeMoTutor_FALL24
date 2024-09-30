using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///1. khai báo mảng
            /* cách 1: <kiểu dữ liệu>[] arr<Tên mảng>    ví dụ : int[] arrNumber  => khai báo mảng có tên là arrNumber có kiểu dữ liệu là int
             * arr<Tên màng> = new <>Kiểu dữ liệu>[Lengt] ví dụ: arrNumber = new int[5] // khở tạo mảng có kích thước là 5
             * new là toán tử khởi tạo
             */

            //cách 1
            string[] arrName1;
            arrName1 = new string[10];

            //cách 2
            string[] arrName2 = new string[10]; // khai báo mảng đồng thời tạo kích thước
            //cách 3:
            string[] arrName3 = new[] { "c#1", "c@2" }; // add luôn phần tử vào mảng
            //cách 3: 

            string[] arrName4 = new string[] { "a", "b" };

            //gán giá trị cho mảng thông qua index= vị trí
            arrName1[0] = "a"; // gán giá trị thứ 0 cho mảng
            arrName1[1] = "b";
            arrName1[2] = "c";
            arrName1[2] = "hi";  // ghi đè lại giá trị của vị trí thứ 2
            // a,b,hi 
            //in ra toàn bộ phần tử của mảng
            //foreeach : duyệt theo phần tử 
            // var: dùng khi mình k xác định được kiểu dữ liệu => rất hay dùng cho kiểu đối tượng
            foreach(string s in arrName1)
            {
                Console.WriteLine(s);
            }
            //trong mảng index sẽ bắt đầu =0 
            //for: duyệt theo vị trí
            for (int i = 0; i < arrName1.Length; i++)
            {
                Console.WriteLine(arrName1[i]);
            }


            ///ARRAY LIST: KHAI BÁO 1 ARRAYLIST K CẦN XÁC ĐỊNH KIỂU DỮ LIỆU
            ArrayList arrLst = new ArrayList(); // khai báo và đồng thời khởi tạo

            //p2: gán giá trị thông qua phương thức add
            arrLst.Add("abc");
            arrLst.Add(1);
            arrLst.Add('d');
            foreach (var s in arrLst)
            {
                Console.WriteLine(s);
            }
            //xóa phần tử bằng phươ]ng thức remove
            arrLst.RemoveAt(1);
            foreach(var s in arrLst)
            {
                Console.WriteLine(s);
            }    
            //clear(): xóa toàn bộ mảng

            //LIST: CÓ TTHEER KHAI BÁO Ở DẠNG ĐỐI TƯỢNG
            List<int> arrList = new List<int>();

            //khai báo list theo dạng đối tượng
            List<SinhVien> sinhViens = new List<SinhVien>(); // tạo ra 1 list sv

          

        }
        public class SinhVien { }
    }
}
