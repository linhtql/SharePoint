using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Convert
{
    public static class QAConvert
    {
        public static QA ToQA(QAEntity entity)
        {
            var result = new QA();
            result.Id = entity.Id;
            result.Question = entity.Question;
            result.Answer = entity.Answer;

            return result;
        }

        public static QAEntity ToEntity(QA qa) {
            var result = new QAEntity();
            if (String.IsNullOrEmpty(qa.Id))
            {
                qa.Id = Guid.NewGuid().ToString();
            }
            result.Id = qa.Id;
            result.Question = qa.Question;
            result.Answer = qa.Answer;

            return result;
        }
    }
}
