using FılmUygulamam.Contexts;
using FılmUygulamam.DTO;
using FılmUygulamam.Entities;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace FılmUygulamam
{
    public partial class FilmlerForm : Form
    {
        FilmlerContext _db = new FilmlerContext();
        public FilmlerForm()
        {
            InitializeComponent();
        }

        private void FilmlerForm_Load(object sender, EventArgs e)
        {
            try
            {

                FilmListesiniDoldur();
            }
            catch (Exception exc)
            {

                MessageBox.Show("İşlem Sırasında hata meydana geldi! (" + exc.Message + " | " + exc.InnerException?.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void FilmListesiniDoldur()
        {
            List<Film> filmListesi;
            IQueryable<FilmDTO> filmQuery = _db.Filmler.Include(film => film.Yonetmen)
                .OrderBy(film => film.Yonetmen.Adi)
                .ThenBy(film => film.Yonetmen.Soyadi)
                .ThenBy(film => film.Adi)
                .Select(film => new FilmDTO()
                {
                    Adi = film.Adi,
                    Id = film.Id,
                    YapimYili = film.YapimYili,
                    Gisesi = film.Gisesi.HasValue ? film.Gisesi.Value.ToString("C2", new CultureInfo("tr-TR")) : "0",
                    YonetmenAdiSoyadi = film.Yonetmen.Adi + " " + film.Yonetmen.Soyadi

                });
            List<FilmDTO> filmlistesi = filmQuery.ToList();
            dgvFilmler.DataSource = filmlistesi;
            IFilmSayisi.Text = filmlistesi.Count == 0 ? "Film Bulunamadı." : filmlistesi.Count + " Film Bulundu :) ";
            FilmListesiSutunlariniDuzenle();

        }

        private void FilmListesiSutunlariniDuzenle()
        {
            // dgvFilmler.Columns["Id"].HeaderText = "ID";
            dgvFilmler.Columns["Adi"].HeaderText = "Film Adı";
            dgvFilmler.Columns["YonetmenAdiSoyAdi"].HeaderText = "Yönetmen Adı Soyadı";
            dgvFilmler.Columns["Adi"].Width = 175;
            dgvFilmler.Columns["YonetmenAdiSoyAdi"].Width = 130;
            dgvFilmler.Columns["YapimYili"].Width = 60;
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FilmListesiniDoldur();
            }
            catch (Exception exc)
            {

                MessageBox.Show("İşlem Sırasında hata meydana geldi! (" + exc.Message + " | " + exc.InnerException?.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}