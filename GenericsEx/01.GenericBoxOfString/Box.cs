﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T>
    {

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }


        public override string ToString()
        {

            string valueType = this.Value.GetType().FullName;

            return $"{valueType}: " + this.Value;
        }

    }
}
