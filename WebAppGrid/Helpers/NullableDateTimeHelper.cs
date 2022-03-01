using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGrid.Helpers
{
    public static class NullableDateTimeHelper
    {
        public static DateTime? ConvertToNullableDate(this DateTime? d)
        {
            if (d == null)
                return null;

            return d.Value.Date;
        }

        //public DateTime? SchoolGraduationDate { get; set; }
    }
}