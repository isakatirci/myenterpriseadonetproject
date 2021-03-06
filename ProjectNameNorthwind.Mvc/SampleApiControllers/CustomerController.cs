/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Threading.Tasks;
using ProjectNameNorthwind.Mvc.SampleViewModels;
using ProjectNameNorthwind.Business;
using ProjectNameNorthwind.Business.Interfaces;
using ProjectNameNorthwind.Business.Repository;
using ProjectNameNorthwind.Business.Repository.Interfaces;

namespace ProjectNameNorthwind.Mvc.SampleApiControllers
{
	public partial class CustomerController : ApiController
	{
		protected ICustomerRepository _iCustomerRepository;

            // GET: api/Customer
        public async Task<IHttpActionResult> GetCustomer(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<CustomerVm> listVm = new List<CustomerVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOCustomer>(CustomerRepository);
                totalCount = criteria.Count();

                IList<BOCustomer> listBOs = criteria
                    .Add(new OrderBy("Id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOCustomer>();

                foreach (var bo in listBOs)
                    listVm.Add(new CustomerVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/Customer/5
        [ResponseType(typeof(CustomerVm))]
        public async Task<IHttpActionResult> GetCustomer(Int32 id)
        {
            var result = Task.Factory.StartNew(() => {

                BOCustomer bo = new Criteria<BOCustomer>(CustomerRepository)
                .Add(Expression.Eq("Id", id))
                .SingleOrDefault<BOCustomer>();
                return bo == null ? null : new CustomerVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/Customer/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCustomer(Int32 id, CustomerVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vm.Id)
            {
                return BadRequest();
            }

            var result = Task.Factory.StartNew(() => {

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { CustomerRepository }); 
                var bo = (BOCustomer)vm.BOCustomer(CustomerRepository);
                uow.Update(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                return true;
            });
            await result;
            if (!result.Result)
                return NotFound();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Customer
        [ResponseType(typeof(CustomerVm))]
        public async Task<IHttpActionResult> PostCustomer(CustomerVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { CustomerRepository }); 
                var bo = (BOCustomer)vm.BOCustomer(CustomerRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new CustomerVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.Id }, vm);
        }

        // DELETE: api/Customer/5
        [ResponseType(typeof(CustomerVm))]
        public async Task<IHttpActionResult> DeleteCustomer(Int32 id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { CustomerRepository }); 
                var bo = new BOCustomer();
                bo.Repository = CustomerRepository;
                bo.Init(id);
                
                uow.Delete(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                return true;
            });
            await result;
            if (!result.Result)
                return NotFound();

            return Ok(result.Result);
        }

        
        public ICustomerRepository CustomerRepository
        {
            get { return _iCustomerRepository ?? (_iCustomerRepository = RF.New().CustomerRepository); }
            set { _iCustomerRepository = value; }
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
	}
}
