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
    
    public partial class time
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public time()
        {
            this.jogo = new HashSet<jogo>();
            this.jogo1 = new HashSet<jogo>();
            this.time_jogador = new HashSet<time_jogador>();
            this.campeonato = new HashSet<campeonato>();
        }
    
        public int CD_TIME { get; set; }
        public string DS_NOME { get; set; }
        public Nullable<System.DateTime> DT_FUNDACAO { get; set; }
        public string DS_IMG_ESCUDO { get; set; }
        public string DS_ESTADIO { get; set; }
        public int CD_CIDADE { get; set; }
    
        public virtual cidade cidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jogo> jogo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jogo> jogo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<time_jogador> time_jogador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<campeonato> campeonato { get; set; }
    }
}