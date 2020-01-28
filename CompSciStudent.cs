using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFileForm
{
    class CompSciStudent : Student
    {
        //Constants
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        //Fields
        private string _acedemicTrack;

        //Constructor
        public CompSciStudent(string name, string id, string track)
            : base(name, id)
        {
            _acedemicTrack = track;
        }

        //AcedemicTrack property
        public string AcedemicTrack
        {
            get { return _acedemicTrack; }
            set { _acedemicTrack = value; }
        }

        //RequiredHours property overrides abstract base method using constants in this derived class
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
}
