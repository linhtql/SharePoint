using Newtonsoft.Json;
using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Convert
{
    public static class InformationConvert
    {
        public static Information ToInformation(InformationEntity informationEntity)
        {
            var result = new Information();
            {
                result.Id = informationEntity.Id;
                result.Type = (InformationType)informationEntity.Type;
                result.Description = informationEntity.Description;
                result.CreatedDate = informationEntity.CreatedDate;
                result.Title = informationEntity.Title;
                result.ImageUrl = informationEntity.ImageUrl;

                if (!String.IsNullOrEmpty(informationEntity.Extension))
                {
                    Type extensionType = null;
                    switch (result.Type)
                    {
                        case InformationType.Announcement:
                            extensionType = typeof(AnnouncementExtension);
                            break;
                        case InformationType.News:
                            extensionType = typeof(NewsExtension);
                            break;
                    }
                    if (extensionType != null)
                    {

                        result.Extension = JsonConvert.DeserializeObject(informationEntity.Extension, extensionType) as InformationExtension;
                    }


                }

                return result;
            }
        }
        public static InformationEntity ToEntity(Information information)
        {
            var result = new InformationEntity();
            if (String.IsNullOrEmpty(information.Id))
            {
                information.Id = Guid.NewGuid().ToString();
            }

            result.Id = information.Id;
            result.Type = (Int32)information.Type;
            result.ImageUrl = information.ImageUrl;
            result.Title = information.Title;
            result.Description = information.Description;
            result.CreatedDate = information.CreatedDate;
            result.Extension = JsonConvert.SerializeObject(information.Extension,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            return result;
        }
    }
}
