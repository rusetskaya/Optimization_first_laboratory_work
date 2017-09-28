using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class University
    {
        private int _universityId;
        private Faculty[] _faculties;

        public University(int _universityId, Faculty[] _faculties)
        {
            this._universityId = _universityId;
            this._faculties = _faculties;
        }

        public int UniversityId
        {
            get
            {
                return _universityId;
            }

            set
            {
                _universityId = value;
            }
        }

        internal Faculty[] Faculties
        {
            get
            {
                return _faculties;
            }

            set
            {
                _faculties = value;
            }
        }
    }
}
