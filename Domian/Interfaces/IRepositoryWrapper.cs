﻿using Domian.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Interfaces
{
    public interface IRepositoryWrapper
    {
       
            IUserRepository User { get; }
            Task Save(); 
        
    }
}
