using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Ogrenci : IEntity
    {
        public int OgrenciId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
    }
}
