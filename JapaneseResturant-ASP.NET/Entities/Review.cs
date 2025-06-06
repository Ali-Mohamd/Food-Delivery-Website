﻿namespace JapaneseRestaurantModel.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DishId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Dish Dish { get; set; } = null!; // required
        public User User { get; set; } = null!; // required
    }
}
