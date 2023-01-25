using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Repository
{
    public interface ISuggesteCourseRepository
    {
        public bool InsertSuggesteCourse(SuggesteCourse suggesteCourse);
        public List<SuggesteCourse> GetSuggesteCourse();
        public bool UpdateSuggesteCourse(SuggesteCourse suggesteCourse);
        public bool DeleteSuggesteCourse(int id);
        public SuggesteCourse GetSuggesteCourse(int id);
    }
}
