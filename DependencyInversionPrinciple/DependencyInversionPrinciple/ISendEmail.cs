﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    //Abstraction
    public interface ISendEmail
    {
        void SendEmail(string email);
    }
}
