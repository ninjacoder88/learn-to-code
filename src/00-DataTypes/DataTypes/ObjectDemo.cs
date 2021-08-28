namespace DataTypes
{
    public class ObjectDemo
    {
        //create a new class
        public void Demo01()
        {
            Item i = new Item();
        }
    }

    public class Item
    {
        public int Id {get;set;}

        public string Name {get;set;}
    }
}