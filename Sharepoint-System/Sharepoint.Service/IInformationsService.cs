using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Service
{
    public interface IInformationsService
    {
        Task<Boolean> Add(List<Information> informations);
        Task<List<Information>> GetAllByType(InformationType type);
        Task<Boolean> Delete(String id);
        Task<Information> GetById(String id);
        Task<Boolean> Update(Information information);

    }
}
