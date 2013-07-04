using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace Documents.DataBase.Struct
{
    public class DocumentsDbContext : DbContext
    {
        public DbSet<Categories> CategoriesTable { get; set; }

        public DbSet<Author> AuthorTable { get; set; }

        public DbSet<TypeDocument> TypeDocumentTable { get; set; }

        public DbSet<Documents> DocumentsTable {get; set;}
    }
}
