using Business.Abstract;
using DataAccess.Abstract;
using Entities;

using System.Collections.Generic;


namespace Business
{
    public class DersManager : IDersService
    {
        IDersDal _IDersDal;
        public DersManager(IDersDal dersDal)
        {
            _IDersDal = dersDal;
        }
        public List<Ders> GetAll()
        {
            return _IDersDal.GetAll();
        }
    }
}
