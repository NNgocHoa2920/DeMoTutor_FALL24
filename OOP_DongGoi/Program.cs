using System;

namespace OOP_DongGoi
{
    internal class Program
    {
        //lẬP TRÌNH HƯỚNG ĐỐI TƯỢNG -OOP LÀ 1 LĨ THUẬT LẬP TRÌNH DỰA TRÊN CÁC KHÁI NIỆM CỦA CLASS VÀ OBJECT
        // 4 TÍNH CHẤT: ĐÓNG GÓI, KẾ THỪA, ĐA HÌNH , tRỰU TƯỢNG
        //object là đối tượng = là 1 sự vật sự việc trong thực tế : sinh viên, ô tô, bàn : đặc điểm/ hành động
        //class: là 1 khuôn mẫu chung bao gồm các đối tượng giống nhau  
        //bao gồm:

        //Đặc điểm = thuộc tính 
        //hành động = phương thức = method
        static void Main(string[] args)
        {
            //tÍNH ĐÓNG GÓI: LÀ 1 KI THUẬT CHE ĐẤU DỮ LIỆU KHÔNG CHO BÊN NGOÀI TÁC ĐỘNG VÀO NHẰM BẢO TOÀN DỮ LIỆU
            // PHẠM VI TRUY CẬP: PRIVATE 
            //1. Khơi tạo đối tượng
            MayTinh mt = new MayTinh(); // khởi tajo1  cointructor k có tham số
            MayTinh mt1 = new MayTinh("MT01","DELL", 1990,21); // nhập thì đảm bảo kiểu dữ liệu và thứ tự

            //gán gitr
            mt.Ma = "mt02";
            mt.Hang = "asus";
            mt.Namsx = 1999;
            mt.Inch = 16;

            mt.Namsx = 200;

            mt.InThongTin();

            mt1.InThongTin();
        }
    }
}
