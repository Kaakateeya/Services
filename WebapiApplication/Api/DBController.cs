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
    public class DBController : ApiController
    {
        private readonly IIActivePatientCondition activePateintConditions;
        private readonly IuserLogin IuserLogin;
        public DBController()
            : base()
        {
            this.activePateintConditions = new IMP();
            this.IuserLogin = new ImpUserlogin();
        }

        [HttpGet]
        public List<ActivePatientReport> Timedisplay()
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        public List<ActivePatientReport> GetTimedisplay(int iCount)
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        public string Get(int id)
        {
            return "value";
        }

        public List<ActivePatientReport> GetTime(int id, int SS)
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        public List<ActivePatientReport> GetTime(int id, int SS, int KK)
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        public List<ActivePatientReport> GetTimeUrl([FromUri]int id)
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        public List<ActivePatientReport> GetTime([FromBody]int id)
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        public List<ActivePatientReport> GetTimeObj(person id)
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        //{"name":"Sourav","surname":"Kayal"}
        [HttpPost]
        public List<ActivePatientReport> VVVVVV([FromBody]person id)
        {
            string strName = id.name;
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        [HttpPost]
        public List<userLoginML> userLogin([FromBody]CustLoginMl id)
        {
            return this.IuserLogin.DGetLogininformationdetails(id);
        }
        [HttpPost]
        public List<userLoginML> userLoginurl([FromUri]CustLoginMl id)
        {
            return this.IuserLogin.DGetLogininformationdetails(id);
        }

        [HttpPut]
        public List<ActivePatientReport> VVVVVVPUT([FromBody] person id)
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

        [HttpGet]
        public List<ActivePatientReport> WebApitestingdemo()
        {
            return this.activePateintConditions.GetCodeSetPrograms();
        }

    }
}


