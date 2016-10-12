using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebapiApplication.ML
{
    public class userLoginML
    {
        public Int64 CustID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReligionName { get; set; }
        public string CasteName { get; set; }
        public int CasteID { get; set; }
        public string MotherTongueName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderID { get; set; }
        public string Email { get; set; }
        public int MotherTongueID { get; set; }
        public int ReligionID { get; set; }
        public string ProfileID { get; set; }
        public string VerificationCode { get; set; }
        public Int64 FamilyID { get; set; }
        public int PaidStatus { get; set; }
        public string PartnerCastedata { get; set; }
        public int PhotoStatus { get; set; }
        public int PhotoCount { get; set; }
        public bool ViewProfileFlag { get; set; }
        public int ResigNophotoFlgPaid { get; set; }
        public int SuccessStoryFlag { get; set; }
        public int Emailverified { get; set; }
        public string strProfileID { get; set; }
        public Int64 Flag { get; set; }

        //MObile Verf
        public Int64 cust_emailid { set; get; }
        public string email { set; get; }
        public bool isemailverified { set; get; }
        public Int64 cust_contant_id { set; get; }
        public string number { set; get; }
        public bool isnumberverifed { set; get; }
        public string MObileverficationcode { get; set; }
    }
    public class CustLoginMl
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string StrHtmlText { get; set; }
        public Int64 CustID { get; set; }
        public string StrCustID { get; set; }

        public int? iflag { get; set; }
    }


}