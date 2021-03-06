﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ShopingEntities : DbContext
    {
        public ShopingEntities()
            : base("name=ShopingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminMst> AdminMsts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserMst> UserMsts { get; set; }
        public virtual DbSet<Order_Mst> Order_Mst { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
    
        public virtual ObjectResult<allproduct_Result> allproduct()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<allproduct_Result>("allproduct");
        }
    
        public virtual ObjectResult<discount_sp_Result> discount_sp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<discount_sp_Result>("discount_sp");
        }
    
        public virtual ObjectResult<itemselected_sp_Result> itemselected_sp(Nullable<int> pr_id)
        {
            var pr_idParameter = pr_id.HasValue ?
                new ObjectParameter("pr_id", pr_id) :
                new ObjectParameter("pr_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<itemselected_sp_Result>("itemselected_sp", pr_idParameter);
        }
    
        public virtual ObjectResult<newproduct_sp_Result> newproduct_sp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<newproduct_sp_Result>("newproduct_sp");
        }
    
        public virtual ObjectResult<string> userlist(string emailid, string pass)
        {
            var emailidParameter = emailid != null ?
                new ObjectParameter("emailid", emailid) :
                new ObjectParameter("emailid", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("userlist", emailidParameter, passParameter);
        }
    
        public virtual int insertProduct_sp(Nullable<decimal> u_id, Nullable<decimal> p_id, Nullable<decimal> qty, Nullable<decimal> total, Nullable<decimal> contact, string plce)
        {
            var u_idParameter = u_id.HasValue ?
                new ObjectParameter("u_id", u_id) :
                new ObjectParameter("u_id", typeof(decimal));
    
            var p_idParameter = p_id.HasValue ?
                new ObjectParameter("p_id", p_id) :
                new ObjectParameter("p_id", typeof(decimal));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(decimal));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(decimal));
    
            var contactParameter = contact.HasValue ?
                new ObjectParameter("contact", contact) :
                new ObjectParameter("contact", typeof(decimal));
    
            var plceParameter = plce != null ?
                new ObjectParameter("plce", plce) :
                new ObjectParameter("plce", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertProduct_sp", u_idParameter, p_idParameter, qtyParameter, totalParameter, contactParameter, plceParameter);
        }
    
        public virtual int order_insert(Nullable<decimal> u_id, Nullable<decimal> p_id, Nullable<decimal> qty, Nullable<decimal> total, Nullable<decimal> contact, string plce)
        {
            var u_idParameter = u_id.HasValue ?
                new ObjectParameter("u_id", u_id) :
                new ObjectParameter("u_id", typeof(decimal));
    
            var p_idParameter = p_id.HasValue ?
                new ObjectParameter("p_id", p_id) :
                new ObjectParameter("p_id", typeof(decimal));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(decimal));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(decimal));
    
            var contactParameter = contact.HasValue ?
                new ObjectParameter("contact", contact) :
                new ObjectParameter("contact", typeof(decimal));
    
            var plceParameter = plce != null ?
                new ObjectParameter("plce", plce) :
                new ObjectParameter("plce", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("order_insert", u_idParameter, p_idParameter, qtyParameter, totalParameter, contactParameter, plceParameter);
        }
    
        public virtual int Register_sp(string uname, string email, string pass, string add, Nullable<System.DateTime> db, Nullable<decimal> cont)
        {
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var addParameter = add != null ?
                new ObjectParameter("add", add) :
                new ObjectParameter("add", typeof(string));
    
            var dbParameter = db.HasValue ?
                new ObjectParameter("db", db) :
                new ObjectParameter("db", typeof(System.DateTime));
    
            var contParameter = cont.HasValue ?
                new ObjectParameter("cont", cont) :
                new ObjectParameter("cont", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Register_sp", unameParameter, emailParameter, passParameter, addParameter, dbParameter, contParameter);
        }
    
        public virtual ObjectResult<Order_History_Result> Order_History(Nullable<decimal> o_id, Nullable<decimal> u_id)
        {
            var o_idParameter = o_id.HasValue ?
                new ObjectParameter("o_id", o_id) :
                new ObjectParameter("o_id", typeof(decimal));
    
            var u_idParameter = u_id.HasValue ?
                new ObjectParameter("u_id", u_id) :
                new ObjectParameter("u_id", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order_History_Result>("Order_History", o_idParameter, u_idParameter);
        }
    
        public virtual int update_qty(Nullable<decimal> qty, Nullable<decimal> pid)
        {
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(decimal));
    
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_qty", qtyParameter, pidParameter);
        }
    
        public virtual int updateQty(Nullable<decimal> qty, Nullable<decimal> pid)
        {
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(decimal));
    
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateQty", qtyParameter, pidParameter);
        }
    
        public virtual int upqty(Nullable<decimal> qty, Nullable<decimal> pid)
        {
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(decimal));
    
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("upqty", qtyParameter, pidParameter);
        }
    
        public virtual int updateQt(Nullable<decimal> qty, Nullable<decimal> pid)
        {
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(decimal));
    
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateQt", qtyParameter, pidParameter);
        }
    
        public virtual ObjectResult<history_sp_Result> history_sp(Nullable<decimal> u_id)
        {
            var u_idParameter = u_id.HasValue ?
                new ObjectParameter("u_id", u_id) :
                new ObjectParameter("u_id", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<history_sp_Result>("history_sp", u_idParameter);
        }
    
        public virtual ObjectResult<contact_sp_Result> contact_sp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<contact_sp_Result>("contact_sp");
        }
    
        public virtual int insert_contact(string name, string email, Nullable<decimal> phn, string sub, string meg)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phnParameter = phn.HasValue ?
                new ObjectParameter("phn", phn) :
                new ObjectParameter("phn", typeof(decimal));
    
            var subParameter = sub != null ?
                new ObjectParameter("sub", sub) :
                new ObjectParameter("sub", typeof(string));
    
            var megParameter = meg != null ?
                new ObjectParameter("meg", meg) :
                new ObjectParameter("meg", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_contact", nameParameter, emailParameter, phnParameter, subParameter, megParameter);
        }
    }
}
