using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class ProductService() : IProductService
    {
        private readonly IProductRepository _productRepository = new ProductRepository();

        public void AddProduct(Product product)
        {
            try
            {
                _productRepository.AddProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in AddProduct method. " + ex.Message);
            }
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return _productRepository.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetAllProducts method. " + ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                _productRepository.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in UpdateProduct method. " + ex.Message);
            }
        }

        public List<Product> GetAllAvailableProducts()
        {
            try
            {
                return _productRepository.GetAllAvailableProducts();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetAllAvailableProducts method. " + ex.Message);
            }
        }

        public Product GetProduct(int productId)
        {
            try
            {
                return _productRepository.GetProduct(productId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetProduct method. " + ex.Message);
            }
        }
    }
}
