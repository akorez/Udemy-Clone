using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Shared.Messages
{
    public class BasketCourseNameChangeEvent
    {
        public string UserId { get; set; }
        public string CourseId { get; set; }
        public string UpdatedName { get; set; }
    }
}
