
using KonusarakOgren.WebUI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.WebUI.Models
{
    public class ExamRequiredModel
    {
        public List<ExamQuestions> ExamQuestions { get; set; }
        public string makaletitle { get; set; }
        public List<string> Makalecontent { get; set; }

        public List<string> Usercevap { get; set; }


    }
}
