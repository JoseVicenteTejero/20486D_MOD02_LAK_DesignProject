using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignProject
{
    public class Photo
    {
        public int PhotoId
        {
            get => default;
            set
            {
            }
        }

        public String Title
        {
            get => default(string);
            set
            {
            }
        }

        public byte PhotoFile
        {
            get => default(byte);
            set
            {
            }
        }

        public String Description
        {
            get => default(string);
            set
            {
            }
        }

        public DateTime CreateData
        {
            get => default(System.DateTime);
            set
            {
            }
        }

        public int Owner
        {
            get => default(string);
            set
            {
            }
        }

        public List<Comment> PhotoComments
        {
            get => default(List<Comment>);
            set
            {
            }
        }

        public Comment PhotoComment
        {
            get => default;
            set
            {
            }
        }
    }
}