using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApsAdmin.EFModel.TempModels
{
    public class SCT26_PDF
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        public string SCZSBH { get; set; }
        /// <summary>
        /// 工厂代码
        /// </summary>
        public string SCGCDM { get; set; }
        /// <summary>
        /// 下单日期
        /// </summary>
        public DateTime? SCXDRQ { get; set; }
        /// <summary>
        /// 裁剪交期
        /// </summary>
        public DateTime? SCCJJQ { get; set; }
        /// <summary>
        /// 缝制交期
        /// </summary>
        public DateTime? SCFZJQ { get; set; }
        /// <summary>
        /// 计划交期
        /// </summary>
        public DateTime? SCJHRQ { get; set; }
        /// <summary>
        /// 计划人员
        /// </summary>
        public string SCJHRY { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string SCZSBZ { get; set; }
        /// <summary>
        /// 状态 默认S
        /// </summary>
        public string SCZSZT { get; set; }
        /// <summary>
        /// 结清说明
        /// </summary>
        public string SCJQSM { get; set; }
        /// <summary>
        /// 结清日期
        /// </summary>
        public DateTime? SCJQRQ { get; set; }
        /// <summary>
        /// 录入日期
        /// </summary>
        public DateTime? SCLRRQ { get; set; }
        /// <summary>
        /// 录入人员
        /// </summary>
        public string SCLRRY { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime? SCSHRQ { get; set; }
        /// <summary>
        /// 审核人员
        /// </summary>
        public string SCSHRY { get; set; }
        /// <summary>
        /// 整烫交期
        /// </summary>
        public DateTime? SCZTJQ { get; set; }
        /// <summary>
        ///包装日期 
        /// </summary>
        public DateTime? SCBZJQ { get; set; }
        /// <summary>
        /// 合同编号
        /// </summary>
        public string SCHTBH { get; set; }
        /// <summary>
        /// 投产日期
        /// </summary>
        public DateTime? SCTCRQ { get; set; }
        public string SCGCMC { get; set; }
    }

    public class MtmModel
    {
        public string SCZSBH { get; set; }
        public string SCHTBH { get; set; }
        public string SCYSPD { get; set; }
        public string SCKHXM { get; set; }
        public string XTWPYS { get; set; }
        public string XTWPKS { get; set; }
        public string XTSJBH { get; set; }
        public string WPSXMC { get; set; }
        public int SCZSSL { get; set; }
        public string SCJHDD { get; set; }
        public string FULIAO { get; set; }
        public string CHENLX { get; set; }
        public string KOUHAO { get; set; }
        public string XIANHAO { get; set; }
        public string SUOYX { get; set; }
        public string ZHUBX { get; set; }
        public string XTWPLJ { get; set; }
        public DateTime? SCJHRQ { get; set; }
        public string jhrq { get; set; }
    }

    public class MtmPdf
    {
        public SCT26_PDF sct26PDF { get; set; }
        public List<MtmModel> mtmPDFs { get; set; }
    }

    public class TzModel
    {
        public string SCZSBH { get; set; }
        public string SCHTBH { get; set; }
        public string SCZSPH { get; set; }
        public string XTWPKS { get; set; }
        public string XTWPYS { get; set; }
        public string XTWLDM { get; set; }
        public string XTWLMC { get; set; }
        public string SCHTBZ { get; set; }
        public int Num { get; set; }
        public string FZX { get; set; }
        public string NKX { get; set; }
        public string CLX { get; set; }
        public string XTSJBH { get; set; }
        public string XTBMDM { get; set; }
        public string BMMC { get; set; }
    }

    public class TzPdf
    {
        public SCT26_PDF sct26PDF { get; set; }
        public TzModel tzPDF { get; set; }
    }

}