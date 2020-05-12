using System;
namespace ChainOfResponsibility.After
{
    public class DatabaseOperationStudentsMain
    {
        public DatabaseOperationStudentsMain()
        {
            //student database SQL command / query chain

            StudentsChain sc = new StudentsChain();

            // student row select rows request

            sc.processRequest(new Request('SELECT'));

            // student row update

            sc.processRequest(new Request('UPDATE'));

            // student row delete request

            sc.processRequest(new Request('DELETE'));

            // student row INSERT REQUEST

            sc.processRequest(new Request('INSERT'));
        }
    }
}
