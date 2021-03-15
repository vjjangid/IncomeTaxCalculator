﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    interface IDeduction80EEB
    {
        int Deduction80EEBAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Amount that can be exempted under 80EEB
        /// </summary>
        /// <returns></returns>
        int GetAmountUnder80EEB();
    }
}
