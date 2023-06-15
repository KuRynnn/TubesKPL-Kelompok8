using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TubesKPL_Kelompok8
{
    public class LoginConvig
    {
        public Konfig ListAkun;
        private const string filepath = @"login_convig.json";
        public LoginConvig()
        {
            ListAkun = new Konfig();
            try
            {
                ReadKonfigFile();
            }
            catch
            {
                SetDefault();
                WriteKonfigFile();
            }
        }

        public void ReadKonfigFile()
        {
            string hasil = File.ReadAllText(filepath);
            ListAkun = JsonSerializer.Deserialize<Konfig>(hasil);
        }

        public void WriteKonfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            string tulisan = JsonSerializer.Serialize(ListAkun, options);
            File.WriteAllText(filepath, tulisan);
        }

        public void SetDefault()
        {
            ListAkun = new Konfig();
            ListAkun.akun.Add(new Akun("Admin", "Admin"));
        }

        public int SearchAkun(string username)
        {
            int i = 0;
            foreach (Akun akun in ListAkun.akun)
            {
                if (akun.username == username)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
