﻿using System.Collections.Generic;

namespace Aplikasi_Hotel
{
    public class ReviewKamar<T>
    {
        public T RoomNumber { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }

    public class HotelReviewSystem<T>
    {
        private List<ReviewKamar<T>> reviews;

        public HotelReviewSystem()
        {
            reviews = new List<ReviewKamar<T>>();
        }

        public void AddReview(ReviewKamar<T> review)
        {
            reviews.Add(review);
        }

        public List<ReviewKamar<T>> GetReviews()
        {
            return reviews;
        }
    }
}