using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Documents.DataBase.Struct
{
    /// <summary>
    /// Describe document type.
    /// </summary>
    public class TypeDocument
    {
        /// <summary>
        /// Gets or sets id of document type table.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Document type.
        /// </summary>
        public string DocumentType { get; set; }
    }
}
