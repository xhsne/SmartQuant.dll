// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;
using System.Collections;

namespace SmartQuant
{
	public class LicenseInfo
	{
        public bool Licensed
        {
            get
            {
                return true;
            }
        }

        public bool EvaluationLockEnabled
        {
            get
            {
                return false;
            }
        }

        public int EvaluationTime
        {
            get
            {
                return int.MaxValue;
            }
        }

        public int EvaluationTimeCurrent
        {
            get
            {
                return 1;
            }
        }

        public bool ExpirationDateLockEnabled
        {
            get
            {
                return false;
            }
        }

        public DateTime ExpirationDate
        {
            get
            {
                return DateTime.MaxValue;
            }
        }

        // TODO: what fields?
        public IDictionary<string, string> Fields
        {
            get
            {
                IDictionary<string, string> dictionary = new SortedDictionary<string, string>();
                return dictionary;
            }
        }
	}
}

