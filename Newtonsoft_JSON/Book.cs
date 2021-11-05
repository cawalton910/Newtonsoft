using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft_JSON
{
    class Book
    {
        public string id { get; set; }
        public volumeInfo volumeInfo { get; set; }
        public string selfLink { get; set; }

        public override string ToString()
        {
            string authors = string.Join(",", volumeInfo.authors);
            return $"Id: {id}\nSelfLink: {selfLink}\nTitle: {volumeInfo.title}\nDescription: {volumeInfo.description}\nAuthors: {authors}\n";
        }
    }
}
