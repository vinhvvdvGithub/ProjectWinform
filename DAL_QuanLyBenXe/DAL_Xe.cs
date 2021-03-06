﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ET_QuanLyBenXe;

namespace DAL_QuanLyBenXe
{
    public class DAL_Xe
    {
        
        //lay danh sach xe
        public DataTable getXe()
        {
            string query = string.Format("SP_DanhSachXe");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //fill combobox ma so chu xe
        public DataTable FillComboboxMaSoCX()
        {
            string query = string.Format("SP_DanhSachChuXe");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //fill combobox ma so ma tuyen
        public DataTable FillComboboxMaSoTuyen()
        {
            string query = string.Format("SP_DanhSachTuyen");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        /// <summary>
        /// them xoa sua
        /// </summary>
        /// <param name="etXe"></param>
        /// <returns></returns>
        //insert xe 
        public bool InsertXe(ET_Xe etXe)
        {
            string query = string.Format("SP_ThemXe @msx , @bienso , @soghe , @mscx , @mst");
            object[] para = new object[]
            {
                etXe.MsX,etXe.BienSo,etXe.SoGhe,etXe.MsCX,etXe.MsT
            };
            if( DataProvider.Instance.ExecuteNonQuery(query,para)!=0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        //update xe
        public bool UpdateXe(ET_Xe etXe)
        {
            string query = string.Format("SP_UpDateXe @msx , @bienso , @soghe , @mscx , @mst");
            object[] para = new object[]
            {
                etXe.MsX,etXe.BienSo,etXe.SoGhe,etXe.MsCX,etXe.MsT
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        //xoa xe
        public bool DeleteXe(string id)
        {
            string query = string.Format("SP_UpDateXe @msx");
            object[] para = new object[]
            {
               id
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
