//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FutStat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class posicao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public posicao()
        {
            this.jogador = new HashSet<jogador>();
        }
    
        public int CD_POSICAO { get; set; }
        public string DS_POSICAO { get; set; }
        public string DS_SIGLA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jogador> jogador { get; set; }
    }
}