using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Repository
{
    public interface IAcademicPlanRepository
    {
        public bool InsertAcademicPlan(AcademicPlan academicPlan);
        public List<AcademicPlan> GetAcademicPlan();
        public bool UpdateAcademicPlan(AcademicPlan academicPlan);
        public bool DeleteAcademicPlan(int id);
        public AcademicPlan GetAcademicPlan(int id);
    }
}
