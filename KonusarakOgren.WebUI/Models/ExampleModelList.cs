
using KonusarakOgren.WebUI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.WebUI.Models
{
    public class ExampleModelList
    {
        public List<ExamQuestions> examQuestions { get; set; }
        public List<string> Response { get; set; }
    }
}
