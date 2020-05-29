namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_ProductionPlan")]
    public partial class ProductionPlan
    {
        //[Display(Name = "���α��")]
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string BatchNo { get; set; }

        //[Display(Name = "�������")]
        [StringLength(50)]
        public string WorkpieceNo { get; set; }

        //[Display(Name = "��������")]
        [StringLength(50)]
        public string WorkpieceType { get; set; }

        //[Display(Name = "������ɫ")]
        [StringLength(50)]
        public string PrimerColor { get; set; }

        //[Display(Name = "���᳧��")]
        [StringLength(50)]
        public string PrimerFirm { get; set; }

        //[Display(Name = "���Ṥ��")]
        [StringLength(50)]
        public string PrimerCraft { get; set; }

        //[Display(Name = "ɫ����ɫ")]
        [StringLength(50)]
        public string PigmentedCoatingColor { get; set; }

        //[Display(Name = "ɫ�᳧��")]
        [StringLength(50)]
        public string PigmentedCoatingFirm { get; set; }

        //[Display(Name = "ɫ�Ṥ��")]
        [StringLength(50)]
        public string PigmentedCoatingCraft { get; set; }

        //[Display(Name = "������ɫ")]
        [StringLength(50)]
        public string VarnishColor { get; set; }

        //[Display(Name = "���᳧��")]
        [StringLength(50)]
        public string VarnishFirm { get; set; }

        //[Display(Name = "���Ṥ��")]
        [StringLength(50)]
        public string VarnishCraft { get; set; }

        //[Display(Name = "��Ч��")]
        public int? Validity { get; set; }

        //[Display(Name = "�ϼ�ʱ��")]
        [StringLength(50)]
        public string UpTime { get; set; }

        //[Display(Name = "ʱ���")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss.fff")]
        public DateTime RecordTimestamp { get; set; }

        //[Display(Name = "UID")]
        public int? UID { get; set; }

        public int? TotalNum { get; set; }
    }
}
