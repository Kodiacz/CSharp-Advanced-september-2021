﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_5_DateModifier
{
    public class DateModifier
    {
        public static int GetDateDifferenceInDays(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);

            int days = Math.Abs((dateOne - dateTwo).Days);
            return days;
        }
    }
}
