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

    public partial class XPOContact : XPObject
    {
        string fHomePhone;
        public string HomePhone
        {
            get { return fHomePhone; }
            set { SetPropertyValue<string>(nameof(HomePhone), ref fHomePhone, value); }
        }
        string fCellPhone;
        public string CellPhone
        {
            get { return fCellPhone; }
            set { SetPropertyValue<string>(nameof(CellPhone), ref fCellPhone, value); }
        }
        string fCPCanText;
        public string CPCanText
        {
            get { return fCPCanText; }
            set { SetPropertyValue<string>(nameof(CPCanText), ref fCPCanText, value); }
        }
        string fWorkPhone;
        public string WorkPhone
        {
            get { return fWorkPhone; }
            set { SetPropertyValue<string>(nameof(WorkPhone), ref fWorkPhone, value); }
        }
        string fWPCanText;
        public string WPCanText
        {
            get { return fWPCanText; }
            set { SetPropertyValue<string>(nameof(WPCanText), ref fWPCanText, value); }
        }
        string fOtherPhone;
        public string OtherPhone
        {
            get { return fOtherPhone; }
            set { SetPropertyValue<string>(nameof(OtherPhone), ref fOtherPhone, value); }
        }
        string fOPCantext;
        public string OPCantext
        {
            get { return fOPCantext; }
            set { SetPropertyValue<string>(nameof(OPCantext), ref fOPCantext, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fWorkEmail;
        public string WorkEmail
        {
            get { return fWorkEmail; }
            set { SetPropertyValue<string>(nameof(WorkEmail), ref fWorkEmail, value); }
        }
        string fOtherEmail;
        public string OtherEmail
        {
            get { return fOtherEmail; }
            set { SetPropertyValue<string>(nameof(OtherEmail), ref fOtherEmail, value); }
        }
    }

}