//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vale24hWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public usuario()
        {
            this.categoria = new HashSet<categoria>();
            this.categoria1 = new HashSet<categoria>();
            this.cliente = new HashSet<cliente>();
            this.cliente1 = new HashSet<cliente>();
            this.endereco = new HashSet<endereco>();
            this.endereco1 = new HashSet<endereco>();
            this.telefone = new HashSet<telefone>();
            this.telefone1 = new HashSet<telefone>();
        }
    
        public long codigo_usr { get; set; }
        public string login_usr { get; set; }
        public string pw_usr { get; set; }
        public string nome_usr { get; set; }
        public string codigoTel_usr { get; set; }
    
        public virtual ICollection<categoria> categoria { get; set; }
        public virtual ICollection<categoria> categoria1 { get; set; }
        public virtual ICollection<cliente> cliente { get; set; }
        public virtual ICollection<cliente> cliente1 { get; set; }
        public virtual ICollection<endereco> endereco { get; set; }
        public virtual ICollection<endereco> endereco1 { get; set; }
        public virtual ICollection<telefone> telefone { get; set; }
        public virtual ICollection<telefone> telefone1 { get; set; }
    }
}