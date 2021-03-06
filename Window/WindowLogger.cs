﻿using GameCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    class WindowLogger : Logger
    {
        Action<string> log;
        public WindowLogger(Action<string> log)
        {
            this.log = log;
        }

        public override void Log(string str) => log(str + "\n");
    }
}
