using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelingWeb.Shared.Entities
{
    public class Tweet
    {
        public int Id { get; set; }



        public bool IsActive { get; set; } = false;



        [MaxLength(50)]
        public string TweetId { get; set; } = null!;



        [MaxLength(10)]
        public string Weekday { get; set; } = null!;



        [MaxLength(10)]
        public string Language { get; set; } = null!;

        public int Likes { get; set; }
        public string Content { get; set; } = null!;



        [MaxLength(100)]
        public string UserId { get; set; } = null!;
    }
}
