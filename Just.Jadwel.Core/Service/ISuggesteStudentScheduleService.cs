using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Service
{
    public interface ISuggesteStudentScheduleService
    {
        public bool InsertSuggesteStudentSchedule(SuggesteStudentSchedule suggesteStudentSchedule);
        public List<SuggesteStudentSchedule> GetSuggesteStudentSchedule();
        public bool UpdateSuggesteStudentSchedule(SuggesteStudentSchedule suggesteStudentSchedule);
        public bool DeleteSuggesteStudentSchedule(int id);
        public SuggesteStudentSchedule GetSuggesteStudentSchedule(int id);
    }
}
