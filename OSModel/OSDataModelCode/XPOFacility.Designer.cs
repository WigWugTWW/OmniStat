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

    public partial class XPOFacility : XPObject
    {
        string fFacilityName;
        public string FacilityName
        {
            get { return fFacilityName; }
            set { SetPropertyValue<string>(nameof(FacilityName), ref fFacilityName, value); }
        }
        int fCapacity;
        public int Capacity
        {
            get { return fCapacity; }
            set { SetPropertyValue<int>(nameof(Capacity), ref fCapacity, value); }
        }
        string fLat;
        public string Lat
        {
            get { return fLat; }
            set { SetPropertyValue<string>(nameof(Lat), ref fLat, value); }
        }
        string fLon;
        public string Lon
        {
            get { return fLon; }
            set { SetPropertyValue<string>(nameof(Lon), ref fLon, value); }
        }
        string fTag;
        public string Tag
        {
            get { return fTag; }
            set { SetPropertyValue<string>(nameof(Tag), ref fTag, value); }
        }
        int fYearBuilt;
        public int YearBuilt
        {
            get { return fYearBuilt; }
            set { SetPropertyValue<int>(nameof(YearBuilt), ref fYearBuilt, value); }
        }
        [Association(@"XPOGameRecordReferencesXPOUniversityFacility")]
        public XPCollection<XPOGameRecord> XPOGameRecords { get { return GetCollection<XPOGameRecord>(nameof(XPOGameRecords)); } }
        [Association(@"XPOTeamReferencesXPOFacility")]
        public XPCollection<XPOCollegeTeam> XPOTeams { get { return GetCollection<XPOCollegeTeam>(nameof(XPOTeams)); } }
        [Association(@"XPOProTeamReferencesXPOFacility")]
        public XPCollection<XPOProTeam> XPOProTeams { get { return GetCollection<XPOProTeam>(nameof(XPOProTeams)); } }
    }

}
