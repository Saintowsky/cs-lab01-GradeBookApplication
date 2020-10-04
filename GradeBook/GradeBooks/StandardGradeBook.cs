using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//This should set Type to GradeBookType.Standard.
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}
