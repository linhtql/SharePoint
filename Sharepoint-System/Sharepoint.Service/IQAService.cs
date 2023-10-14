using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Service
{
    public interface IQAService
    {
        Task<Boolean> Add(List<QA> qas);
        Task<Boolean> Delete(String Id);
        Task<Boolean> Update(QA qa);
        Task<QA> GetById(String id);
        Task<List<QA>> GetAll();

    }
}
