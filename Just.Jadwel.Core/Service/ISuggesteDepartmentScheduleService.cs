using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Service
{
    public interface ISuggesteDepartmentScheduleService
    {
        public bool InsertSuggesteDepartmentSchedule(SuggesteDepartmentSchedule suggesteDepartmentSchedule);
        public List<SuggesteDepartmentSchedule> GetSuggesteDepartmentSchedule();
        public bool UpdateSuggesteDepartmentSchedule(SuggesteDepartmentSchedule suggesteDepartmentSchedule);
        public bool DeleteSuggesteDepartmentSchedule(int id);
        public SuggesteDepartmentSchedule GetSuggesteDepartmentSchedule(int id);
    }
}
