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

    public partial class XPOColConfDiv : XPObject
    {
        string fDivID;
        [Indexed(Name = @"IDXDivID")]
        [Size(6)]
        public string DivID
        {
            get { return fDivID; }
            set { SetPropertyValue<string>(nameof(DivID), ref fDivID, value); }
        }
        string fDescription;
        [Size(160)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        XPOColConference fCodeID;
        [Association(@"XPOColConfDivReferencesXPOCollConferences")]
        public XPOColConference CodeID
        {
            get { return fCodeID; }
            set { SetPropertyValue<XPOColConference>(nameof(CodeID), ref fCodeID, value); }
        }
        [Association(@"XPOUniversityReferencesXPOColConfDiv")]
        public XPCollection<XPOUniversity> XPOUniversities { get { return GetCollection<XPOUniversity>(nameof(XPOUniversities)); } }
    }

}