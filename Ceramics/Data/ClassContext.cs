using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ceramics.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Ceramics.Data
{
    public class ClassContext : DbContext
    {
        public int Id { get; set; }
        public List<StudentModel> Students { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime Time { get; set; }
    }
}
