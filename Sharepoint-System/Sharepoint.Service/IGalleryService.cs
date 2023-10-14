using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Service
{
    public interface IGalleryService
    {
        Task<Boolean> Add(List<Gallery> galleries);
        Task<Boolean> Delete(String Id);
        Task<Boolean> Update(Gallery gallery);
        Task<Gallery> GetById(String id);
        Task<List<Gallery>> GetAll(GalleryType type);
    }
}
