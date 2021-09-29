using System.Text;

namespace DiskDoisIrmaos.Hypermedia
{
    public class HyperMediaLink
    {
        private string href; // Quando o .Net criar um hyperlink alterar o caracter "/" por "%2f"

        public string Rel { get; set; }
        public string Href
        {
            get
            {
                object _lock = new object();
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("%2F", "/").ToString();
                }
            }
            set
            {
                href = value;
            }
        }
        public string Type { get; set; }
        public string Action { get; set; }
    }
}
