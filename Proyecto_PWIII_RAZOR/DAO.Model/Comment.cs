using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Comment
    {
        public byte CommentID { get; set; }
        public string Description { get; set; }
        public string CommentType { get; set; }
        public string StudentName { get; set; }

        public Comment()
        {

        }
        public Comment(byte commentID, string description, string commentType, string studentName)
        {
            CommentID = commentID;
            Description = description;
            CommentType = commentType;
            StudentName = studentName;
        }
        public Comment(byte commentID)
        {
            CommentID = commentID;
        }
    }
}
