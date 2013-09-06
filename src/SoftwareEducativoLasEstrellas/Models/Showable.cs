using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareEducativoLasEstrellas.Models
{
    public interface Showable
    {
        string Type { get; }
        string Path { get; }
        string Category { get; set; }
        string FileName { get; set; }
        bool ShowIn(Medium medium);
    }
}
