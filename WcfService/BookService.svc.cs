using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "BookService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez BookService.svc ou BookService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class BookService : IBookService
    {
        public void DoWork()
        {
        }

        public List<Book> GetAll()
        {
            return new BookManager().GetAllBooks();
        }

        public Book AddBook(Book newBook)
        {
            return new BookManager().AddBook(newBook);
        }

        public Book GetBook(string id)
        {

            return new BookManager().GetBook(Int32.Parse(id));

        }

        public List<Book> DeleteBook(string idBook)
        {
            return new BookManager().DeleteBook(Int32.Parse(idBook));
        }

        public Book UpdateBook(Book newBook)
        {
            return new BookManager().UpdateBook(newBook);
        }
    }
}
