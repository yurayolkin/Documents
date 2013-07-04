using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Documents.DataBase.Struct
{
    /// <summary>
    /// Decsribe document table.
    /// </summary>
    public class Documents
    {
        /// <summary>
        /// Gets or sets id document.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of document.
        /// </summary>
        public string Name {get; set;}

        /// <summary>
        /// Gets or sets number document.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets DateTime when document is published.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets full file name of document. 
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets extension of file name document. Example ".doc".
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets binary data for documents.
        /// </summary>
        public byte[] BlobData { get; set; }

        /// <summary>
        /// Gets or sets relation to categories table.
        /// </summary>
        public Categories IdCategories { get; set; }

        /// <summary>
        /// Gets or sets relation to documents table.
        /// </summary>
        public TypeDocument IdDocumentType { get; set; }

        /// <summary>
        /// Gets or sets relation to author table.
        /// </summary>
        public Author IdAuthor { get; set; }

        /// <summary>
        /// Gets or sets execute count documents.
        /// </summary>
        public int CountStart { get; set; }
    }
}
