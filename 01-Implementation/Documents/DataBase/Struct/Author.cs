using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Documents.DataBase.Struct
{
    /// <summary>
    /// Describe Author table.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Gets or sets id of author table.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets author name.
        /// </summary>
        public string AuthorName { get; set; }
    }
}
