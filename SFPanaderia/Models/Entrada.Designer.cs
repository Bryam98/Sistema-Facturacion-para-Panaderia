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
namespace SFPanaderia.PanaderiaBD
{

    public partial class Entrada : XPLiteObject
    {
        int fIdEntrada;
        [Key(true)]
        [Persistent(@"idEntrada")]
        public int IdEntrada
        {
            get { return fIdEntrada; }
            set { SetPropertyValue<int>(nameof(IdEntrada), ref fIdEntrada, value); }
        }
        DateTime fFechaEntrada;
        [Persistent(@"fechaEntrada")]
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime FechaEntrada
        {
            get { return fFechaEntrada; }
            set { SetPropertyValue<DateTime>(nameof(FechaEntrada), ref fFechaEntrada, value); }
        }
        Empleado fIdEmpleado;
        [Persistent(@"idEmpleado")]
        [Association(@"EntradaReferencesEmpleado")]
        public Empleado IdEmpleado
        {
            get { return fIdEmpleado; }
            set { SetPropertyValue<Empleado>(nameof(IdEmpleado), ref fIdEmpleado, value); }
        }
        [Association(@"DetalleEntradaReferencesEntrada")]
        public XPCollection<DetalleEntrada> DetalleEntradas { get { return GetCollection<DetalleEntrada>(nameof(DetalleEntradas)); } }
    }

}
