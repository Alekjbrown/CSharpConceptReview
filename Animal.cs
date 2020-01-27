using System.Windows.Forms;

namespace FriendFileForm
{
    class Animal
    {
        //Field
        private string _species;

        //Constructor
        public Animal(string species)
        {
            _species = species;
        }

        //species property
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        //MakeSound method (virtual allows derived class to override)
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrrrr");
        }
    }
}
