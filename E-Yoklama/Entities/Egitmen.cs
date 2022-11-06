using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Egitmen : IEntity
    {
        public int EgitmenId { get; set; }
        public string EgitmenAdi { get; set; }
        public string EgitmenSoyadi { get; set; }
    }
}
