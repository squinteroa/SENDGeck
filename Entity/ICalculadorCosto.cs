﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface ICalculadorCosto
    {
        decimal CalcularCosto(Guia guia);
    }
}
