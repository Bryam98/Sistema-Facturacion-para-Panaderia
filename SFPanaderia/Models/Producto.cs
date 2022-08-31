using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SFPanaderia.PanaderiaBD
{

    public partial class Producto
    {
        public Producto(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
