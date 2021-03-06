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

    public partial class XPOPlayer : XPObject
    {
        int fPlayerID;
        public int PlayerID
        {
            get { return fPlayerID; }
            set { SetPropertyValue<int>(nameof(PlayerID), ref fPlayerID, value); }
        }
        string fDescription;
        [Size(30)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        int fOffDef;
        public int OffDef
        {
            get { return fOffDef; }
            set { SetPropertyValue<int>(nameof(OffDef), ref fOffDef, value); }
        }
        string fResponsibilities;
        public string Responsibilities
        {
            get { return fResponsibilities; }
            set { SetPropertyValue<string>(nameof(Responsibilities), ref fResponsibilities, value); }
        }
        XPOParticipant fParticipants;
        [Association(@"XPOPlayerFootballReferencesXPOParticipants")]
        public XPOParticipant Participants
        {
            get { return fParticipants; }
            set { SetPropertyValue<XPOParticipant>(nameof(Participants), ref fParticipants, value); }
        }
    }

}
