namespace PF_PingYuan_Desktop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "PY_User")]
    public partial class User
    {
        [Key]
        [StringLength(50)]
        [Display(Name = "����")]
        public string JobNo { get; set; }

        [StringLength(50)]
        [Display(Name = "�û���")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "����")]
        public string Password { get; set; }

        [StringLength(50)]
        [Display(Name = "��������")]
        public string Department { get; set; }

        [StringLength(50)]
        [Display(Name = "����Ȩ��")]
        public string OperationAuthority { get; set; }

        [StringLength(50)]
        [Display(Name = "Ȩ�޽���")]
        public string Explanation { get; set; }

        [Display(Name = "��Ч��")]
        public int? Effectiveness { get; set; }

        [StringLength(50)]
        [Display(Name = "��ע��Ϣ")]
        public string RemarkInfo { get; set; }

        [Display(Name = "��ǰ��¼��ʱ���")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss.fff")]
        public DateTime RecordTimestamp { get; set; }

        [Display(Name = "��ǰ��¼UID")]
        public int? UID { get; set; }
    }
}
