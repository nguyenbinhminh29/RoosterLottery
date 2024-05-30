﻿using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Application.Interfaces
{
    public interface ILotteryServerService
    {
        GenericResult GetLottery(string openDate);
        GenericResult GetNextPeriod();
    }
}