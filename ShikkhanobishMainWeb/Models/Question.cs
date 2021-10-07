using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShikkhanobishMainWeb.Models
{
    public class Question
    {
        public string questionID { get; set; }
        public int classID { get; set; }
        public int subjectID { get; set; }
        public int chapterID { get; set; }
        public int topicID { get; set; }
        public string mainQuestion { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public int rightAnswer { get; set; }
        public string review { get; set; }
        public int quesImages { get; set; }
        public string Response { get; set; }
    }
}
