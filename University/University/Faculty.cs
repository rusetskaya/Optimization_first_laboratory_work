using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Faculty
    {
        private int _facultyId;
        private Group[] _groups;

        public Faculty(int _facultyId, Group[] _groups)
        {
            this.FacultyId = _facultyId;
            this.Groups = _groups;
        }

        public int FacultyId
        {
            get
            {
                return _facultyId;
            }

            set
            {
                _facultyId = value;
            }
        }

        internal Group[] Groups
        {
            get
            {
                return _groups;
            }

            set
            {
                _groups = value;
            }
        }
    }
}
