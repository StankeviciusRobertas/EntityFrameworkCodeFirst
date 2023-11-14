namespace EntityFrameworkCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new BookContext();

            // INSERT:
            //var page = new Page(1, "Puslapio turinys");
            //dbContext.Pages.Add(page);
            //dbContext.SaveChanges();

            // DELETE:
            //var page = new Page(new Guid("67A82C3D-0C09-4D9E-8DFD-3FCE200A3A2B"));
            //dbContext.Pages.Remove(page);
            //dbContext.SaveChanges();

            // SELECT:
            //var page = dbContext.Pages.FirstOrDefault();
            //var page = dbContext.Pages.Where(p => p.Number == 2);

            // UPDATE:
            //var page = dbContext.Pages.First(p=>p.Id == Guid.Parse("B8C3B3B5-BEC4-484A-B8F5-3314DD5791C1"));
            //page.Content += ". Added new content.";
            //dbContext.SaveChanges();

            // SUKURIAM KNYGA SU PAVADINIMU IR PRIDEDAM PUSLAPIUS
            //var book = new Book("Harry Potter");
            //for(int i = 0; i < 565; i++)
            //{
            //    book.Pages.Add(new Page(i, $"Content - {i}"));
            //}

            //dbContext.Books.Add(book);
            //dbContext.SaveChanges();

            // ISTRINAM KNYGA IR PUSLAPIUS PAGAL KNYGOS ID
            var book = dbContext.Books.FirstOrDefault(b => b.Id == new Guid("5C124769-93C9-4E4F-B292-341BCF1E2A1B"));
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
        }
    }
}