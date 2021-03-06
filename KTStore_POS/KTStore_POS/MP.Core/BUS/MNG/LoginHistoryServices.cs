﻿using KTStore.MP.Core.Lib.Helper;
using KTStore_POS.Models.EFModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace KTStore.MP.Core.BUS.MNG
{
    public class LoginHistoryServices
    {
        /// <summary>
        /// Lấy lịch sử login/logout theo thời gian
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public object GetLoginHistory(DateTime from, DateTime to, bool isExport)
        {
            try
            {
                ManagementWarehouseEntities dbContext = new ManagementWarehouseEntities();
                List<MNG_HistoryLogin> lst = new List<MNG_HistoryLogin>();
                if (!isExport)
                {
                    lst = dbContext.MNG_HistoryLogin.Where(x => x.DateLogin >= from && x.DateLogin <= to).Take(500).ToList();
                    return lst;
                }
                else
                {
                    lst = dbContext.MNG_HistoryLogin.Where(x => x.DateLogin >= from && x.DateLogin <= to).ToList();
                    #region Xuất excel
                    var valueConvert = CRMHelper.ToDataTable<MNG_HistoryLogin>(lst);

                    if (valueConvert.GetType() == typeof(string)) return new { status = "err-larger-data" };
                    DataTable dt = valueConvert;
                    dt.Columns["UserName"].ColumnName = "Tên đăng nhập";
                    dt.Columns["DateLogin"].ColumnName = "Ngày giờ đăng nhập";
                    dt.Columns["Status"].ColumnName = "Trạng thái";
                    dt.Columns["IP"].ColumnName = "IP";
                    dt.Columns.Remove("ID");
                    dt.Columns.Remove("FullName");
                    var valueConvertExcel = CRMHelper.ExportDatatableToExcel(dt, "Login history");
                    if (valueConvertExcel == "err") return new { status = "err-convert-excel" };
                    return valueConvertExcel;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}