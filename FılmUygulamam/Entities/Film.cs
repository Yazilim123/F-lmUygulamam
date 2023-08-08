using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FılmUygulamam.Entities;

public partial class Film
{
    
    public int Id { get; set; }
    [Required]
    [StringLength(300)]

    public string Adi { get; set; } = null!;
    [StringLength(4)]

    public string? YapimYili { get; set; }

    public int? YonetmenId { get; set; }

    public decimal? Gisesi { get; set; }

    public  Yonetmen? Yonetmen { get; set; }

    public  ICollection<Tur> Turs { get; set; } = new List<Tur>();
}
