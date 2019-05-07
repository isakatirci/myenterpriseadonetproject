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
	public partial class OrderItemController : ApiController
	{
		protected IOrderItemRepository _iOrderItemRepository;

            // GET: api/OrderItem
        public async Task<IHttpActionResult> GetOrderItem(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<OrderItemVm> listVm = new List<OrderItemVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOOrderItem>(OrderItemRepository);
                totalCount = criteria.Count();

                IList<BOOrderItem> listBOs = criteria
                    .Add(new OrderBy("Id", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOOrderItem>();

                foreach (var bo in listBOs)
                    listVm.Add(new OrderItemVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/OrderItem/5
        [ResponseType(typeof(OrderItemVm))]
        public async Task<IHttpActionResult> GetOrderItem(Int32 id)
        {
            var result = Task.Factory.StartNew(() => {

                BOOrderItem bo = new Criteria<BOOrderItem>(OrderItemRepository)
                .Add(Expression.Eq("Id", id))
                .SingleOrDefault<BOOrderItem>();
                return bo == null ? null : new OrderItemVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/OrderItem/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrderItem(Int32 id, OrderItemVm vm)
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

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { OrderItemRepository }); 
                var bo = (BOOrderItem)vm.BOOrderItem(OrderItemRepository);
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

        // POST: api/OrderItem
        [ResponseType(typeof(OrderItemVm))]
        public async Task<IHttpActionResult> PostOrderItem(OrderItemVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { OrderItemRepository }); 
                var bo = (BOOrderItem)vm.BOOrderItem(OrderItemRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new OrderItemVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.Id }, vm);
        }

        // DELETE: api/OrderItem/5
        [ResponseType(typeof(OrderItemVm))]
        public async Task<IHttpActionResult> DeleteOrderItem(Int32 id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { OrderItemRepository }); 
                var bo = new BOOrderItem();
                bo.Repository = OrderItemRepository;
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

        
        public IOrderItemRepository OrderItemRepository
        {
            get { return _iOrderItemRepository ?? (_iOrderItemRepository = RF.New().OrderItemRepository); }
            set { _iOrderItemRepository = value; }
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