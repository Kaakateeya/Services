using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebapiApplication.ML;
using WebapiApplication.Implement;
using WebapiApplication.Interfaces;

namespace WebapiApplication.Api
{
    public class DashboardRequestController : ApiController
    {
        private readonly IDashboardRequest IDashboardRequest;
        public DashboardRequestController()
            : base()
        {
            this.IDashboardRequest = new ImpDashboard();
        }
        [HttpPost]
        public DashboardClass DashboardRequest([FromBody]DashboardRequest id)
        {
            return this.IDashboardRequest.GetLandingCountsBal(id);
        }

        [HttpGet]
        public DashboardClass DashboardRequestget([FromUri]int id, [FromUri]string TypeOfReport, [FromUri]int pagefrom, [FromUri]int pageto)
        {
            DashboardRequest Dsr = new DashboardRequest();
            Dsr.IntCustID = id;
            Dsr.TypeOfReport = TypeOfReport;
            Dsr.pagefrom = pagefrom;
            Dsr.pageto = pageto;
            return this.IDashboardRequest.GetLandingCountsBal(Dsr);
        }
        [HttpGet]
        public DashboardClass DashboardGetPartnerProfilesRequestget([FromUri]int id, [FromUri]string TypeOfReport, [FromUri]int pagefrom, [FromUri]int pageto)
        {
            DashboardRequest Dsr = new DashboardRequest();
            Dsr.IntCustID = id;
            Dsr.TypeOfReport = TypeOfReport;
            Dsr.pagefrom = pagefrom;
            Dsr.pageto = pageto;
            return this.IDashboardRequest.GetPartnerProfilesBal(Dsr);
        }
    }
}