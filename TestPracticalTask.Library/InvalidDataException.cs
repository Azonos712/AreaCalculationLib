﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPracticalTask.Library
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string msg) : base(msg) { }
    }
}
