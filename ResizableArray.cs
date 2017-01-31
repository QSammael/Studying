namespace ConsoleApplication6
{
    class ResizableArray
    {
        public class Iterator
        {
            public string GetCurrent()
            {
                return sourceArray.GetElement(currentIndex);
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex != sourceArray.GetLength();
//                if (currentIndex == sourceArray.GetLength()) same as previous 
//                {
//                    return false;
//                }
//                return true;
            }

            public Iterator(ResizableArray source)
            {
                sourceArray = source;
                currentIndex = 0;
            }

            private ResizableArray sourceArray;
            private int currentIndex;

        }

        public Iterator GetIterator()
        {
            return new Iterator(this);
        }
        static string[] Copy(string[] source)
        {
            string[] temporary = new string[source.Length * 2];
            int k = 0;
            while (k < source.Length)
            {
                temporary[k] = source[k];
                k = k + 1;
            }
            return temporary;
        }
        public void Add(string element)
        {
            if (length == data.Length)
            {
                data = Copy(data);
            }
            data[length] = element;
            length = length + 1;
        }

        public void Remove(int elementNumber)
        {
            while (elementNumber < length - 1)
            {
                data[elementNumber] = data[elementNumber + 1];
                elementNumber = elementNumber + 1;

            }
            length = length - 1;
        }

        //        public void Insert(int elementNumber, string extra)
        //        {
        //            Add(extra);
        //            while ()
        //                data[elementNumber] = extra;
        //        }
        public int GetLength()
        {
            return length;
        }

        public string GetElement(int elementNumber)
        {
            return data[elementNumber];
        }

        private string[] data = new string[10];
        private int length = 0;
    }
}