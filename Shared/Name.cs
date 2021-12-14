using System;

namespace stregsystem.Shared
{
    public class Name
    {
        public string String
        {
            get { return _string; }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException("A name can't be null");
                _string = value;
            }
        }

        private string _string = "nil";

        public Name(string name)
        {
            String = name;
        }
    }
}