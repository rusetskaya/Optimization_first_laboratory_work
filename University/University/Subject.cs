using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Subject
    {
        private int _subjectId;
        private String _name;

        public Subject(int _subjectId, string _name)
        {
            this._subjectId = _subjectId;
            this._name = _name;
        }

        public int SubjectId
        {
            get
            {
                return _subjectId;
            }

            set
            {
                _subjectId = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
