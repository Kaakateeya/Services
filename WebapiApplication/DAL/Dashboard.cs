using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WebapiApplication.ML;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using KaakateeyaDAL;

namespace WebapiApplication.DAL
{
    public class Dashboard
    {
        public DashboardClass LandingCountsDal(DashboardRequest Dreq)
        {
            DashboardClass land = new DashboardClass();
            List<PartnerProfilesLatest> PartnerLi = new List<PartnerProfilesLatest>();

            SqlDataReader reader;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string Snull = "--";
            int? inull = null;
            bool? bnull = null;
            DateTime? dnull = null;
            Int64? Lnull = null;
            List<PersonalInfo> liPerson = new List<PersonalInfo>();
            try
            {
                SqlParameter[] parm = new SqlParameter[6];

                parm[0] = new SqlParameter("@custID", SqlDbType.Int);
                parm[0].Value = Dreq.IntCustID;

                parm[1] = new SqlParameter("@TypeOfReport", SqlDbType.VarChar);
                parm[1].Value = Dreq.TypeOfReport;
                parm[2] = new SqlParameter("@pagefrom", SqlDbType.Int);
                parm[2].Value = Dreq.pagefrom;
                parm[3] = new SqlParameter("@pageto", SqlDbType.Int);
                parm[3].Value = Dreq.pageto;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KakConnection"].ToString()))
                {
                    con.Open();
                    reader = SQLHelper.ExecuteReader(con, CommandType.StoredProcedure, "[dbo].[usp_select_CustomerDashBoard]", parm);

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            LandingPartnerMenu liCount = new LandingPartnerMenu();
                            {

                                liCount.SaveSearchCount = reader["SavesSearchCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("SavesSearchCount")) : inull;
                                liCount.WhobookmarkedCount = reader["WhoBookmarkedCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("WhoBookmarkedCount")) : inull;
                                liCount.MybookMarkedProfCount = reader["BookmarkCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("BookmarkCount")) : inull;
                                liCount.RectViewedProfCount = reader["ViewedCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("ViewedCount")) : inull;
                                liCount.RectWhoViewedCout = reader["WhoViewedCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("WhoViewedCount")) : inull;
                                liCount.IgnoreProfileCount = reader["IgnoreCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("IgnoreCount")) : inull;
                                //express and Counts Bind

                                liCount.ExpressIntSent = reader["ExpressSentCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("ExpressSentCount")) : inull;
                                liCount.ExpressIntReceived = reader["ExpressReceiveCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("ExpressReceiveCount")) : inull;
                                liCount.ExpressAllcount = reader["ExpressAllcount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("ExpressAllcount")) : inull;

                                liCount.NewMsgs = reader["NewMessageCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("NewMessageCount")) : inull;
                                liCount.TotalMsgs = reader["TotalMessageCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("TotalMessageCount")) : inull;

                                liCount.SentPhotoRequestCount = reader["PhotoRequestSentCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("PhotoRequestSentCount"))) : inull;
                                liCount.SentHoroRequestCount = reader["HoroRequestSentCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("HoroRequestSentCount"))) : inull;
                                liCount.ReceivedPhotoRequestCount = reader["PhotoRequestReceivedCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("PhotoRequestReceivedCount"))) : inull;
                                liCount.ReceivedHoroRequestCount = reader["HoroRequestReceivedCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("HoroRequestReceivedCount"))) : inull;

                                liCount.SentProtectedReply = reader["SentProtectedNewCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("SentProtectedNewCount"))) : inull;
                                liCount.SentProtectedAccept = reader["SentProtectedAcceptCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("SentProtectedAcceptCount"))) : inull;
                                liCount.SentProtectedReject = reader["SentProtectedRejectCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("SentProtectedRejectCount"))) : inull;
                                liCount.ReceivedProtectedNew = reader["ReceivedProtectedNewCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("ReceivedProtectedNewCount"))) : inull;
                                liCount.ReceivedProtectedAccept = reader["ReceivedProtectedAcceptCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("ReceivedProtectedAcceptCount"))) : inull;
                                liCount.ReceivedProtectedReject = reader["ReceivedProtectedRejectCount"] != DBNull.Value ? Convert.ToInt32(reader.GetString(reader.GetOrdinal("ReceivedProtectedRejectCount"))) : inull;
                                land.DashBoardCounts = liCount;
                            }

                        }
                    }
                    reader.NextResult();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            PersonalInfo Pcls = new PersonalInfo();
                            Pcls.TableName = reader["TableName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("TableName")) : null;
                            Pcls.ProfileID = reader["ProfileID"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ProfileID")) : null;
                            Pcls.GenderID = reader["GenderID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("GenderID")) : inull;
                            Pcls.NAME = reader["NAME"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("NAME")) : null;
                            Pcls.PaidMember = reader["PaidMember"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("PaidMember")) : inull;
                            Pcls.ProfileLastModifieddate = reader["ProfileLastModifieddate"] != DBNull.Value ? (reader.GetDateTime(reader.GetOrdinal("ProfileLastModifieddate"))).ToString() : null;
                            Pcls.PhotoName = reader["PhotoName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("PhotoName")) : null;
                            Pcls.PhotoName_Cust = reader["PhotoName_Cust"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("PhotoName_Cust")) : inull;
                            Pcls.MsgReceivedFrom = reader["MsgReceivedFrom"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("MsgReceivedFrom")) : null;
                            Pcls.MsgReceivedDate = reader["MsgReceivedDate"] != DBNull.Value ? (reader.GetDateTime(reader.GetOrdinal("MsgReceivedDate"))).ToString() : null;
                            Pcls.ProfilePhotoName = reader["ProfilePhotoName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ProfilePhotoName")) : null;
                            Pcls.IsReviewed = reader["IsReviewed"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("IsReviewed")) : bnull;
                            Pcls.IsActive = reader["IsActive"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("IsActive")) : bnull;
                            Pcls.ProfileBattery = reader["ProfileBattery"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("ProfileBattery")) : inull;
                            Pcls.EmpID = reader["EmpID"] != DBNull.Value ? reader.GetInt64(reader.GetOrdinal("EmpID")) : Lnull;
                            Pcls.EmpPhone = reader["EmpPhone"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("EmpPhone")) : null;
                            Pcls.OfficialContactNumber = reader["OfficialContactNumber"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("OfficialContactNumber")) : null;
                            Pcls.EmployeeName = reader["EmployeeName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("EmployeeName")) : null;
                            Pcls.EmailID = reader["EmailID"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("EmailID")) : null;
                            Pcls.PhotoViewCount = reader["PhotoViewCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("PhotoViewCount")) : inull;
                            Pcls.PartnetPrefernceLastOnemonth = reader["PartnetPrefernceLastOnemonth"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("PartnetPrefernceLastOnemonth")) : inull;
                            Pcls.Photo = reader["Photo"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Photo")) : null;
                            Pcls.MaskDiv = (!string.IsNullOrEmpty(Pcls.ProfilePhotoName) && (Pcls.IsReviewed == true && Pcls.IsActive == true)) ? " " : ((!string.IsNullOrEmpty(Pcls.ProfilePhotoName) && (Pcls.IsReviewed == true || Pcls.IsActive == true)) ? "divCSSclass clearfix" : "cssMaskupload clearfix");
                            land.PersonalInfo = Pcls;
                        }

                    }

                    reader.NextResult();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            PartnerProfilesLatest Partnercls = ReturnPartnerProfilesClass(reader, "Partner");

                            PartnerLi.Add(Partnercls);
                        }
                        land.PartnerProfilesnew = PartnerLi;
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return land;
        }

        public DashboardClass GetPartnerProfilesDal(DashboardRequest Dreq)
        {
            DashboardClass land = new DashboardClass();
            List<PartnerProfilesLatest> PartnerLi = new List<PartnerProfilesLatest>();

            SqlDataReader reader;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<PersonalInfo> liPerson = new List<PersonalInfo>();
            try
            {
                SqlParameter[] parm = new SqlParameter[6];

                parm[0] = new SqlParameter("@custID", SqlDbType.Int);
                parm[0].Value = Dreq.IntCustID;

                parm[1] = new SqlParameter("@TypeOfReport", SqlDbType.VarChar);
                parm[1].Value = Dreq.TypeOfReport;
                parm[2] = new SqlParameter("@pagefrom", SqlDbType.Int);
                parm[2].Value = Dreq.pagefrom;
                parm[3] = new SqlParameter("@pageto", SqlDbType.Int);
                parm[3].Value = Dreq.pageto;
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KakConnection"].ToString()))
                {
                    con.Open();
                    reader = SQLHelper.ExecuteReader(con, CommandType.StoredProcedure, "[dbo].[usp_select_CustomerDashBoard]", parm);

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            PartnerProfilesLatest Partnercls = ReturnPartnerProfilesClass(reader, "Partner");
                            PartnerLi.Add(Partnercls);
                        }
                        land.PartnerProfilesnew = PartnerLi;
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return land;
        }


        public PartnerProfilesLatest ReturnPartnerProfilesClass(SqlDataReader reader, string Type)
        {
            string Snull = "--";
            int? inull = null;
            bool? bnull = null;
            DateTime? dnull = null;
            Int64? Lnull = null;
            PartnerProfilesLatest Partnercls = new PartnerProfilesLatest();
            Partnercls.Row = reader["Row"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("Row")) : inull;
            Partnercls.TableName = reader["TableName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("TableName")) : null;
            Partnercls.ProfileID = reader["ProfileID"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ProfileID")) : null;
            Partnercls.Cust_ID = reader["Cust_ID"] != DBNull.Value ? reader.GetInt64(reader.GetOrdinal("Cust_ID")) : Lnull;
            Partnercls.NAME = reader["NAME"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("NAME")) : null;
            Partnercls.LastName = reader["LastName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("LastName")) : null;
            Partnercls.DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? (reader.GetString(reader.GetOrdinal("DateOfBirth"))) : null;
            Partnercls.Age = reader["Age"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("Age")) : inull;
            Partnercls.Height = reader["Height"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Height")) : null;
            Partnercls.ReligionName = reader["ReligionName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ReligionName")) : null;
            Partnercls.Caste = reader["Caste"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Caste")) : null;
            Partnercls.Education = reader["Education"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Education")) : null;
            Partnercls.EducationGroup = reader["EducationGroup"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("EducationGroup")) : null;
            Partnercls.profession = reader["profession"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("profession")) : null;
            Partnercls.PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("PhoneNumber")) : null;
            Partnercls.Email = reader["Email"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Email")) : null;
            Partnercls.Star = reader["Star"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Star")) : null;
            Partnercls.placeofbirth = reader["placeofbirth"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("placeofbirth")) : null;
            Partnercls.Location = reader["Location"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Location")) : null;
            //Partnercls.IsprofileMarked = reader["IsprofileMarked"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("IsprofileMarked")) : bnull;
            Partnercls.HoroscopeImage = reader["HoroscopeImage"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("HoroscopeImage")) : null;
            //Partnercls.IsExpressIntrestMarked = reader["IsExpressIntrestMarked"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("IsExpressIntrestMarked")) : bnull;
            //Partnercls.IsIntrested = reader["IsIntrested"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("IsExpressIntrestMarked")) : bnull;
            Partnercls.PhotosCount = reader["PhotosCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("PhotosCount")) : inull;
            Partnercls.Photoname = reader["Photoname"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Photoname")) : null;
            //Partnercls.PhotoPassword = reader["PhotoPassword"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("PhotoPassword")) : null;
            //Partnercls.DATE = reader["DATE"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("DATE")) : null;
            Partnercls.mybookmarked = reader["mybookmarked"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("mybookmarked")) : bnull;
            //Partnercls.whobookmarked = reader["whobookmarked"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("whobookmarked")) : bnull;
            Partnercls.recentlyviewes = reader["recentlyviewes"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("recentlyviewes")) : bnull;
            Partnercls.ignode = reader["ignode"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("ignode")) : bnull;
            Partnercls.TotalRows = reader["TotalRows"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("TotalRows")) : inull;
            //Partnercls.Totalpages = reader["Totalpages"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("Totalpages")) : inull;
            //Partnercls.bookmarcust_id = reader["bookmarcust_id"] != DBNull.Value ? reader.GetInt64(reader.GetOrdinal("bookmarcust_id")) : Lnull;
            //Partnercls.Bookmarkedtargetcust_id = reader["Bookmarkedtargetcust_id"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Bookmarkedtargetcust_id")) : null;
            //Partnercls.viewedcust_id = reader["viewedcust_id"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("viewedcust_id")) : null;
            //Partnercls.Viwedtagetcust_id = reader["Viwedtagetcust_id"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Viwedtagetcust_id")) : null;
            //Partnercls.ignorecust_id = reader["ignorecust_id"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ignorecust_id")) : null;
            Partnercls.ExpressFlag = reader["ExpressFlag"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("ExpressFlag")) : bnull;
            //Partnercls.ExpressDate = reader["ExpressDate"] != DBNull.Value ? reader.GetDateTime(reader.GetOrdinal("ExpressDate")) : dnull;
            //Partnercls.ExpressCust_id = reader["ExpressCust_id"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ExpressCust_id")) : null;
            //Partnercls.ExpressReceiptCustid = reader["ExpressReceiptCustid"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ExpressReceiptCustid")) : null;
            //Partnercls.ignoretargetcust_id = reader["ignoretargetcust_id"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ignoretargetcust_id")) : null;
            //Partnercls.cpmdate = reader["cpmdate"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("cpmdate")) : null;
            //Partnercls.cvdate = reader["cvdate"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("cvdate")) : null;
            //Partnercls.cgdate = reader["cgdate"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("cgdate")) : null;
            Partnercls.IsPaidMember = reader["IsPaidMember"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("IsPaidMember")) : inull;
            Partnercls.iGenderID = reader["iGenderID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iGenderID")) : inull;
            Partnercls.iCasteID = reader["iCasteID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iCasteID")) : inull;
            Partnercls.iStarID = reader["iStarID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iStarID")) : inull;
            Partnercls.iCountryID = reader["iCountryID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iCountryID")) : inull;
            Partnercls.iReligionID = reader["iReligionID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iReligionID")) : inull;
            Partnercls.iProfessionGroupID = reader["iProfessionGroupID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iProfessionGroupID")) : inull;
            Partnercls.ProfessionID = reader["ProfessionID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("ProfessionID")) : inull;
            Partnercls.iEducationGroupID = reader["iEducationGroupID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iEducationGroupID")) : inull;
            // Partnercls.iDateOfBirth = reader["iDateOfBirth"] != DBNull.Value ? reader.GetDateTime(reader.GetOrdinal("iDateOfBirth")) : dnull;
            Partnercls.iHeightInCentimeters = reader["iHeightInCentimeters"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iHeightInCentimeters")) : inull;
            Partnercls.iStarLanguageID = reader["iStarLanguageID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iStarLanguageID")) : inull;
            Partnercls.iCityID = reader["iCityID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iCityID")) : inull;
            Partnercls.iStateID = reader["iStateID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("iStateID")) : inull;
            Partnercls.MaritalStatusID = reader["MaritalStatusID"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("MaritalStatusID")) : inull;
            Partnercls.MaritualStatus = reader["MaritualStatus"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("MaritualStatus")) : null;
            //Partnercls.PhotoRequest = reader["PhotoRequest"] != DBNull.Value ? reader.GetBoolean(reader.GetOrdinal("PhotoRequest")) : bnull;
            Partnercls.Photo = reader["Photo"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Photo")) : null;
            // Partnercls.RequestDate = reader["RequestDate"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("RequestDate")) : null;
            Partnercls.DescribeYourSelf = reader["DescribeYourSelf"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("DescribeYourSelf")) : null;
            if (Type == "ExpressInterest")
            {
                Partnercls.ServiceGivenBanch = reader["ServiceGivenBanch"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("ServiceGivenBanch")) : null;
                Partnercls.SuggestEmpName = reader["SuggestEmpName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("SuggestEmpName")) : null;
                Partnercls.SuggestedEmpNumber = reader["SuggestedEmpNumber"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("SuggestedEmpNumber")) : null;
                Partnercls.SuggestionFlag = reader["SuggestionFlag"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("SuggestionFlag")) : inull;
                Partnercls.NewCount = reader["NewCount"] != DBNull.Value ? reader.GetInt64(reader.GetOrdinal("NewCount")) : Lnull;
                Partnercls.AcceptCount = reader["AcceptCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("AcceptCount")) : inull;
                Partnercls.RejectCount = reader["RejectCount"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("RejectCount")) : inull;
                Partnercls.RelationShipManagerName = reader["RelationShipManagerName"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("RelationShipManagerName")) : null;
                Partnercls.RelationShipManagerNumber = reader["RelationShipManagerNumber"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("RelationShipManagerNumber")) : null;
                Partnercls.LogID = reader["LogID"] != DBNull.Value ? reader.GetInt64(reader.GetOrdinal("LogID")) : Lnull;
                Partnercls.RelationShipManagerEmail = reader["RelationShipManagerEmail"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("RelationShipManagerEmail")) : null;

                Partnercls.Mystatus = reader["Mystatus"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Mystatus")) : null;
                Partnercls.OppStatus = reader["OppStatus"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("OppStatus")) : null;

                Partnercls.TicketID = reader["TicketID"] != DBNull.Value ? reader.GetInt64(reader.GetOrdinal("TicketID")) : Lnull;
                Partnercls.CreatedDate = reader["CreatedDate"] != DBNull.Value ? reader.GetDateTime(reader.GetOrdinal("CreatedDate")) : dnull;
                Partnercls.CommunicationHistoryFlag = reader["CommunicationHistoryFlag"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("CommunicationHistoryFlag")) : inull;
                Partnercls.YouProceed = reader["YouProceed"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("YouProceed")) : inull;
                Partnercls.Youskipped = reader["Youskipped"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("Youskipped")) : inull;
                Partnercls.YouPending = reader["YouPending"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("YouPending")) : inull;
                Partnercls.OppProceed = reader["OppProceed"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("OppProceed")) : inull;
                Partnercls.Oppskipped = reader["Oppskipped"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("Oppskipped")) : inull;
                Partnercls.Opppending = reader["Opppending"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("Opppending")) : inull;
            }
            else
            {
                Partnercls.RequestDate = reader["RequestDate"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("RequestDate")) : null;
            }

            return Partnercls;
        }

    }
}