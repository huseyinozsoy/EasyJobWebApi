using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Advertisement 
    {
        public int Id { get; set; }
        public string AdvertisementTitle { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public string JobDescription { get; set; }
    }
}
