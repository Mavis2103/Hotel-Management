﻿using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class TienNghiDAO
    {
        HotelDTO db = new HotelDTO();
        private static TienNghiDAO instance;
        public static TienNghiDAO Instance
        {
            get { if (instance == null) instance = new TienNghiDAO(); return instance; }
            private set { instance = value; }
        }
        private TienNghiDAO() { }

        public List<TienNghi> GetTienNghis()
        {
            return db.TienNghis.ToList();
        }    
        public TienNghi FindTienNghi(string MaTN)
        {
            return db.TienNghis.Find(MaTN);
        }
        public void RemoveTN(TienNghi tienNghi) // try catch th có phòng có mã tiện nghi đó
        {
            db.TienNghis.Remove(tienNghi);
        }
        public void InsertOrUpdate(TienNghi tienNghi)
        {
            db.TienNghis.AddOrUpdate(tienNghi);
        }
        public List<TienNghi> FindTienNghiWithName(string name)
        {
            return db.TienNghis.Where(p => p.TenTN.Contains(name)).ToList();
        }
    }
}
