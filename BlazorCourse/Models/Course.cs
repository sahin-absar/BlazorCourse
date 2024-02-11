namespace BlazorCourse.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseDuration { get; set; }
        public string CoursePrice { get; set; }
        public CourseCategory CourseCategory { get; set; }
    }
}
