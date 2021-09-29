namespace LessonsInLinq
{
    public class SalesOrder
    {
        public int Id {get;set;}
        public string CustomerName {get;set;}
        public decimal Total {get;set;}

        public override string ToString()
        {
            return $"Id: {Id}; Customer: {CustomerName}; Order Total: ${Total}";
        }
    }
}