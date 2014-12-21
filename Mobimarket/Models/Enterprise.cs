//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobimarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enterprise
    {
        public Enterprise()
        {
            this.BalanceOperations = new HashSet<BalanceOperation>();
            this.Branches = new HashSet<Branch>();
            this.Contacts = new HashSet<Contact>();
            this.EnterpriseServices = new HashSet<EnterpriseService>();
            this.Incomes = new HashSet<Income>();
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public short Type { get; set; }
        public decimal Balance { get; set; }
        public System.DateTime StartDate { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string Adress { get; set; }
        public int OwnerId { get; set; }
        public bool Active { get; set; }
        public short TimeZone { get; set; }
    
        public virtual ICollection<BalanceOperation> BalanceOperations { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<EnterpriseService> EnterpriseServices { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
