using System;
using System.Collections.Generic;

namespace FılmUygulamam.Entities;

public partial class Tur
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public List<FılmTur>FilmTurleri { get; set; } = new List<FılmTur>();
}
