﻿using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.ResAndReq.Res.User
{
    public class ResUserProfile : ResBase
    {
        public Entities.User User { get; set; }
    }
}
