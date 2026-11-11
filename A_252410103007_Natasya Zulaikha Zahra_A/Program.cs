using System;
using System.Globalization;

namespace BebekSejahtera
{
    public class KaryawanBebek
    {
        public string idBebek { get; set; }
        public string namaBebek { get; set; }
        public int jumlahTugas { get; set; }

        public KaryawanBebek(string idBebek, string namaBebek, int jumlahTugas)
        {
            idBebek = idBebek;
            namaBebek = namaBebek;
            jumlahTugas = jumlahTugas;
        }
    }

    public class TampilInfo
    {
        public string idBebek($"ID Bebek {idBebek}");
        public string namaBebek("$Nama Bebek { namaBebek}");
        public int jumlahTugas("$Jumlah Tugas { jumlahTugas}");
    }

    public abstract class Pekerjaan
    {
        private string idBebek;
        private string namaBebek;
        private int jumlahTugas;
    }

   public void idBebek
        {
            get{ return idBebek; }
            set { idBebek value; }
        }

        public void namaBebek
        {
            get { return namaBebek; }
            set { namaBebek value; }
        }

    public abstract class KurangiStok (int jumlah)
    {
        public double jumlahTugas
        {
            get { return jumlahTugas; }
            set
            {
                if (stokTugas >= 0) ;
                (stokTugas -= jumlah);
            }
            else
            {
                Console.WriteLine("Jumlah stok tidak cukup.");

            }
        }
    }

    public virtual HitungBiaya (int jumlah)
    {
        public override PekerjaanMagang : Pekerjaan
        {
            Deskripsi { PekerjaanMagang }

            Console.WriteLine("fotokopi dokumen, membuat kopi untuk atasan,dan menyusun laporan yang tidak pernah dibaca.");
    
            jumlah * 10000;
        }

        public override PekerjaanSenior : Pekerjaan
        {
            Deskripsi { PekerjaanSenior }

            Console.WriteLine("Programming", "Data Analyst", "Manajemen Proyek".);

            jumlah * 50000;
        }
    }
public interface IDapatDitugaskan
{
    public class DistribusiTugas : IDapatDitugaskan
    {

    }
}
}