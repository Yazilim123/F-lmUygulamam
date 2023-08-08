using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FılmUygulamam.Entities;

public partial class FilmDetay
{
    [Key]
    public int FilmId { get; set; }

    public decimal Maliyeti { get; set; }

    public string? Aciklamasi { get; set; }

    public virtual Film Film { get; set; } = null!;
}
