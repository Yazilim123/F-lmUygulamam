using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmUygulamam.Entities
{
    public class FılmTur
    {
        [Key]
        public int FilmId { get; set; }
        public Film Film { get; set; }
        [Key]
        public int TurId { get; set; }
        public Tur Tur { get; set; }
    }
}
