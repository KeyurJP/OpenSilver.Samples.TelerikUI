﻿using OpenSilver.Simulator;
using System;

namespace OpenSilver.Samples.TelerikUI.Simulator
{
    static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(OpenSilver.Samples.TelerikUI.App));
        }
    }
}