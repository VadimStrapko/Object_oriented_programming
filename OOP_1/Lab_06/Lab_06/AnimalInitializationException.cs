﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class AnimalInitializationException : ArgumentException
    {
        //связан с инициализацией объектов типа Animal
        public AnimalInitializationException(string message) : base(message) { }
    }
}
