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

    public partial class Estado : XPLiteObject
    {
        int fIdEstado;
        [Key(true)]
        [Persistent(@"idEstado")]
        public int IdEstado
        {
            get { return fIdEstado; }
            set { SetPropertyValue<int>(nameof(IdEstado), ref fIdEstado, value); }
        }
        string fNombre;
        [Size(30)]
        [Persistent(@"nombre")]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        [Association(@"ClienteReferencesEstado")]
        public XPCollection<Cliente> Clientes { get { return GetCollection<Cliente>(nameof(Clientes)); } }
        [Association(@"EmpleadoReferencesEstado")]
        public XPCollection<Empleado> Empleadoes { get { return GetCollection<Empleado>(nameof(Empleadoes)); } }
        [Association(@"ProductoReferencesEstado")]
        public XPCollection<Producto> Productoes { get { return GetCollection<Producto>(nameof(Productoes)); } }
        [Association(@"UsuarioReferencesEstado")]
        public XPCollection<Usuario> Usuarios { get { return GetCollection<Usuario>(nameof(Usuarios)); } }
    }

}
