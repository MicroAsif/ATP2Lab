﻿using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DoctorConsult.Core.Entity.Model
{
    public class PatientsProblemPageForDoctorModel
    {
        [Required]
        public string ProblemSummary { get; set; }
        [Required]
        public string ProblemDetails { get; set; }
        public HttpPostedFileBase FilePath { get; set; }
        public HttpPostedFileBase PreviousProblemReportFile { get; set; }
    }
}
