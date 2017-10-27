using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ceramics.Models.DataModels
{
    public class ClassModel
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public List<StudentModel> Students { get; set; }
        public bool IsCancelled { get; set; }
    }
}
