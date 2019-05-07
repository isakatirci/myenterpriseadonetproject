/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using ProjectNameNorthwind.Business;
using ProjectNameNorthwind.Business.Interfaces;
using ProjectNameNorthwind.Business.Repository.Interfaces;

namespace ProjectNameNorthwind.Mvc.SampleViewModels
{
	public partial class SupplierVm
	{
		#region member properties
		
		public virtual Int32? Id { get; set;}
		
		public virtual string CompanyName { get; set;}
		
		public virtual string ContactName { get; set;}
		
		public virtual string ContactTitle { get; set;}
		
		public virtual string City { get; set;}
		
		public virtual string Country { get; set;}
		
		public virtual string Phone { get; set;}
		
		public virtual string Fax { get; set;}
		#endregion
		
		public SupplierVm() {}
		
		public SupplierVm(IBOSupplier boSupplier)
		{
			Id = boSupplier.Id;
			CompanyName = boSupplier.CompanyName;
			ContactName = boSupplier.ContactName;
			ContactTitle = boSupplier.ContactTitle;
			City = boSupplier.City;
			Country = boSupplier.Country;
			Phone = boSupplier.Phone;
			Fax = boSupplier.Fax;
		}
		
		public IBOSupplier BOSupplier()
		{
			var boSupplier = new BOSupplier()
			{
				Id = this.Id,
				CompanyName = this.CompanyName,
				ContactName = this.ContactName,
				ContactTitle = this.ContactTitle,
				City = this.City,
				Country = this.Country,
				Phone = this.Phone,
				Fax = this.Fax
			};
			return boSupplier;
		}
		
		public IBOSupplier BOSupplier(ISupplierRepository repo)
		{
			BOSupplier boSupplier = (BOSupplier)BOSupplier();
			boSupplier.Repository = repo;
			return boSupplier;
		}
	}
}
