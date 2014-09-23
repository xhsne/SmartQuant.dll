// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class LicenseManager
    {
        public LicenseInfo GetLicense()
        {
            return new LicenseInfo();
        }

        public string GetHardwareID()
        {
            // return whatever you wants
            return "3684350e-8d22-40f0-9ece-91bc369d0053";
        }

        public void LoadLicense(byte[] license)
        {
            // do nothing
        }
    }
}

