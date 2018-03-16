﻿using System;
namespace ViewCellButtonSample.Models
{
    //LOCAL-SQLLITE
    public class UnderlyingData
    {
        public int Id { get; set; }
        public string CreatedDateTimeString { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public string TheChangingString { get; set; }
    }

    ////LOCAL-COSMOSDB
    //public class CosmosDBPrayerRequest
    //{
    //    public string Id { get; set; }
    //    public string CreatedDateTimeString { get; set; }

    //    public DateTimeOffset CreatedDateTime { get; set; }

    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string FullName { get; set; }
    //    public string FBProfileUrl { get; set; }
    //    public string PrayerRequestText { get; set; }
    //    public int NumberOfThoughts { get; set; }
    //    public int NumberOfPrayers { get; set; }
    //}
}
