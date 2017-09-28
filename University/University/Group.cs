using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Group
    {
        private int _groupId;
        private Student[] _students;

        public Group(int _groupId, Student[] _students)
        {
            this._groupId = _groupId;
            this._students = _students;
        }

        public int GroupId
        {
            get
            {
                return _groupId;
            }

            set
            {
                _groupId = value;
            }
        }

        internal Student[] Students
        {
            get
            {
                return _students;
            }

            set
            {
                _students = value;
            }
        }
    }

}
