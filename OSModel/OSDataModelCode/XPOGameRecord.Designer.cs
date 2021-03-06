﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace OSModel.OSDB
{

    public partial class XPOGameRecord : XPObject
    {
        string fCollegeTeam;
        public string CollegeTeam
        {
            get { return fCollegeTeam; }
            set { SetPropertyValue<string>(nameof(CollegeTeam), ref fCollegeTeam, value); }
        }
        int fYear;
        public int Year
        {
            get { return fYear; }
            set { SetPropertyValue<int>(nameof(Year), ref fYear, value); }
        }
        XPOFacility fLocation;
        [Association(@"XPOGameRecordReferencesXPOUniversityFacility")]
        public XPOFacility Location
        {
            get { return fLocation; }
            set { SetPropertyValue<XPOFacility>(nameof(Location), ref fLocation, value); }
        }
        string fWinLoss;
        public string WinLoss
        {
            get { return fWinLoss; }
            set { SetPropertyValue<string>(nameof(WinLoss), ref fWinLoss, value); }
        }
        int fSelectedScore;
        public int SelectedScore
        {
            get { return fSelectedScore; }
            set { SetPropertyValue<int>(nameof(SelectedScore), ref fSelectedScore, value); }
        }
        int fOponentScore;
        public int OponentScore
        {
            get { return fOponentScore; }
            set { SetPropertyValue<int>(nameof(OponentScore), ref fOponentScore, value); }
        }
        DateTime fGameDate;
        public DateTime GameDate
        {
            get { return fGameDate; }
            set { SetPropertyValue<DateTime>(nameof(GameDate), ref fGameDate, value); }
        }
        string fGameNotes;
        public string GameNotes
        {
            get { return fGameNotes; }
            set { SetPropertyValue<string>(nameof(GameNotes), ref fGameNotes, value); }
        }
        int fAtendance;
        public int Atendance
        {
            get { return fAtendance; }
            set { SetPropertyValue<int>(nameof(Atendance), ref fAtendance, value); }
        }
    }

}
