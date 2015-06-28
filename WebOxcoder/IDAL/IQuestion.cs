﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

using System.Threading.Tasks;

namespace IDAL
{
    public interface IQuestion
    {
        bool addQuestion(question questionItem);
        IList<question> getQuestionAll();
        IList<question> searchQuestion(String name);
        bool deleteQuestion(question questionItem);
        bool modifyQuestion(question questionItem);
        question getQuestionByID(int questionID);
     }
}
