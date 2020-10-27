using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace KonusarakOgren.Domain.Models
{
    public class ExamQuestions
    {  
        [Key]
        public int Id { get; set; }
        public string Question{ get; set; }
        public string Response { get; set; }

        public string A_option { get; set; }
        public string B_option { get; set; }
        public string C_Option { get; set; }
        public string D_option { get; set; }


    }
}
