using System;
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

}
