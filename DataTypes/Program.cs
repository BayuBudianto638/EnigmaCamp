//int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
//// Scalar return value
//int numberOfElements = fibonacci.Count();
//Console.WriteLine("Count: {0}", numberOfElements);
//// Output sequence return value
//IEnumerable<int> distinctNumbers = fibonacci.Distinct();
//Console.WriteLine("Elements in output sequence:");
//foreach (var number in distinctNumbers)
//{
//    Console.WriteLine(number);
//}


int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
// Construct the query 
IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2);
// At this point the query has been created but not executed
// Change the first element of the input sequence
fibonacci[0] = 99;
// Cause the query to be executed (enumerated)
foreach (var number in numbersGreaterThanTwoQuery)
{
    Console.WriteLine(number);
}


//int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
//// Construct the query 
//IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2)
// .ToArray();
//// At this point the query has been executed because of the .ToArray()
//// Change the first element of the input sequence
//fibonacci[0] = 99;
//// Enumerate the results
//foreach (var number in numbersGreaterThanTwoQuery)
//{
//    Console.WriteLine(number);
//}

//using System.Xml.Linq;

//var xml = @"
//<ingredients>
// <ingredient name='milk' quantity='200' price='2.99' />
// <ingredient name='sugar' quantity='100' price='4.99' />
// <ingredient name='safron' quantity='1' price='46.77' />
//</ingredients>";
//XElement xmlData = XElement.Parse(xml);
//XElement milk =
// xmlData.Descendants("ingredient")
// .First(x => x.Attribute("name").Value == "milk");

//XAttribute nameAttribute = milk.FirstAttribute; // name attribute
//XAttribute priceAttribute = milk.Attribute("price");
//string priceOfMilk = priceAttribute.Value; // 2.99
//XAttribute quantity = milk.Attributes()
// .Skip(1)
// .First(); // quantity attribute

//Console.WriteLine($"{quantity}");

//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//        {
//         new Ingredient{Name = "Sugar", Calories=500},
//         new Ingredient{Name = "Egg", Calories=100},
//         new Ingredient{Name = "Milk", Calories=150},
//         new Ingredient{Name = "Flour", Calories=50},
//         new Ingredient{Name = "Butter", Calories=200}
//        };

//        IEnumerable<string> highCalorieIngredientNamesQuery =
//                                                             ingredients.Where(x => x.Calories >= 150)
//                                                             .OrderBy(x => x.Name)
//                                                             .Select(x => x.Name);
//        foreach (var ingredientName in highCalorieIngredientNamesQuery)
//        {
//            Console.WriteLine(ingredientName);
//        }
//    }

//    class Ingredient
//    {
//        public string Name { get; set; }
//        public int Calories { get; set; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//        {
//         new Ingredient{Name = "Sugar", Calories=500},
//         new Ingredient{Name = "Egg", Calories=100},
//         new Ingredient{Name = "Milk", Calories=150},
//         new Ingredient{Name = "Flour", Calories=50},
//         new Ingredient{Name = "Butter", Calories=200}
//        };
//        IEnumerable<string> highCalorieIngredientNamesQuery =
//                                                             from i in ingredients
//                                                             where i.Calories >= 150
//                                                             orderby i.Name
//                                                             select i.Name;

//        foreach (var ingredientName in highCalorieIngredientNamesQuery)
//        {
//            Console.WriteLine(ingredientName);
//        }

//    }

//    class Ingredient
//    {
//        public string Name { get; set; }
//        public int Calories { get; set; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//        {
//         new Ingredient{Name = "Sugar", Calories=500},
//         new Ingredient{Name = "Egg", Calories=100},
//         new Ingredient{Name = "Milk", Calories=150},
//         new Ingredient{Name = "Flour", Calories=50},
//         new Ingredient{Name = "Butter", Calories=200}
//        };
//        IEnumerable<Ingredient> highCalDairyQuery =
//         from i in ingredients
//         let isDairy = i.Name == "Milk" || i.Name == "Butter"
//         where i.Calories >= 150 && isDairy
//         select i;
//        foreach (var ingredient in highCalDairyQuery)
//        {
//            Console.WriteLine(ingredient.Name);
//        }
//    }

//    class Ingredient
//    {
//        public string Name { get; set; }
//        public int Calories { get; set; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] csvRecipes =
//        {
//         "milk,sugar,eggs",
//         "flour,BUTTER,eggs",
//         "vanilla,ChEEsE,oats"
//        };

//        var dairyQuery =
//             from csvRecipe in csvRecipes
//             let ingredients = csvRecipe.Split(',')
//             from ingredient in ingredients
//             let uppercaseIngredient = ingredient.ToUpper()
//             where uppercaseIngredient == "MILK" ||
//             uppercaseIngredient == "BUTTER" ||
//             uppercaseIngredient == "CHEESE"
//             select uppercaseIngredient;

//        foreach (var dairyIngredient in dairyQuery)
//        {
//            Console.WriteLine("{0} is dairy", dairyIngredient);
//        }
//    }

//    class Ingredient
//    {
//        public string Name { get; set; }
//        public int Calories { get; set; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Ingredient[] ingredients =
//            {
//             new Ingredient{Name = "Sugar", Calories=500},
//             new Ingredient{Name = "Egg", Calories=100},
//             new Ingredient{Name = "Milk", Calories=150},
//             new Ingredient{Name = "Flour", Calories=50},
//             new Ingredient{Name = "Butter", Calories=200}
//            };
//        IEnumerable<Ingredient> highCalDairyQuery =
//         from i in ingredients
//         select new // anonymous type
//         {
//             OriginalIngredient = i,
//             IsDairy = i.Name == "Milk" || i.Name == "Butter",
//             IsHighCalorie = i.Calories >= 150
//         }
//         into temp
//         where temp.IsDairy && temp.IsHighCalorie
//         // cannot write "select i;" as into hides the previous range variable i
//         select temp.OriginalIngredient;

//        foreach (var ingredient in highCalDairyQuery)
//        {
//            Console.WriteLine(ingredient.Name);
//        }

//    }

//    class Ingredient
//    {
//        public string Name { get; set; }
//        public int Calories { get; set; }
//    }
//}


// Inner Join
//class Program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//             {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//            };

//        Review[] reviews =
//             {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//             };
//        var query = from recipe in recipes
//                    join review in reviews on recipe.Id equals review.RecipeId
//                    select new // anonymous type
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = review.ReviewText
//                    };
//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }
//    }

//    class Recipe
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//    }
//    class Review
//    {
//        public int RecipeId { get; set; }
//        public string ReviewText { get; set; }
//    }
//}

//// Group Join
//class program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//                {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//                };
//        Review[] reviews =
//                {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//                };

//        var query =
//         from recipe in recipes
//         join review in reviews on recipe.Id equals review.RecipeId
//         into reviewGroup
//         select new // anonymous type
//         {
//             RecipeName = recipe.Name,
//             Reviews = reviewGroup // collection of related reviews
//         };

//        foreach (var item in query)
//        {
//            Console.WriteLine("Reviews for {0}", item.RecipeName);
//            foreach (var review in item.Reviews)
//            {
//                Console.WriteLine(" - {0}", review.ReviewText);
//            }
//        }

//    }

//    class Recipe
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//    }

//    class Review
//    {
//        public int RecipeId { get; set; }
//        public string ReviewText { get; set; }
//    }
//}

// Left Outer Join Cara 1
//class program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//                {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//                };
//        Review[] reviews =
//                {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//                };

//        var query =
//                     from recipe in recipes.DefaultIfEmpty()
//                     join review in reviews on recipe.Id equals review.RecipeId
//                     //into reviewGroup
//                     //from rg in reviewGroup.DefaultIfEmpty()
//                     select new // anonymous type
//                     {
//                         RecipeName = recipe.Name,
//                         // RecipeReview = rg.ReviewText System.NullReferenceException
//                         RecipeReview = (review.ReviewText == null ? "n/a" : review.ReviewText)
//                     };
//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }

//    }

//    class Recipe
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//    }

//    class Review
//    {
//        public int RecipeId { get; set; }
//        public string ReviewText { get; set; }
//    }
//}

//// Left Outer Join Cara 2
//class program
//{
//    static void Main()
//    {
//        Recipe[] recipes =
//                {
//                 new Recipe {Id = 1, Name = "Mashed Potato"},
//                 new Recipe {Id = 2, Name = "Crispy Duck"},
//                 new Recipe {Id = 3, Name = "Sachertorte"}
//                };
//        Review[] reviews =
//                {
//                 new Review {RecipeId = 1, ReviewText = "Tasty!"},
//                 new Review {RecipeId = 1, ReviewText = "Not nice :("},
//                 new Review {RecipeId = 1, ReviewText = "Pretty good"},
//                 new Review {RecipeId = 2, ReviewText = "Too hard"},
//                 new Review {RecipeId = 2, ReviewText = "Loved it"}
//                };

//        var query =
//                     from recipe in recipes.DefaultIfEmpty()
//                     join review in reviews on recipe.Id equals review.RecipeId
//                     into reviewGroup
//                     from rg in reviewGroup.DefaultIfEmpty()
//                     select new // anonymous type
//                     {
//                         RecipeName = recipe.Name,
//                         // RecipeReview = rg.ReviewText System.NullReferenceException
//                         RecipeReview = (rg == null ? "n/a" : rg.ReviewText)
//                     };
//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }

//    }

//    class Recipe
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//    }

//    class Review
//    {
//        public int RecipeId { get; set; }
//        public string ReviewText { get; set; }
//    }
//}


//// Contoh 1
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;
//using Microsoft.EntityFrameworkCore;

//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();
//        var data = context.Students.ToList();

//        Console.WriteLine("Subject Result:");
//        foreach (var item in data)
//        {
//            Console.Write($"{item.StudentId} - {item.Name}");
//            Console.WriteLine();
//        }

//        Console.ReadKey();
//    }
//}

////// Contoh 1
////using DataTypes;
////using DataTypes.Model;
////using DataTypes.ModelData;
////class program
////{
////    static void Main()
////    {
////        var context = new SchoolContext();

////        var data = context.Students.AsEnumerable();

////        Console.WriteLine("Subject Result:");
////        foreach (var item in data)
////        {
////            Console.Write($"{item.StudentId} - {item.Name}");
////            Console.WriteLine();
////        }

////        Console.ReadKey();
////    }
////}

////// Contoh 1
////using DataTypes;
////using DataTypes.Model;
////using DataTypes.ModelData;
////class program
////{
////    static void Main()
////    {
////        var context = new SchoolContext();

////        var data = context.Students.AsQueryable();

////        Console.WriteLine("Subject Result:");
////        foreach (var item in data)
////        {
////            Console.Write($"{item.StudentId} - {item.Name}");
////            Console.WriteLine();
////        }

////        Console.ReadKey();
////    }
////}



//// Contoh 1
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;
//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
//        var data = (from a in context.Subjects
//                    join b in context.Students on a.StudentId equals b.StudentId
//                    join c in context.Courses on a.CourseId equals c.CourseId
//                    select new SubjectList
//                    {
//                        SubjectId = a.SubjectId,
//                        StudentName = b.Name,
//                        CourseName = c.CourseName
//                    }).ToList();

//        Console.WriteLine("Subject Result:");
//        foreach (var item in data)
//        {
//            Console.WriteLine($"{item.SubjectId} - {item.StudentName} - {item.CourseName}");
//        }

//        Console.ReadKey();
//    }
//}

////// Contoh 2
////// Using Where
////using DataTypes;
////using DataTypes.Model;
////using DataTypes.ModelData;

////class program
////{
////    static void Main()
////    {
////        var context = new SchoolContext();

////        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
////        var data = (from a in context.Subjects
////                    join b in context.Students on a.StudentId equals b.StudentId
////                    join c in context.Courses on a.CourseId equals c.CourseId
////                    select new SubjectList
////                    {
////                        SubjectId = a.SubjectId,
////                        StudentName = b.Name,
////                        CourseName = c.CourseName
////                    }).Where(w => w.StudentName == "Uchiha Itachi").ToList();

////        Console.WriteLine("Subject Result:");
////        foreach (var item in data)
////        {
////            Console.Write($"{item.SubjectId} - {item.StudentName} - {item.CourseName}");
////            Console.WriteLine();
////        }

////        Console.ReadKey();
////    }
////}

////// Contoh 3
////// Using FirstOrDefault
////using DataTypes;
////using DataTypes.Model;
////using DataTypes.ModelData;

////class program
////{
////    static void Main()
////    {
////        var context = new SchoolContext();

////        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
////        var data = (from a in context.Subjects
////                    join b in context.Students on a.StudentId equals b.StudentId
////                    join c in context.Courses on a.CourseId equals c.CourseId
////                    select new SubjectList
////                    {
////                        SubjectId = a.SubjectId,
////                        StudentName = b.Name,
////                        CourseName = c.CourseName
////                    }).FirstOrDefault(w => w.StudentName == "Uchiha Itachi");

////        Console.WriteLine("Subject Result:");

////        Console.Write($"{data.SubjectId} - {data.StudentName} - {data.CourseName}");
////        Console.WriteLine();

////        Console.ReadKey();
////    }
////}


////// Contoh 4 
////// Using Skip and Take - Biasanya digunakan untuk paging
////using DataTypes;
////using DataTypes.Model;
////using DataTypes.ModelData;

////class program
////{
////    static void Main()
////    {
////        var context = new SchoolContext();

////        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
////        var data = (from a in context.Subjects
////                    join b in context.Students on a.StudentId equals b.StudentId
////                    join c in context.Courses on a.CourseId equals c.CourseId
////                    select new SubjectList
////                    {
////                        SubjectId = a.SubjectId,
////                        StudentName = b.Name,
////                        CourseName = c.CourseName
////                    })
////                    .Skip(3)
////                    .Take(4)
////                    .ToList();

////        Console.WriteLine("Subject Result:");
////        foreach (var item in data)
////        {
////            Console.Write($"{item.SubjectId} - {item.StudentName} - {item.CourseName}");
////            Console.WriteLine();
////        }

////        Console.ReadKey();
////    }
////}

////// Contoh 5
////// Using Single and SingleOrDefault
////using DataTypes;
////using DataTypes.Model;
////using DataTypes.ModelData;

////class program
////{
////    static void Main()
////    {
////        var context = new SchoolContext();

////        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
////        var data = (from a in context.Subjects
////                    join b in context.Students on a.StudentId equals b.StudentId
////                    join c in context.Courses on a.CourseId equals c.CourseId
////                    select new SubjectList
////                    {
////                        SubjectId = a.SubjectId,
////                        StudentName = b.Name,
////                        CourseName = c.CourseName
////                    }).SingleOrDefault(w=>w.SubjectId == 1);

////        Console.WriteLine("Subject Result:");

////        Console.Write($"{data.SubjectId} - {data.StudentName} - {data.CourseName}");
////        Console.WriteLine();

////        Console.ReadKey();
////    }
////}


//// Contoh 3 Using Menu like basic Pascal/C++ Console
////class Program
////{
////    static void Main(string[] args)
////    {
////        bool showMenu = true;
////        while (showMenu)
////        {
////            showMenu = MainMenu();
////        }
////    }

////    private static bool MainMenu()
////    {
////        Console.Clear();
////        Console.WriteLine("Choose an option:");
////        Console.WriteLine("1) Create Student");
////        Console.WriteLine("2) Update Student");
////        Console.WriteLine("3) Exit");
////        Console.Write("\r\nSelect an option: ");

////        switch (Console.ReadLine())
////        {
////            case "1":
////                CreateStudent();
////                return true;
////            case "2":
////                UpdateStudent();
////                return true;
////            case "3":
////                return false;
////            default:
////                return true;
////        }
////    }

////    private static void CreateStudent()
////    {
////        Console.Clear();
////        Console.WriteLine("Create Student");
////        Console.ReadKey();
////    }

////    private static void UpdateStudent()
////    {
////        Console.Clear();
////        Console.WriteLine("Update Student");
////        Console.ReadKey();
////    }
////}