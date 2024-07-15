namespace Crud.Api.Models
{
    public class Book
    {
        public Guid Id { get; init; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }

        public Book( string title, string description, string author)
        {
            Title = title;
            Description = description;
            Author = author;
        }
        public Book() { }

        public void UpdateBook(string title, string desc, string author) 
        {
            Title = title;
            Description = desc;
            Author = author;
        }
        
    }
}
