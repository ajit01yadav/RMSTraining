﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    //using System.Data.Objects;
    //using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class RMS_Entities : DbContext
    {
        public RMS_Entities()
            : base("name=RMS_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<T_InterviewPanel> T_InterviewPanel { get; set; }
        public DbSet<T_IP_PanelLevel> T_IP_PanelLevel { get; set; }
        public DbSet<T_IP_PanelDesignation> T_IP_PanelDesignation { get; set; }
        public DbSet<T_Master> T_Master { get; set; }
        public DbSet<T_EmployeeSkillTypeCategory> T_EmployeeSkillTypeCategory { get; set; }
        public DbSet<T_Departments> T_Departments { get; set; }
        public DbSet<T_DesignationMaster> T_DesignationMaster { get; set; }
        public DbSet<T_Category> T_Category { get; set; }
        public DbSet<T_Technology> T_Technology { get; set; }
        public DbSet<T_Domain> T_Domain { get; set; }
        public DbSet<T_SubDomain> T_SubDomain { get; set; }
    
        public virtual int GetInterviewPanel(Nullable<int> panelId)
        {
            var panelIdParameter = panelId.HasValue ?
                new ObjectParameter("PanelId", panelId) :
                new ObjectParameter("PanelId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetInterviewPanel", panelIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Usp_IP_UpdateIP(Nullable<int> panelId, Nullable<int> empId, Nullable<int> candidateDeptId, string designationIds, string secondarySkillIds, string levelIds, Nullable<int> inducted, Nullable<int> trainingAttended, Nullable<int> createdBy)
        {
            var panelIdParameter = panelId.HasValue ?
                new ObjectParameter("PanelId", panelId) :
                new ObjectParameter("PanelId", typeof(int));
    
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var candidateDeptIdParameter = candidateDeptId.HasValue ?
                new ObjectParameter("CandidateDeptId", candidateDeptId) :
                new ObjectParameter("CandidateDeptId", typeof(int));
    
            var designationIdsParameter = designationIds != null ?
                new ObjectParameter("DesignationIds", designationIds) :
                new ObjectParameter("DesignationIds", typeof(string));
    
            var secondarySkillIdsParameter = secondarySkillIds != null ?
                new ObjectParameter("SecondarySkillIds", secondarySkillIds) :
                new ObjectParameter("SecondarySkillIds", typeof(string));
    
            var levelIdsParameter = levelIds != null ?
                new ObjectParameter("LevelIds", levelIds) :
                new ObjectParameter("LevelIds", typeof(string));
    
            var inductedParameter = inducted.HasValue ?
                new ObjectParameter("Inducted", inducted) :
                new ObjectParameter("Inducted", typeof(int));
    
            var trainingAttendedParameter = trainingAttended.HasValue ?
                new ObjectParameter("TrainingAttended", trainingAttended) :
                new ObjectParameter("TrainingAttended", typeof(int));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Usp_IP_UpdateIP", panelIdParameter, empIdParameter, candidateDeptIdParameter, designationIdsParameter, secondarySkillIdsParameter, levelIdsParameter, inductedParameter, trainingAttendedParameter, createdByParameter);
        }
    
        public virtual ObjectResult<USP_IP_GetInterviewPanelDetail_Result> USP_IP_GetInterviewPanelDetail(Nullable<int> panelId, string type)
        {
            var panelIdParameter = panelId.HasValue ?
                new ObjectParameter("PanelId", panelId) :
                new ObjectParameter("PanelId", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_IP_GetInterviewPanelDetail_Result>("USP_IP_GetInterviewPanelDetail", panelIdParameter, typeParameter);
        }
    
        public virtual ObjectResult<USP_IP_GetEmpSkills_Result> USP_IP_GetEmpSkills(string skillType, Nullable<int> empId)
        {
            var skillTypeParameter = skillType != null ?
                new ObjectParameter("SkillType", skillType) :
                new ObjectParameter("SkillType", typeof(string));
    
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_IP_GetEmpSkills_Result>("USP_IP_GetEmpSkills", skillTypeParameter, empIdParameter);
        }
    
        public virtual ObjectResult<USP_IP_GetInterviewPanel_Result> USP_IP_GetInterviewPanel(Nullable<int> panelId, Nullable<int> empId)
        {
            var panelIdParameter = panelId.HasValue ?
                new ObjectParameter("PanelId", panelId) :
                new ObjectParameter("PanelId", typeof(int));
    
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_IP_GetInterviewPanel_Result>("USP_IP_GetInterviewPanel", panelIdParameter, empIdParameter);
        }
    
        public virtual ObjectResult<USP_IP_GetInterviewPanelSearch_Result> USP_IP_GetInterviewPanelSearch(Nullable<int> technology, Nullable<int> level, Nullable<int> deptId, Nullable<int> designation, Nullable<int> businessVertical, string skill)
        {
            var technologyParameter = technology.HasValue ?
                new ObjectParameter("Technology", technology) :
                new ObjectParameter("Technology", typeof(int));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("Level", level) :
                new ObjectParameter("Level", typeof(int));
    
            var deptIdParameter = deptId.HasValue ?
                new ObjectParameter("DeptId", deptId) :
                new ObjectParameter("DeptId", typeof(int));
    
            var designationParameter = designation.HasValue ?
                new ObjectParameter("Designation", designation) :
                new ObjectParameter("Designation", typeof(int));
    
            var businessVerticalParameter = businessVertical.HasValue ?
                new ObjectParameter("BusinessVertical", businessVertical) :
                new ObjectParameter("BusinessVertical", typeof(int));
    
            var skillParameter = skill != null ?
                new ObjectParameter("Skill", skill) :
                new ObjectParameter("Skill", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_IP_GetInterviewPanelSearch_Result>("USP_IP_GetInterviewPanelSearch", technologyParameter, levelParameter, deptIdParameter, designationParameter, businessVerticalParameter, skillParameter);
        }
    
        public virtual int USP_Report_AvgUtilBillingforGivenPeriod_BB(Nullable<int> start_Day, Nullable<int> start_Month, Nullable<int> start_Year, Nullable<int> end_Day, Nullable<int> end_Month, Nullable<int> end_Year)
        {
            var start_DayParameter = start_Day.HasValue ?
                new ObjectParameter("Start_Day", start_Day) :
                new ObjectParameter("Start_Day", typeof(int));
    
            var start_MonthParameter = start_Month.HasValue ?
                new ObjectParameter("Start_Month", start_Month) :
                new ObjectParameter("Start_Month", typeof(int));
    
            var start_YearParameter = start_Year.HasValue ?
                new ObjectParameter("Start_Year", start_Year) :
                new ObjectParameter("Start_Year", typeof(int));
    
            var end_DayParameter = end_Day.HasValue ?
                new ObjectParameter("End_Day", end_Day) :
                new ObjectParameter("End_Day", typeof(int));
    
            var end_MonthParameter = end_Month.HasValue ?
                new ObjectParameter("End_Month", end_Month) :
                new ObjectParameter("End_Month", typeof(int));
    
            var end_YearParameter = end_Year.HasValue ?
                new ObjectParameter("End_Year", end_Year) :
                new ObjectParameter("End_Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Report_AvgUtilBillingforGivenPeriod_BB", start_DayParameter, start_MonthParameter, start_YearParameter, end_DayParameter, end_MonthParameter, end_YearParameter);
        }
    
        public virtual ObjectResult<USP_GetDomain_SubDomain_Result> USP_GetDomain_SubDomain(Nullable<int> domainId, Nullable<int> subDomainId)
        {
            var domainIdParameter = domainId.HasValue ?
                new ObjectParameter("DomainId", domainId) :
                new ObjectParameter("DomainId", typeof(int));
    
            var subDomainIdParameter = subDomainId.HasValue ?
                new ObjectParameter("SubDomainId", subDomainId) :
                new ObjectParameter("SubDomainId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetDomain_SubDomain_Result>("USP_GetDomain_SubDomain", domainIdParameter, subDomainIdParameter);
        }
    
        public virtual ObjectResult<USP_Employee_BillingTillDate_Result> USP_Employee_BillingTillDate(string flag, Nullable<System.DateTime> billingTillDate, Nullable<int> empId, Nullable<int> epaId)
        {
            var flagParameter = flag != null ?
                new ObjectParameter("Flag", flag) :
                new ObjectParameter("Flag", typeof(string));
    
            var billingTillDateParameter = billingTillDate.HasValue ?
                new ObjectParameter("BillingTillDate", billingTillDate) :
                new ObjectParameter("BillingTillDate", typeof(System.DateTime));
    
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var epaIdParameter = epaId.HasValue ?
                new ObjectParameter("EpaId", epaId) :
                new ObjectParameter("EpaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Employee_BillingTillDate_Result>("USP_Employee_BillingTillDate", flagParameter, billingTillDateParameter, empIdParameter, epaIdParameter);
        }
    }
}
