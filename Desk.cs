using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stratford
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    class Desk
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int NumberOfDrawers { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }
    }
}
