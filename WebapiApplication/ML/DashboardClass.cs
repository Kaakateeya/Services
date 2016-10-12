﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebapiApplication.ML
{
    public class DashboardClass
    {
        public List<PartnerProfilesLatest> PartnerProfilesnew { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public LandingPartnerMenu DashBoardCounts { get; set; }

    }

    public class PartnerProfilesLatest
    {
        public int? Row { get; set; }
        public string TableName { get; set; }
        public string ProfileID { get; set; }
        public Int64? Cust_ID { get; set; }
        public string NAME { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string Height { get; set; }
        public string ReligionName { get; set; }
        public string Caste { get; set; }
        public string Education { get; set; }
        public string EducationGroup { get; set; }
        public string profession { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Star { get; set; }
        public string placeofbirth { get; set; }
        public string Location { get; set; }
        public bool? IsprofileMarked { get; set; }
        public string HoroscopeImage { get; set; }
        public bool? IsExpressIntrestMarked { get; set; }
        public bool? IsIntrested { get; set; }
        public int? PhotosCount { get; set; }
        public string Photoname { get; set; }
        public string PhotoPassword { get; set; }
        public string DATE { get; set; }
        public bool? mybookmarked { get; set; }
        public bool? whobookmarked { get; set; }
        public bool? recentlyviewes { get; set; }
        public bool? ignode { get; set; }
        public int? TotalRows { get; set; }
        public int? Totalpages { get; set; }
        public Int64? bookmarcust_id { get; set; }
        public string Bookmarkedtargetcust_id { get; set; }
        public string viewedcust_id { get; set; }
        public string Viwedtagetcust_id { get; set; }
        public string ignorecust_id { get; set; }
        public bool? ExpressFlag { get; set; }
        public DateTime? ExpressDate { get; set; }
        public string ExpressCust_id { get; set; }
        public string ExpressReceiptCustid { get; set; }
        public string ignoretargetcust_id { get; set; }
        public string cpmdate { get; set; }
        public string cvdate { get; set; }
        public string cgdate { get; set; }
        public int? IsPaidMember { get; set; }
        public int? iGenderID { get; set; }
        public int? iCasteID { get; set; }
        public int? iStarID { get; set; }
        public int? iCountryID { get; set; }
        public int? iReligionID { get; set; }
        public int? iProfessionGroupID { get; set; }
        public int? ProfessionID { get; set; }
        public int? iEducationGroupID { get; set; }
        public DateTime? iDateOfBirth { get; set; }
        public int? iHeightInCentimeters { get; set; }
        public int? iStarLanguageID { get; set; }
        public int? iCityID { get; set; }
        public int? iStateID { get; set; }
        public int? MaritalStatusID { get; set; }
        public string MaritualStatus { get; set; }
        public bool? PhotoRequest { get; set; }
        public string Photo { get; set; }
        public int? IsMessage { set; get; }
        public int? NoOfProfiles { get; set; }
        public string CustPhoto { get; set; }
        public string PhotoMaskDiv { get; set; }
        public string RequestDate { get; set; }
        public string DescribeYourSelf { get; set; }
        public string SuggestEmpName { get; set; }
        public string ServiceGivenBanch { get; set; }
        public long? LogID { get; set; }
        public string RelationShipManagerNumber { get; set; }
        public string RelationShipManagerName { get; set; }
        public int? AcceptCount { get; set; }
        public int? RejectCount { get; set; }
        public long? NewCount { get; set; }
        public int? SuggestionFlag { get; set; }
        public string SuggestedEmpNumber { get; set; }
        public string RelationShipManagerEmail { get; set; }
        public string Mystatus { get; set; }
        public string OppStatus { get; set; }
        public long? TicketID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CommunicationHistoryFlag { get; set; }
        public int? Opppending { get; set; }
        public int? Oppskipped { get; set; }
        public int? YouProceed { get; set; }
        public int? Youskipped { get; set; }
        public int? YouPending { get; set; }
        public int? OppProceed { get; set; }
    }

    public class DashboardRequest
    {
        public int? IntCustID { get; set; }
        public string TypeOfReport { get; set; }
        public int? pagefrom { get; set; }
        public int? pageto { get; set; }
        public string yourFilter { get; set; }
        public string oppfilter { get; set; }
    }

    public class PersonalInfo
    {
        public string TableName { get; set; }
        public string ProfileID { get; set; }
        public int? GenderID { get; set; }
        public string NAME { get; set; }
        public int? PaidMember { get; set; }
        public string ProfileLastModifieddate { get; set; }
        public string PhotoName { get; set; }
        public int? PhotoName_Cust { get; set; }
        public string MsgReceivedFrom { get; set; }
        public string MsgReceivedDate { get; set; }
        public string ProfilePhotoName { get; set; }
        public bool? IsReviewed { get; set; }
        public bool? IsActive { get; set; }
        public int? ProfileBattery { get; set; }
        public Int64? EmpID { get; set; }
        public string EmpPhone { get; set; }
        public string OfficialContactNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmailID { get; set; }
        public int? PhotoViewCount { get; set; }
        public int? PartnetPrefernceLastOnemonth { get; set; }
        public string MaskDiv { get; set; }
        public string Photo { get; set; }
    }

    public class LandingPartnerMenu
    {
        public string MenuName { get; set; }
        public string OnlyName { get; set; }
        public int? MybookMarkedProfCount { get; set; }
        public int? WhobookmarkedCount { get; set; }
        public int? RectViewedProfCount { get; set; }
        public int? RectWhoViewedCout { get; set; }
        public int? IgnoreProfileCount { get; set; }
        public int? SaveSearchCount { get; set; }
        public string PageName { get; set; }

        public int? ExpressIntSent { get; set; }
        public int? ExpressIntReceived { get; set; }

        public int? NewMsgs { get; set; }
        public int? TotalMsgs { get; set; }

        public int? SentPhotoRequestCount { get; set; }
        public int? SentHoroRequestCount { get; set; }
        public int? ReceivedPhotoRequestCount { get; set; }
        public int? ReceivedHoroRequestCount { get; set; }
        public int? SentProtectedReply { get; set; }
        public int? SentProtectedAccept { get; set; }
        public int? SentProtectedReject { get; set; }
        public int? ReceivedProtectedNew { get; set; }
        public int? ReceivedProtectedAccept { get; set; }
        public int? ReceivedProtectedReject { get; set; }
        public int? ExpressAllcount { get; set; }
    }

}