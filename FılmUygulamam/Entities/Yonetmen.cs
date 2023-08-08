using System;
using System.Collections.Generic;

namespace FılmUygulamam.Entities;

public partial class Yonetmen
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public DateTime? DogumTarihi { get; set; }

    public bool? EmekliMi { get; set; }

    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
