using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrumTableProje
{
    public class StoryDetail
    {
        public string Comment { get; set; }
        public string Name { get; set; }
        public string Tittle { get; set; }
        public DateTime AddDateStory { get; set; }
        public List<TaskDetail> TaskList { get; set; }

    }
}
