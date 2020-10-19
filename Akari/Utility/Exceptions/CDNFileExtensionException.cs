﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Yamashiro.Utility.Exceptions
{
    public class CDNFileExtensionException : Exception
    {
        public CDNFileExtensionException(CDNExtension EXT) : base("Endpoint does not support file extension " + EXT.ToString()) { }
    }
}
