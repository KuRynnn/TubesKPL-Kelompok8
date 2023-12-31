﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubesKPL_Kelompok8;

namespace TubesKPL_Kelompok8
{
    public class Akun
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public Pembeli pembeli { get; set; }
        public Penjual penjual { get; set; }
        public Akun() { }
        public Akun(string uname, string pword)
        {
            username = uname;
            password = pword;
            pembeli = new Pembeli();
            penjual = new Penjual();
        }
    }
}
public class Pembeli
{
    public List<Pesanan> pemesanan { get; set; }
    public Pembeli()
    {
        pemesanan = new List<Pesanan>();
    }
}
public class Penjual
{
    public string description { get; set; }
    public List<string> language { get; set; }
    public List<Pesanan> pesanan { get; set; }
    public List<Jasa> jasa { get; set; }
    public Penjual()
    {
        language = new List<string>();
        pesanan = new List<Pesanan>();
        jasa = new List<Jasa>();
    }

}
public class Pesanan
{
    public string nama_pesanan { get; set; }
    public string akun_penyedia { get; set; }
    public string jenis_jasa { get; set; }
    public string deskripsi_pesanan { get; set; }
    public string status_pesanan { get; set; }
    public Pesanan() { }
}
public class Jasa
{
    public string jenis_jasa { get; set; }
    public int harga { get; set; }
    public string deskripsi { get; set; }
    public Jasa() { }
}
public class Konfig
{
    public List<Akun> akun { get; set; }
    public Konfig()
    {
        akun = new List<Akun>();
    }
}
