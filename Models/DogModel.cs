using System;
using System.ComponentModel;

namespace Dogs.Models
{
    public class DogModel : Model
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public DogModel()
        {
        }
    }
}
