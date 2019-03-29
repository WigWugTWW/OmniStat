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

    public partial class XPOAddress : XPOBase
    {
        string fAddress1;
        public string Address1
        {
            get { return fAddress1; }
            set { SetPropertyValue<string>(nameof(Address1), ref fAddress1, value); }
        }
        string fAddress2;
        public string Address2
        {
            get { return fAddress2; }
            set { SetPropertyValue<string>(nameof(Address2), ref fAddress2, value); }
        }
        XPOState fState;
        [Association(@"XPOAddressReferencesXPOState")]
        public XPOState State
        {
            get { return fState; }
            set { SetPropertyValue<XPOState>(nameof(State), ref fState, value); }
        }
        string fProvinceRegion;
        public string ProvinceRegion
        {
            get { return fProvinceRegion; }
            set { SetPropertyValue<string>(nameof(ProvinceRegion), ref fProvinceRegion, value); }
        }
        string fPostalCode;
        public string PostalCode
        {
            get { return fPostalCode; }
            set { SetPropertyValue<string>(nameof(PostalCode), ref fPostalCode, value); }
        }
        XPOPerson fPerson;
        public XPOPerson Person
        {
            get { return fPerson; }
            set { SetPropertyValue<XPOPerson>(nameof(Person), ref fPerson, value); }
        }
        [Association(@"XPOAddressReferencesXPOPerson")]
        public XPCollection<XPOPerson> XPOPersons { get { return GetCollection<XPOPerson>(nameof(XPOPersons)); } }
    }

}
