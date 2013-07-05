using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Documents.DataBase.Struct
{
    /// <summary>
    /// Describe Categories table.
    /// </summary>
    public class Categories
    {
        /// <summary>
        /// Gets or sets id of categories table.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets categories name. 
        /// </summary>
        public string Name { get; set; }
    }
}
