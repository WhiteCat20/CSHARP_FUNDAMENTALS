﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_FUNDAMENTALS.belajar_interface
{
    class SebutHewan : ISebutHewan
    {
        public void sebutHewan()
        {
            Console.WriteLine("Ini hewan kucing");
        }
    }
}
