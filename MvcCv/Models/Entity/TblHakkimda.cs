//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblHakkimda
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]

        public string Ad { get; set; }
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]

        public string Soyad { get; set; }
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]

        public string Adres { get; set; }
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]

        public string Telefon { get; set; }
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]

        public string Mail { get; set; }
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]

        public string Aciklama { get; set; }
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]

        public string Resim { get; set; }


        public Nullable<bool> Status { get; set; }
    }
}
