using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Interfaces
{
    public interface ICanStudy // I de interface
    {
         void Rest(int hours);
         void Study(int hours);
        
        int Energy { get; set; }
    }
}
