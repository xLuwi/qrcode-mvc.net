﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Controls
{
    public class CtrlInputModel : CtrlBaseModel
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public string PlaceHolder { get; set; }

        public CtrlInputModel()
        {
            ViewName = "";
        }
    }
}