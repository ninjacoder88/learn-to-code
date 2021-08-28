namespace DataStructures
{
    public class ArrayDemo
    {
        //initialize and populate an array
        public void Demo01()
        {
            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            array.Dump();
        }

        //create an array of a different type and size
        public void Demo02()
        {
            string[] array = new string[5];
            array[0] = "A";
            array[1] = "B";
            array[2] = "C";
            array[3] = "D";
            array[4] = "E";

            array.Dump();
        }

        //introduce initialize syntax
        public void Demo03()
        {
            int[] array = new int[]{2,4,6,7};

            array.Dump();
        }

        //get values from the array
        public void Demo04()
        {
            string[] array = new string[5];
            array[0] = "A";
            array[1] = "B";
            array[2] = "C";
            array[3] = "D";
            array[4] = "E";

            array[2].Dump();
        }
    }
}