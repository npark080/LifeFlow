using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeFlow.DATA.EF.Models//.Metadata
{
    internal class Metadata
    {

        public class CourseMetadata
        {

            public int CourseId { get; set; }  //primary key, no metadata

            [Display(Name = "Course Name")]
            [StringLength(50)]
            [Required]
            public string CourseName { get; set; } = null!;

            [Display(Name = "Course Description")]
            public string? CourseDescription { get; set; }

            [Display(Name = "Status")]
            [Required]
            public string CourseStatusId { get; set; } = null!;

            [Display(Name = "Course is Active")]
            [Required]
            public bool IsActive { get; set; }
        }
        public class EnrollmentMetadata
        {

            public int EnrollmentId { get; set; }  //primary key, no metadata

            public int StudentId { get; set; } // foreign key, no metadata

            [Display(Name = "Course Info")]
            public int CourseId { get; set; } //foreign key, no metadata

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Display(Name = "Enrollment Date")]
            [DataType(DataType.Date)]
            [Required]
            public DateTime EnrollmentDate { get; set; }

        }
        public class StudentMetadata
        {

            public int StudentId { get; set; } //primary key, no metadata

            [StringLength(20)]
            [Display(Name = "First Name")]
            [Required]
            public string FirstName { get; set; } = null!;

            [StringLength(20)]
            [Display(Name = "Last Name")]
            [Required]
            public string LastName { get; set; } = null!;

            [StringLength(25)]
            [Display(Name = "City")]
            public string? City { get; set; }

            [StringLength(2)]
            [Display(Name = "State")]
            public string? State { get; set; }

            [Range(1_000_000_000, 9_999_999_999, ErrorMessage = "Must be 10 digits")]
            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Phone Number")]
            public int? Phone { get; set; }

            [StringLength(60)]
            [Display(Name = "Email Address")]
            [Required]
            public string Email { get; set; } = null!;

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Display(Name = "Start Date")]
            [DataType(DataType.Date)]
            [Required]
            public DateTime StartDate { get; set; }

            [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
            [Display(Name = "End Date")]
            [DataType(DataType.Date)]
            [Required]
            public DateTime EndDate { get; set; }

            [Display(Name = "Student Status")]
            public int StudentStatusId { get; set; } //foreign key, no metadata

        }
        public class CourseStatusMetadata
        {
            public int CourseStatusId { get; set; }  //primary key, no metadata

            [StringLength(50)]
            [Display(Name = "Status")]
            [Required]
            public string CourseStatusName { get; set; } = null!;
        }
        public class StudentStatusMetadata
        {

            public int StudentStatusId { get; set; }  //primary key, no metadata

            [StringLength(30)]
            [Display(Name = "Student Status")]
            [Required]
            public string StudentStatusName { get; set; } = null!;

            [StringLength(250)]
            [Display(Name = "Description")]
            public string? StudentStatusDescription { get; set; }
        }

    }


}

