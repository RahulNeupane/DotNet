﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace firstday.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class mainEntities : DbContext
{
    public mainEntities()
        : base("name=mainEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<employee> employees { get; set; }

    public virtual DbSet<student> students { get; set; }

}

}

