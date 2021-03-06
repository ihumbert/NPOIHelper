﻿using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPOIHelper
{
    /// <summary>
    /// added by Labbor on 20170602
    /// </summary>
    public interface IHelper
    {
        /// <summary>
        /// 导出前
        /// </summary>
        void PreReport();

        /// <summary>
        /// Http导出报表
        /// </summary>
        void Report();

        /// <summary>
        /// Client导出报表
        /// </summary>
        void ReportClient(string fileName);

        /// <summary>
        /// 设置报表信息
        /// </summary>
        void SetInformation();

        /// <summary>
        /// 添加Sheet
        /// </summary>
        /// <param name="sheet"></param>
        void Add(ISheet sheet);

        /// <summary>
        /// 添加Sheet  MaxLine = 65535
        /// </summary>
        /// <param name="_SheetName"></param>
        /// <param name="data"></param>
        /// <param name="columns"></param>
        void Add(string _SheetName, DataTable data, Column[] columns = null);

        /// <summary>
        /// 添加Sheet  MaxLine = 65535
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_SheetName"></param>
        /// <param name="data"></param>
        /// <param name="columns"></param>
        void Add<T>(string _SheetName, List<T> data, Column[] columns = null);
    }
}
