namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_ProductionInfo")]
    public partial class ProductionInfo
    {
        public int Id { get; set; }

        public int AreaNo { get; set; }

        [Display(Name = "�Ҿߺ�")]
        public int RackNo { get; set; }

        [StringLength(50)]
        [Display(Name = "���α��")]
        public string BatchNo { get; set; }

        [Display(Name = "�������")]
        [StringLength(50)]
        public string WorkpieceNo { get; set; }

        [StringLength(50)]
        [Display(Name = "��������")]
        public string WorkpieceType { get; set; }

        [StringLength(50)]
        [Display(Name = "������ɫ")]
        public string PrimerColor { get; set; }

        [StringLength(50)]
        [Display(Name = "���᳧��")]
        public string PrimerFirm { get; set; }

        [StringLength(50)]
        [Display(Name = "���Ṥ��")]
        public string PrimerCraft { get; set; }

        [StringLength(50)]
        [Display(Name = "ɫ����ɫ")]
        public string PigmentedCoatingColor { get; set; }

        [StringLength(50)]
        [Display(Name = "ɫ�᳧��")]
        public string PigmentedCoatingFirm { get; set; }

        [StringLength(50)]
        [Display(Name = "ɫ�Ṥ��")]
        public string PigmentedCoatingCraft { get; set; }

        [StringLength(50)]
        [Display(Name = "������ɫ")]
        public string VarnishColor { get; set; }

        [StringLength(50)]
        [Display(Name = "������")]
        public string VarnishFirm { get; set; }

        [StringLength(50)]
        [Display(Name = "���Ṥ��")]
        public string VarnishCraft { get; set; }

        [Display(Name = "��Ч��")]
        public int? Validity { get; set; }


        [Display(Name = "ʱ���")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss.fff")]
        public DateTime RecordTimestamp { get; set; }

        [Display(Name = "UID")]
        public int? UID { get; set; }
    }
}
