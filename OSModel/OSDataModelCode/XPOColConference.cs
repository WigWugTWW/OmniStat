using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace OSModel.OSDB
{

    public partial class XPOColConference
    {
        public XPOColConference(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
