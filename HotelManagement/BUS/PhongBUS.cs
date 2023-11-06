﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DTO;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    internal class PhongBUS
    {
        private static PhongBUS instance;
        public static PhongBUS Instance
        {
            get { if (instance == null) instance = new PhongBUS(); return instance; }
            private set { instance = value; }
        }
        private PhongBUS() { }
        public List<Phong> GetAllPhong()
        {
           return PhongDAO.Instance.GetAllPhongs();
        }
        public Phong FindePhong(string MaPh)
        {
            return PhongDAO.Instance.FindPhong(MaPh);  
        }    
    }
}
