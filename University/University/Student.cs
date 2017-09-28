using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student
    {
        private int _studentId;
        private Subject[] _studiedSubjects;
        private Mark[] _marks;

        public Student(int _studentId, Subject[] _studiedSubjects, Mark[] _marks)
        {
            this._studentId = _studentId;
            this._studiedSubjects = _studiedSubjects;
            this._marks = _marks;
        }

        public int StudentId
        {
            get
            {
                return _studentId;
            }

            set
            {
                _studentId = value;
            }
        }

        internal Subject[] StudiedSubjects
        {
            get
            {
                return _studiedSubjects;
            }

            set
            {
                _studiedSubjects = value;
            }
        }

        internal Mark[] Marks
        {
            get
            {
                return _marks;
            }

            set
            {
                _marks = value;
            }
        }
    }
}
