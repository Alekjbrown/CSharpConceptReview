using System.Windows.Forms;

namespace FriendFileForm
{
    class Dog : Animal
    {
        //Field
        private string _name;

        //Constructor
        public Dog(string name)
            : base("Dog")
        {
            _name = name;
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //MakeSound override method
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }
    }
}
