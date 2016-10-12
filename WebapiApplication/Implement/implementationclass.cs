using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebapiApplication.ML;
using WebapiApplication.Interfaces;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Web.Http;
using WebapiApplication.DAL;

namespace WebapiApplication.Implement
{
    public class webApi : ApiController
    {
        public readonly IIActivePatientCondition condition;
    }

    public class IMP : IIActivePatientCondition
    {
        public List<ActivePatientReport> GetCodeSetPrograms()
        {
            List<ActivePatientReport> movies;
            return movies = new DBconnection().getDALDetails();
        }
    }

    public class ImpUserlogin : IuserLogin
    {

        public List<userLoginML> DGetLogininformationdetails(CustLoginMl Mobj)
        {
            List<userLoginML> userlogin;
            return userlogin = new UserLoginDAL().DGetLogininformationdetails(Mobj);
        }
    }

    public class ImpDashboard : IDashboardRequest
    {
        public DashboardClass GetLandingCountsBal(DashboardRequest Dreq)
        {
            DashboardClass result = new Dashboard().LandingCountsDal(Dreq);
            return result;
        }

        public DashboardClass GetPartnerProfilesBal(DashboardRequest Dreq)
        {
            DashboardClass result = new Dashboard().GetPartnerProfilesDal(Dreq);
            return result;
        }

    }

    public class ImpEmailMobileVerf : IEmailMobileVerf
    {
        public VerifiedContactInformationML DgetMobileEmailVerification(long? CustID)
        {
            VerifiedContactInformationML result = new VerifiedContactInformationDAL().DgetMobileEmailVerification(CustID);
            return result;
        }
    }

}