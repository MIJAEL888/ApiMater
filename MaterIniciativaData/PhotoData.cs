using MaterIniciativaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterIniciativaData
{
    public class PhotoData
    {
        public List<Photo> List(int idPlant)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<Photo> photos = new List<Photo>();
                var list = dc.PhotoList(idPlant);
                foreach (var tmp in list)
                {
                    var photo = new Photo()
                    {
                        IdPhoto = tmp.IdPhoto,
                        IdPlant = tmp.IdPlant,
                        Type = tmp.Type,
                        Name = tmp.Name,
                        Data = (tmp.Data == null) ? null : tmp.Data.ToArray(),
                        Path = tmp.Path
                    };
                    photos.Add(photo);
                }
                return photos;
            }
        }

        public int Save(Photo photo)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                int? insertedId = 0;
                dc.PhotoUpdate(photo.IdPhoto, photo.IdPlant, photo.Type, photo.Name, photo.Data, photo.Path, ref insertedId);
                return insertedId.GetValueOrDefault();
            }
        }
    }
}
