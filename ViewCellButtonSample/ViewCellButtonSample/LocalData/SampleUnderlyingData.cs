using System;
using System.Collections.Generic;
using System.Globalization;
using ViewCellButtonSample.Models;

namespace ViewCellButtonSample.LocalData
{
    public static class SampleUnderlyingData
    {

        public static List<UnderlyingData> ListOfPrayerRequests { get; set; } = new List<UnderlyingData>
        {
            new UnderlyingData (){
                Id = 1,
                CreatedDateTimeString = DateTime.Now.ToString("MMM d h:mm tt", new CultureInfo("en-US")),
                CreatedDateTime = DateTimeOffset.UtcNow,
                TheChangingString = "first test string"
            },
            new UnderlyingData (){
                Id = 2,
                CreatedDateTimeString = DateTime.Now.ToString("MMM d h:mm tt", new CultureInfo("en-US")),
                CreatedDateTime = DateTimeOffset.UtcNow,
                TheChangingString = "first test string"
            },
            new UnderlyingData (){
                Id = 3,
                CreatedDateTimeString = DateTime.Now.ToString("MMM d h:mm tt", new CultureInfo("en-US")),
                CreatedDateTime = DateTimeOffset.UtcNow,
                TheChangingString = "first test string"
            },
            new UnderlyingData (){
                Id = 4,
                CreatedDateTimeString = DateTime.Now.ToString("MMM d h:mm tt", new CultureInfo("en-US")),
                CreatedDateTime = DateTimeOffset.UtcNow,
                TheChangingString = "first test string"
            }
        };
    }





}



