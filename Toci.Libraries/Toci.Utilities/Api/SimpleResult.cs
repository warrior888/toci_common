﻿using System.Collections.Generic;

namespace Toci.Utilities.Api
{
    public class SimpleResult
    {
        public int Code { get; set; } // 0 OK > 0 zle // Flags Enum

        public string Message { get; set; }

        public Dictionary<string,object> Data { get; set; }

        public string ErrorMessage { get; set; }
    }
}