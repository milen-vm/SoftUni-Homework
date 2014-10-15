namespace StringDisperser
{
    using System;
    using System.Collections;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string[] strings;

        public StringDisperser(params string[] strings)
        {
            this.Strings = strings;
        }

        public string[] Strings
        { 
            get
            {
                return this.strings;
            }

            set
            {
                this.strings = value;
            }
        }

        public override string ToString()
        {
            string result = string.Join("", this.strings);

            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            StringDisperser other = obj as StringDisperser;
            if ((Object)other == null)
            {
                return false;
            }

            bool isEqual = this.ToString().Equals(other.ToString());

            return isEqual;
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            foreach (var str in strings)
            {
                hashCode ^= str.GetHashCode();
            }

            return hashCode;
        }

        public static bool operator ==(StringDisperser stringDispA, StringDisperser stringDispB)
        {
            if (ReferenceEquals(stringDispA, stringDispB))
            {
                return true;
            }

            if (((object)stringDispA == null) || ((object)stringDispB == null))
            {
                return false;
            }

            bool isEqual = stringDispA.Equals(stringDispB);

            return isEqual;
        }

        public static bool operator !=(StringDisperser stringDispA, StringDisperser stringDispB)
        {
            bool isDifferent = !(stringDispA == stringDispB);

            return isDifferent;
        }

        public object Clone()
        {
            int length = this.strings.Length;
            string[] clonedStrings = new string[length];

            for (int i = 0; i < length; i++)
            {
                clonedStrings[i] = (string)this.strings[i].Clone();
            }

            object cloned = new StringDisperser(clonedStrings);

            return cloned;
        }

        public int CompareTo(StringDisperser other)
        {
            var result = this.ToString().CompareTo(other.ToString());

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var str = this.ToString();
            int length = str.Length;
            for (var i = 0; i < length; i++)
            {
                yield return str[i];
            }
        }
    }
}
