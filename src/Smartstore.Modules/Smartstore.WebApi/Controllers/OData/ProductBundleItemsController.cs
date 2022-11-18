﻿using Smartstore.Core.Catalog.Products;

namespace Smartstore.Web.Api.Controllers.OData
{
    /// <summary>
    /// The endpoint for operations on ProductBundleItem entity.
    /// </summary>
    public class ProductBundleItemsController : WebApiController<ProductBundleItem>
    {
        [HttpGet, ApiQueryable]
        [Permission(Permissions.Catalog.Product.Read)]
        public IQueryable<ProductBundleItem> Get()
        {
            return Entities.AsNoTracking();
        }

        [HttpGet, ApiQueryable]
        [Permission(Permissions.Catalog.Product.Read)]
        public SingleResult<ProductBundleItem> Get(int key)
        {
            return GetById(key);
        }

        [HttpGet, ApiQueryable]
        [Permission(Permissions.Catalog.Product.Read)]
        public SingleResult<Product> GetProduct(int key)
        {
            return GetRelatedEntity(key, x => x.Product);
        }

        [HttpGet, ApiQueryable]
        [Permission(Permissions.Catalog.Product.Read)]
        public SingleResult<Product> GetBundleProduct(int key)
        {
            return GetRelatedEntity(key, x => x.BundleProduct);
        }

        [HttpPost]
        [Permission(Permissions.Catalog.Product.EditBundle)]
        public Task<IActionResult> Post([FromBody] ProductBundleItem entity)
        {
            return PostAsync(entity);
        }

        [HttpPut]
        [Permission(Permissions.Catalog.Product.EditBundle)]
        public Task<IActionResult> Put(int key, Delta<ProductBundleItem> model)
        {
            return PutAsync(key, model);
        }

        [HttpPatch]
        [Permission(Permissions.Catalog.Product.EditBundle)]
        public Task<IActionResult> Patch(int key, Delta<ProductBundleItem> model)
        {
            return PatchAsync(key, model);
        }

        [HttpDelete]
        [Permission(Permissions.Catalog.Product.EditBundle)]
        public Task<IActionResult> Delete(int key)
        {
            return DeleteAsync(key);
        }
    }
}