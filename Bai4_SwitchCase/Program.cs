using System;
using System.Text;

namespace Bai4_SwitchCase
{
    internal class Program
    {

        /*
         * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
         *
         * Công thức: sw + tab
         *
         *  switch (<Biểu thức>)
            {
                case <giá trị 1>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                case <giá trị 2>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                .......
                case <giá trị n>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                default:
                    Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                    break;
            }
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string input;
            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1.PHỞ BÒ");
                Console.WriteLine("2. cƠM RANG DƯA BÒ");
                Console.WriteLine("3.cƠM TẤM");
                Console.WriteLine("4.Thoát");
                Console.WriteLine("Mời bạn chọn món: ");
                input = Console.ReadLine(); // hứng gtri của người dùng nhâp vào
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Phở bò");  // thực hiện hành động
                        break;
                    case "2":
                        Console.WriteLine("cơm rang dưa bò bò");  // thực hiện hành động
                        break;
                    case "3":
                        Console.WriteLine("cơm tấm");  // thực hiện hành động
                        break;

                    default:

                        break;
                }
            } while (input != "4");

        }
    }
}
