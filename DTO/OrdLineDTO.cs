﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrdLineDTO
    {
        private int _OrdLineID;
        private int _OrdID;
        private int _DressID;
        private int _Quantity;
        private float _Sum;

        public int OrdLineID
        {
            get
            {
                return _OrdLineID;
            }
            set
            {
                _OrdLineID = value;
            }
        }

        public int OrdID
        {
            get
            {
                return _OrdID;
            }
            set
            {
                _OrdID = value;
            }
        }
        
        public int DressID
        {
            get
            {
                return _DressID;
            }
            set
            {
                _DressID = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }

        public float Sum
        {
            get
            {
                return _Sum;
            }
            set
            {
                _Sum = value;
            }
        }

        public OrdLineDTO() { }

    }
}
