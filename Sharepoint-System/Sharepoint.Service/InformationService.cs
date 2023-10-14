using Sharepoint.Dao;
using Sharepoint.Data.Model;

namespace Sharepoint.Service
{
    public class InformationService : IInformationsService
    {
        private readonly InformationDAO informationDAO;
        public InformationService(InformationDAO informationDAO)
        {
            this.informationDAO = informationDAO;
        }

        public async Task<bool> Add(List<Information> informations)
        {
            var result = await informationDAO.AddInformation(informations);
            return result;
        }

        public async Task<bool> Delete(string id)
        {
            var result = await informationDAO.Delete(id);
            return result;
        }

        public async Task<List<Information>> GetAllByType(InformationType type)
        {
            var result = await informationDAO.FindAllByType(type);
            return result;
        }

        public async Task<Information> GetById(string id)
        {
            var result = await informationDAO.FindById(id);
            return result;
        }

        public async Task<Boolean> Update(Information information)
        {
            var result = await informationDAO.Update(information);
            return result;
        }
    }
}
