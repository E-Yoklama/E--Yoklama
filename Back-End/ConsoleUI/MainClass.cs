using Business;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class MainClass
    {
        static void Main(string[] args)
        {
            DersManager dersManager = new DersManager(new DersDal());
            foreach (var ders in dersManager.GetAll())
            {
                Console.WriteLine(ders.DersAdi);
            }

            OgrenciManager ogrenciManager = new OgrenciManager(new OgrenciDal());
            foreach (var ogrenci in ogrenciManager.GetAll())
            {
                Console.WriteLine(ogrenci.OgrenciAdi);
            }
        }
    }
}
