﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoENT
{
    public class Result
    {
        public bool Correct { get; set; }

        public string Message { get; set; }

        public Exception Exception { get; set; }

        public object Object { get; set; }

        public List<object> Objects { get; set; }
    }
}