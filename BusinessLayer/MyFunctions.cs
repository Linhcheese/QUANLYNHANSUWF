﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MyFunctions
    {
        //đếm số nagfy làm việc trong tuần 
        public static int Demngaylamviectrongthang(int thang, int nam)
        {
            int dem = 0;
            DateTime f = new DateTime(nam, thang, 01);
            int x = f.Month + 1;
            while (f.Month < x)
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
    }
}
