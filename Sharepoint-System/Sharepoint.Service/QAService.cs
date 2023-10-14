using Sharepoint.Dao;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Service
{
    public class QAService : IQAService
    {
        private readonly QADAO qADAO;

        public QAService(QADAO qADAO)
        {
            this.qADAO = qADAO;
        }
        public async Task<bool> Add(List<QA> qas)
        {
            var result = await qADAO.AddQas(qas);
            return result;
        }

        public async Task<bool> Delete(string Id)
        {
            var result = await qADAO.Delete(Id);
            return result;
        }

        public async Task<List<QA>> GetAll()
        {
            var result = await qADAO.FindAll();
            return result;
        }

        public async Task<QA> GetById(string id)
        {
            var result = await qADAO.FindById(id);
            return result;
        }

        public async Task<bool> Update(QA qa)
        {
            var result = await qADAO.Update(qa);
            return result;
        }
    }
}
