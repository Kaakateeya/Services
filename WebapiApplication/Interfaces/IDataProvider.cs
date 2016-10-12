using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebapiApplication.ML;

namespace WebapiApplication.Interfaces
{
    public interface IDataProvider
    {
        List<ML.ML> getDataDetails();
    }
    public interface IActivePatientCondition
    {
        List<ActivePatientConditionReport> DisplayMovieList();
    }

    public interface IIActivePatientCondition
    {
        List<ActivePatientReport> GetCodeSetPrograms();
    }

    public interface IuserLogin
    {
        List<userLoginML> DGetLogininformationdetails(CustLoginMl Mobj);
    }

    public interface IDashboardRequest
    {
        DashboardClass GetLandingCountsBal(DashboardRequest Dreq);
        DashboardClass GetPartnerProfilesBal(DashboardRequest Dreq);
    }

    public interface IEmailMobileVerf
    {
        VerifiedContactInformationML DgetMobileEmailVerification(long? CustID);

    }
}


