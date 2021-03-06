﻿using System;
using System.Collections.Generic;

namespace AndroidVector
{
    public static class WarningsExtensions
    {
        public static void AddWarning(this List<string> warnings, string message)
        {
            if (!warnings.Contains(message))
                warnings.Add(message);
        }
    }
}
