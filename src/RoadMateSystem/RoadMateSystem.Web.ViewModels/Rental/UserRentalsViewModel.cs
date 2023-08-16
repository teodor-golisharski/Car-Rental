﻿namespace RoadMateSystem.Web.ViewModels.Rental
{
    using RoadMateSystem.Web.ViewModels.Car;
    using System.ComponentModel.DataAnnotations;

    public class UserRentalsViewModel
    {
        public Guid RentalId { get; set; }
        public string UserId { get; set; } = null!;
        public int CarId { get; set; }
        public CarUserRentalsViewModel? Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost { get; set; }
        public bool isPaid { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}