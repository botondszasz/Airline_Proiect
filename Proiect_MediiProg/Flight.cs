namespace Proiect_MediiProg
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            BookedFlights = new HashSet<BookedFlight>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string From { get; set; }

        [StringLength(50)]
        public string To { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(10)]
        public string Time { get; set; }

        [StringLength(10)]
        public string Duration { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookedFlight> BookedFlights { get; set; }
    }
}
