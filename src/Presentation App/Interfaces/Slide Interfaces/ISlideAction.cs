﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_App
{
    public interface ISlideAction
    {
        void Run(ISlide slide);
    }
}
