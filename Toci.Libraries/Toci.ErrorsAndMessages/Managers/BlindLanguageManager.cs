﻿using Toci.Utilities.Common.Internationalization;

namespace ErrorsAndMessages.Managers
{
    public class BlindLanguageManager : LanguageManager
    {
        public override int GetLanguage()
        {
            return 1;
        }
    }
}