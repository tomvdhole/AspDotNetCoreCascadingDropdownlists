using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreCascadingDropdownlists.Models
{
    public class SelectProductViewModel
    {
        public SelectProductViewModel(IEnumerable<Category> categories, IEnumerable<SubCategory> subCategories, IEnumerable<Product> products)
        {
            if (categories != null)
            {
                ((IList<SelectListItem>)Categories).Add(new SelectListItem { Value = "0", Text = "Select" });
                foreach (var category in categories)
                    ((IList<SelectListItem>)Categories).Add(new SelectListItem { Value = category.CategoryId.ToString(), Text = category.CategoryName });

                ((IList<SelectListItem>)SubCategories).Add(new SelectListItem { Value = "0", Text = "Select" });

                ((IList<SelectListItem>)Products).Add(new SelectListItem { Value = "0", Text = "Select" });
            }

            if (subCategories != null)
            {
                ((IList<SelectListItem>)SubCategories).Add(new SelectListItem { Value = "0", Text = "Select" });
                foreach (var subCategory in subCategories)
                    ((IList<SelectListItem>)SubCategories).Add(new SelectListItem { Value = subCategory.SubCategoryId.ToString(), Text = subCategory.SubCategoryName });
            }

            if (products != null)
            {
                ((IList<SelectListItem>)Products).Add(new SelectListItem { Value = "0", Text = "Select" });
                foreach (var product in products)
                    ((IList<SelectListItem>)Products).Add(new SelectListItem { Value = product.ProductId.ToString(), Text = product.ProductName });
            }
        }

        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        public int SubCategoryId { get; set; }
        public IEnumerable<SelectListItem> SubCategories { get; set; } = new List<SelectListItem>();
        public int ProductId { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; } = new List<SelectListItem>();
    }
}
