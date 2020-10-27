
using KonusarakOgren.WebUI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.WebUI.Models
{
    public class ExamProperty
    {
        public string makaletitle { get; set; }

        public List<string> MakaleContext { get; set; }
        public List<ExamQuestions> ExamQuestions { get; set; }
    }
}
