using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TubesKPL_Kelompok8
{
    internal class UnggahJasaConfig
    {
        private const string filepath = @"login_convig.json";
        public Konfig listAkun;

        public UnggahJasaConfig() //rewrite
        {
            listAkun = ReadKonfigFile<Konfig>();
        }

        public U ReadKonfigFile<U>()
        {
            string hasilBaca = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<U>(hasilBaca);
        }

        public void WriteKonfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string tulisan = JsonSerializer.Serialize(listAkun, options);
            File.WriteAllText(filepath, tulisan);
        }

        public Jasa BikinDataJasa(string jenis, int harga, string deskripsi)
        {
            Jasa data = new Jasa();
            data.jenis_jasa = jenis;
            data.harga = harga;
            data.deskripsi = deskripsi;
            return data;
        }

        public void TambahData(string username, string jenis, int harga, string desc) //rewrite 
        {
            Konfig obj = ReadKonfigFile<Konfig>();
            for (int i = 0; i < obj.akun.Count; i++)
            {
                if (obj.akun[i].username == username)
                {
                    Jasa dataJasa = new Jasa();
                    dataJasa = BikinDataJasa(jenis, harga, desc);
                    obj.akun[i].penjual.jasa.Add(dataJasa);
                }
            }
            listAkun = obj;
            WriteKonfigFile();
        }

        public void HapusData(string username, string jenis)
        {
            Konfig obj = ReadKonfigFile<Konfig>();
            Jasa jasaTemu = new Jasa();
            for (int i = 0; i < obj.akun.Count; i++)
            {
                if (obj.akun[i].username == username)
                {
                    foreach (Jasa jasa in obj.akun[i].penjual.jasa)
                    {
                        if (jasa.jenis_jasa == jenis)
                        {
                            jasaTemu = jasa;
                        }
                    }
                }
                if (jasaTemu != null)
                {
                    obj.akun[i].penjual.jasa.Remove(jasaTemu);
                }
            }
            listAkun = obj;
            WriteKonfigFile();
        }

        public void ShowData(Akun akun)
        {
            int i = 1;
            foreach (Jasa jasa in akun.penjual.jasa)
            {
                Console.WriteLine(i + ". ");
                Console.WriteLine("GAMBAR PROMOSI");
                Console.WriteLine("Title : " + jasa.jenis_jasa);
                Console.WriteLine("Price : " + jasa.harga);
                Console.WriteLine("Service Description : " + jasa.deskripsi);
                i++;
            }
        }

        public Akun SearchAkun(string username)
        {
            Konfig obj = ReadKonfigFile<Konfig>();
            foreach (Akun akun in obj.akun)
            {
                if (akun.username == username)
                {
                    return akun;
                }
            }
            return null;
        }

        public void Register(string fullname, string username, string email, string password)
        {
            Konfig obj = ReadKonfigFile<Konfig>();
            Akun akunBaru = new Akun(username, password);
            akunBaru.fullname = fullname;
            akunBaru.email = email;
            obj.akun.Add(akunBaru);
            listAkun = obj;
            WriteKonfigFile();
        }
    }
}
