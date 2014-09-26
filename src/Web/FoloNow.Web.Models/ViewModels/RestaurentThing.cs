using System;

namespace FoloNow.Web.Models.ViewModels
{
    public sealed class RestaurentThing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }
        public string ImageNormal { get; set; }
        public string ImageSmall { get; set; }
        public string Status { get; set; }
        public string WaitingTime { get; set; }
        public DateTime HappyHours { get; set; }
        public double Longitude { get; set; }
        public double Lattitude { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string CreatedBy { get; set; }
        public string LiveOffer { get; set; }
        public string FacebookId { get; set; }
        public string TweeterId { get; set; }
        public string AttendingCount { get; set; }
    }
}
