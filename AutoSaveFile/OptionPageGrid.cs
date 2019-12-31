﻿using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace AutoSaveFile
{
    public class OptionPageGrid : DialogPage
    {
        [Category("General")]
        [DisplayName("Time Delay")]
        [Description("Time delay in seconds for save")]
        public int TimeDelay { get; set; } = 5;
    }
}