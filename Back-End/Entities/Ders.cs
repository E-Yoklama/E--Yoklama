using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Ders : IEntity
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
    }
}
