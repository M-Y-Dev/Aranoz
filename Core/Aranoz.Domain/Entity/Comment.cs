using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class Comment
    {        
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public string CommentContent { get; set; }
        public bool Status { get; set; }
    }
}
