﻿using System;
namespace ChainOfResponsibility.After
{
    public class InsertStudentsProcessor: StudentDataProcessor
    {
        public InsertStudentsProcessor(StudentDataProcessor studentDataProcessor)
        {
            super(studentDataProcessor);
        }

        public InsertStudentsProcessor processDataInsert(Request request)
        {
            if (request.getRequest().Contains('INSERT'))
            {
                // process insert SQL query into databse 

                return 'INSERT INTO STUDENT_DATABASE(STUDENT_ID, STUDENT_NAME)VALUES(1, ROBERT HALL)';
            }
        }
    }
}
