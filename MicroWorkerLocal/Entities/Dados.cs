using System;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Threading.Tasks;

namespace MicroWorkerLocal.Entities {
    public class Dados {
        public int GId { get; set; }
        public string Endereco { get; set; }
        public Geometry Geom { get; set; }
    }
}
