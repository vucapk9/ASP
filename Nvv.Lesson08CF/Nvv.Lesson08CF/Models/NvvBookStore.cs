using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nvv.Lesson08CF.Models
{
    public class NvvBookStore:DbContext
    {
        public NvvBookStore() : base()
        {

        }
        // tạo các bảng 
        public DbSet<NvvCategory> NvvCategories { get; set; }
        public DbSet<NvvBook> NvvBooks { get; set; }
    }
}