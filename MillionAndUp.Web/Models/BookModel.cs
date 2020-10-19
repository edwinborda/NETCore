using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillionAndUp.Web.Models
{
    public class BookModel
    {
        /// <summary>
        /// Book Key 
        /// </summary>
        public int ISBN { get; set; }

        /// <summary>
        /// Book's name
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Book's Sypnosis
        /// </summary>
        public string Sypnosis { get; set; }

        /// <summary>
        /// Book's number pages
        /// </summary>
        public string NumberPages { get; set; }

        /// <summary>
        /// Book's authors
        /// </summary>
        public List<AuthorModel> Authors { get; set; }

        /// <summary>
        /// Book's editorial
        /// </summary>
        public EditorialModel Editorial { get; set; }
    }
}
