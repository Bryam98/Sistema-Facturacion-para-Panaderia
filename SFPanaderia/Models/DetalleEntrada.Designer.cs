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

    public partial class DetalleEntrada : XPLiteObject
    {
        int fIdDetalleEntrada;
        [Key(true)]
        [Persistent(@"idDetalleEntrada")]
        public int IdDetalleEntrada
        {
            get { return fIdDetalleEntrada; }
            set { SetPropertyValue<int>(nameof(IdDetalleEntrada), ref fIdDetalleEntrada, value); }
        }
        Entrada fIdEntrada;
        [Persistent(@"idEntrada")]
        [Association(@"DetalleEntradaReferencesEntrada")]
        public Entrada IdEntrada
        {
            get { return fIdEntrada; }
            set { SetPropertyValue<Entrada>(nameof(IdEntrada), ref fIdEntrada, value); }
        }
        Producto fIdProducto;
        [Persistent(@"idProducto")]
        [Association(@"DetalleEntradaReferencesProducto")]
        public Producto IdProducto
        {
            get { return fIdProducto; }
            set { SetPropertyValue<Producto>(nameof(IdProducto), ref fIdProducto, value); }
        }
        int fCantidad;
        [Persistent(@"cantidad")]
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
    }

}