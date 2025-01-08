using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession02OOP.question01
{
    internal struct Person
    {
        #region Attributes
        string[] names;
        long[] ages;
        int size;
        public int Size
        {
            get { return size; }
        }

        #endregion
        #region Constructor 
        public Person(int _size)
        {
            size = _size;
            names = new string[size];
            ages = new long[size];
        }
        #endregion
        #region Methods 
        public void AddPerson(uint position, string Name, int Age)
        {
            if (Name is not null && ages is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (position < size)
                    {
                        names[position] = Name;
                        ages[position] = Age;
                    }
                }
            }
        }
        #endregion
        #region Indexer
        public long this[string Name]
        {
            get
            {
                if (names is not null && ages is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            return ages[i];
                    }
                }
                return -1;
            }

            set
            {
                if (names is not null && ages is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            ages[i] = value;

                        break;
                    }
                }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"Pos:{index} Name {names[index]}, Age {ages[index]}";
            }
        }
        #endregion
    }
}
