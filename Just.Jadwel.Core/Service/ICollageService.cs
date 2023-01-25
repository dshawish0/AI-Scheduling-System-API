using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Service
{
    public interface ICollageService
    {
        public bool InsertCollage(Collage collage);
        public List<Collage> GetCollage();
        public bool UpdateCollage(Collage collage);
        public bool DeleteCollage(int id);
        public Collage GetCollage(int id);
    }
}
