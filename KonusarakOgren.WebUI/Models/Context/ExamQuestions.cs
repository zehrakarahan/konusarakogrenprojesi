using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.WebUI.Models.Context
{
    public class ExamQuestions
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }

        public string Aoption { get; set; }
        public string Boption { get; set; }
        public string Coption { get; set; }
        public string Doption { get; set; }
    }
}
