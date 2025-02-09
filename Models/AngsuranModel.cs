using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngsuranMVC.Models
{
    public class AngsuranModel
    {
        [Required]
        public string KontrakNo { get; set; }

        [Required]
        public string Client_Name { get; set; }        
         
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "OTR Lebih Dari 1 Bulan")]
        public decimal OTR { get; set; } 
        
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "DP Tidak Boleh Minus")]
        public decimal DP { get; set; } 
        
        [Required]
        [Range(1, 60, ErrorMessage = "Jangka Waktu Harus 1-60 Bulan")]
        public int JangkaWaktu { get; set; } 
        public decimal Bunga { get; set; } 
        public decimal AngsuranPerBulan { get; set; } 
        public DateTime StartDate { get; set; } = DateTime.Now;

        public void HitungAngsuran()
        {
            // hitung pokok utang
            decimal pokokUtang = OTR - DP;

            // tentukan bunga sesuai dengan jangka waktu
            if (JangkaWaktu <= 12)
                Bunga = 0.12m; 
            else if (JangkaWaktu > 12 && JangkaWaktu <= 24)
                Bunga = 0.14m; 
            else
                Bunga = 0.165m;

            // hitung angsuran / bulan
            AngsuranPerBulan = (pokokUtang + (pokokUtang * Bunga)) / JangkaWaktu;
        }

        // untuk buat jadwal angsuran
        public List<JadwalAngsuranModel> GenerateJadwal()
        {
            var jadwal = new List<JadwalAngsuranModel>();
            for (int i = 1; i <= JangkaWaktu; i++)
            {
                jadwal.Add(new JadwalAngsuranModel
                {
                    KontrakNo = KontrakNo,
                    Client_Name = Client_Name,
                    OTR = OTR,
                    DP = DP,
                    Bunga = Bunga,
                    JangkaWaktu = JangkaWaktu,
                    pokokUtang = OTR - DP,
                    AngsuranKe = i,
                    AngsuranPerBulan = AngsuranPerBulan,
                    TanggalJatuhTempo = StartDate.AddMonths(i - 1)
                });
            }
            return jadwal;
        }
    }

    public class JadwalAngsuranModel
    {
        public string KontrakNo { get; set; }
        public string Client_Name { get; set; }
        public int AngsuranKe { get; set; }
        public decimal AngsuranPerBulan { get; set; }
        public DateTime TanggalJatuhTempo { get; set; }
        public decimal OTR { get; set; }
        public decimal DP { get; set; }
        public decimal pokokUtang { get; set; }
        public decimal Bunga {get; set;}
        public decimal JangkaWaktu {get; set;}
    }
}
