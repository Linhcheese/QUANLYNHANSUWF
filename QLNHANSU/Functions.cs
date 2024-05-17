using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU
{
    public  class Functions
        {
        //đếm số nagfy làm việc trong tuần 
        public static int Demngaylamviectrongthang(int thang, int nam)
        {
            int dem = 0;
            DateTime f = new DateTime(nam, thang, 01);
            int x = f.Month + 1;
            while ( f.Month < x)
            {
                dem = dem + 1;
                if (f.DayOfWeek == DayOfWeek.Sunday)
                {
                    dem = dem - 1;
                }
                f = f.AddDays(1);
            }
            return dem;
        }
        public static int laySoNgayCuaThang(int thang, int nam)
        {
            return DateTime.DaysInMonth(nam, thang);
        }

        public static String layThuTrongTuan(int nam, int thang, int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);
            switch (newDate.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ Hai";
                    break;
                case "Tuesday":
                    thu = "Thứ Ba";
                    break;
                case "Wednesday":
                    thu = "Thứ Tư";
                    break;
                case "Thursday":
                    thu = "Thứ Năm";
                    break;
                case "Friday":
                    thu = "Thứ Sáu";
                    break;
                case "Saturday":
                    thu = "Thứ Bảy";
                    break;
                case "Sunday":
                    thu = "Chủ nhật";
                    break;
            }
            return thu;
        }

        static SqlConnection con = new SqlConnection();
        //hàm tạo kết nối
        public static void taoKetNoi()
        {
            //Cấu trúc chuỗi kết nối đến CSDL
            con.ConnectionString = "Data Source=CHEESEEEEEEE\\SQLEXPRESS;Initial Catalog = QLNHANSU ; Integrated Security=True;";
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //hàm đóng kết nối

        public static void dongKetNoi()
        {
            con.Close();
        }

        public static DataTable getData(String query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }

        public static DataSet getDataSet(string query)
        {
            taoKetNoi();

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static void execQuery(string qr)
        
        {
            taoKetNoi();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }
    }
}
