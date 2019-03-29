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

    /// <summary>
    /// Pro or Amature
    /// </summary>
    public partial class XPOSportType : XPObject
    {
        string fType;
        /// <summary>
        /// Pro or College
        /// </summary>
        [Indexed(Name = @"IDXType")]
        [Size(6)]
        public string Type
        {
            get { return fType; }
            set { SetPropertyValue<string>(nameof(Type), ref fType, value); }
        }
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        [Association(@"XPOAllSportsReferencesXPOSportType")]
        public XPCollection<XPOSportsCode> XPOAllSportsCollection { get { return GetCollection<XPOSportsCode>(nameof(XPOAllSportsCollection)); } }
    }

}