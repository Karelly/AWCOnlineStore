﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWC.Entities
{
    [Serializable()]
    public class Category
    {
        public int CategoryID
        {
            get;
            set;
        }
        public string CategoryName
        {
            get;
            set;
        }
    }
}
