using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Documents.DataBase.Struct
{
    /// <summary>
    /// Describe document type.
    /// </summary>
    public class DocumentType
    {
        /// <summary>
        /// Gets or sets id of document type table.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Document type.
        /// </summary>
        public string DocumentType { get; set; }
    }
}
