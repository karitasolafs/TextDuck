﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace TextDuck.UF
{
        public class ValidateFileAttribute : RequiredAttribute
        {
            public bool Validation(HttpPostedFile value)
            {
                if (value == null)
                {
                    return false;
                }
                string extension = Path.GetExtension(value.FileName);
                if (extension == null)
                {
                    return false;
                }
                if (extension == ".srt")
                {
                    return true;
                }
                return false;
            }
    }
}