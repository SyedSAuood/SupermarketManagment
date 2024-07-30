namespace SupermarketManagment.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId = 1 , Name = "Beverage" , Description= "Beverage"},
            new Category { CategoryId = 2 , Name = "Bakery" , Description= "Bakery"},
            new Category { CategoryId = 3 , Name = "Meat" , Description= "Meat"},

        };


        public static void  AddCategory(Category category)
        {
            var maxid = _categories.Max(c => c.CategoryId);
            category.CategoryId = maxid = 1;
            _categories.Add(category);
        }


        public static List<Category> GetCategories() { return _categories; }

        public static Category? GetCategoryByID(int categoryid)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryid);
            
            if(category != null)
            {
                return new Category
                { 
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description,
                };

            }

            return null;
        }


        public static void UpdateCategories(int categoryid, Category updatedcategory)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryid);

            if(category != null )
            {
                category.CategoryId = categoryid;
                category.Name = updatedcategory.Name;
                category.Description = updatedcategory.Description;
            }
        }


        public static void DeleteCategory(int categoryid)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryid);

            if(category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}
