using Entities;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IOgrenciService
    {
        List<Ogrenci> GetAll();
    }
}
