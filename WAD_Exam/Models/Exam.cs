using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_Exam.Models
{
    public class Exam
    {
        [Key]
        public int  ExamId { get; set; }
        [Required]
        public string ExamSubject { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StartTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExamDate { get; set; }
        [Required]
        public int ExamDuration { get; set; }
        [Required]
        public string Room { get; set; }
        [Required]
        public string Faculty { get; set; }
        public ExamStatus Status { get; set; }

    }

    public enum ExamStatus
    {
        UpComing = 1, OnGoing = 2, Done = 3
    }

}