using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuts__Mobile_Service_Demo
{
    public class ToDoItem
    {
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }

        public ToDoItem()
        {
            
        }

        public ToDoItem(string text, bool status = false)
        {
            Text = text;
            Complete = status;
        }
    }
}
