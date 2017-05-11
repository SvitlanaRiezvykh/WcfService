using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IBookService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        void DoWork();


        [OperationContract]
        [WebInvoke(Method = "POST",
                UriTemplate = "/api/book/GetAllBooks/",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)
            ]
        List<Book> GetAll();

        [OperationContract]
        [WebInvoke(Method = "POST",
          UriTemplate = "/api/book/addBook/",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)
      ]
        Book AddBook(Book newBook);


        [OperationContract]
        [WebInvoke(Method = "POST",
       UriTemplate = "api/book/GetBook/{id}",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json)
   ]
        Book GetBook(string id);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "api/book/DeleteBook/{idBook}",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)
        ]
        List<Book> DeleteBook(string idBook);


        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "api/book/UpdateBook/",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)
        ]
        Book UpdateBook(Book newBook);

    }
}
