// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.IO;

namespace SmartQuant
{
    public static class Installation
    {
        public static DirectoryInfo DataDir
        {
            get
            {
                return Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SmartQuant Ltd", "OpenQuant 2014", "data"));
            }
        }

        public static DirectoryInfo ConfigDir
        {
            get
            {
                return Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SmartQuant Ltd", "OpenQuant 2014", "config"));
            }
        }
    }
}
