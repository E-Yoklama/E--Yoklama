using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;


namespace Business
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _OgrenciDal; // injection

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _OgrenciDal = ogrenciDal;
        }
        public List<Ogrenci> GetAll()
        {
            return _OgrenciDal.GetAll();
        }
    }
}
