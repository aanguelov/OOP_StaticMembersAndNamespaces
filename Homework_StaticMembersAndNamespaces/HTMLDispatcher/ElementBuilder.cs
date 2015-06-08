using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    class ElementBuilder
    {
        private string name;

        public ElementBuilder(string name)
        {
            this.Name = name;
            this.Attributes = new Dictionary<string, string>();
            this.Content = string.Empty;
        }

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Dictionary<string, string> Attributes { get; set; }

        public string Content { get; set; }

        public void AddAttribute(string attribute, string value)
        {
            this.Attributes.Add(attribute, value);
        }

        public void AddContent(string text)
        {
            this.Content += text;
        }

        public static string operator *(ElementBuilder element, int multiplier)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < multiplier; i++)
            {
                sb.Append(element);
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<{0}", this.Name);
            for (int i = 0; i < this.Attributes.Count; i++)
            {
                sb.AppendFormat(" {0}=\"{1}\"", this.Attributes.ElementAt(i).Key, this.Attributes.ElementAt(i).Value);
            }
            sb.AppendFormat(">{0}<{1}/>",this.Content, this.Name);
            return sb.ToString();
        }
    }
}
