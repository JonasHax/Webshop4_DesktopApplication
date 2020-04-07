﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model {

    public class CompanyProductVersion {
        public CompanyProduct Product { get; set; }
        public int Stock { get; set; }

        public string SizeCode { get; set; }

        public string ColorCode { get; set; }

        public CompanyProductVersion() {
        }

        public override string ToString() {
            return $"Size: {SizeCode}, Color: {ColorCode}, stock: {Stock}";
        }
    }
}