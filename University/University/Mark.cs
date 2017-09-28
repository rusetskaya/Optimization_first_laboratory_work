using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Mark
    {
        private int _subjectId;
        private int _mark;

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

        public int Mark_
        {
            get
            {
                return _mark;
            }

            set
            {
                _mark = value;
            }
        }

        public Mark(int _subjectId, int _mark)
        {
            this.SubjectId = _subjectId;
            this.Mark_ = _mark;
        }
    }
}
