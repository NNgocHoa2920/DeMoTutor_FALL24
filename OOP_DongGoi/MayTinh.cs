using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DongGoi
{
    //cashc tạo class oop - tính chất đóng gói
    internal class MayTinh
    {

        //1. Thuộc tính : ma, hang, namsx,ich
        private string ma;
        private string hang;
        private int namsx;
        private double inch;

        //2. Contructor = hàm khởi tạo
        //contructor không có tham số = ctor  + tab
        public MayTinh()
        {
            
        }
        //contructor có tham số = ctrl + . => gennerate contructor
        public MayTinh(string ma, string hang, int namsx, double inch)
        {
            this.Ma = ma;
            this.Hang = hang;
            this.Namsx = namsx;
            this.Inch = inch;
        }

        //3. tạo các properties để có thể gán dữ liệu vào thuộc thông qwua phương thức get/ set
        //get: lấy dữ liệu
        //set: thiết lập dữ liệu
//bôi đênm thuộc tính =>quich action  => encapsulation
        public string Ma { get => ma; set => ma = value; }
        public string Hang { get => hang; set => hang = value; }
        public int Namsx { get => namsx; set => namsx = value; }
        public double Inch { get => inch; set => inch = value; }

       // 4. Tạo phương thức: INThongTin
       public void InThongTin()
        {
            Console.WriteLine($"Máy tính có mã {ma} - hãng {hang} - năm sx {namsx} - inch {inch}");
        }










    }
}
