using System.Security.Cryptography.X509Certificates;

namespace TodoApi
{
    public class TodoItem
    {
        public int Id { get; set; }

        public string name { get; set; }

        public bool IsComplete { get; set; }
    }
}
