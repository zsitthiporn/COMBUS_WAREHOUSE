﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EF : DbContext
    {
        public EF()
            : base("name=EF")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Main_CheckLogin_Result> Main_CheckLogin(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Main_CheckLogin_Result>("Main_CheckLogin", userNameParameter);
        }
    
        public virtual ObjectResult<Main_Get_TransectionError_Result> Main_Get_TransectionError(Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo)
        {
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Main_Get_TransectionError_Result>("Main_Get_TransectionError", dateFromParameter, dateToParameter);
        }
    
        public virtual int Main_Log_TransectionError(string errorName, string screenName, string userName)
        {
            var errorNameParameter = errorName != null ?
                new ObjectParameter("ErrorName", errorName) :
                new ObjectParameter("ErrorName", typeof(string));
    
            var screenNameParameter = screenName != null ?
                new ObjectParameter("ScreenName", screenName) :
                new ObjectParameter("ScreenName", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Main_Log_TransectionError", errorNameParameter, screenNameParameter, userNameParameter);
        }
    
        public virtual ObjectResult<Company_GetCompany_Result> Company_GetCompany(string companyName)
        {
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Company_GetCompany_Result>("Company_GetCompany", companyNameParameter);
        }
    }
}
