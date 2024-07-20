

using System.Threading.Tasks.Dataflow;
using System.Linq;
using System.Text.RegularExpressions;


namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region q1
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //var result = numbers.Aggregate(1, (acc, val) => acc * val);
            //Console.WriteLine(result);
            //Console.ReadLine();


            #endregion


            #region q2
            //List<string> words = new List<string> { "apple", "banana", "cherry" };
            //var result =String.Join( ',',words.Where(x => x.Contains(x)).ToArray());

            //Console.WriteLine(result);
            //Console.ReadLine();

            #endregion


            #region q3
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //var res = numbers.Select(x => x * x);
            //foreach (int i in res) { 
            //Console.Write(i+" ");
            //}

            #endregion


            #region Q4
            //List<string> words = new List<string> { "apple", "banana", "cherry" };


            //Dictionary<string, int> wordLengths = words.ToDictionary(word => word, word => word.Length);
            //foreach (var pair in wordLengths)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}


            #endregion


            #region q5
            //List<int> list1 = new List<int> { 1, 2, 3, 4 };
            //List<int> list2 = new List<int> { 3, 4, 5, 6 };
            // var commonElements = list1.Intersect(list2);
            //foreach (var item in commonElements)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region q6

            //List<Employee> employees = new List<Employee> 
            //{ new Employee("Ali", 60000), new Employee("Ramy", 45000),
            //   new Employee("Samy", 80000) };

            //var highestPaidEmployee = employees.OrderByDescending(e => e.Salary).FirstOrDefault();


            //    Console.WriteLine(highestPaidEmployee.Name);


            #endregion


            #region q7
            //List<Book> books = new List<Book> { new Book("Book1", "Author1"),
            //    new Book("Book2", "Author2"), new Book("Book3", "Author1") };


            //var groupedBooks = books.GroupBy(b => b.Author);
            //foreach (var group in groupedBooks)
            //{
            //    Console.WriteLine($"Books by {group.Key}:");
            //    foreach (var book in group)
            //    {
            //        Console.WriteLine($"- {book.Title}");
            //    }


            #endregion


            #region q8
            //    List<Sale> sales = new List<Sale>
            //{
            //    new Sale("Ali", 100),
            //    new Sale("Ramy", 200),
            //    new Sale("Ali", 150)
            //};


            //    var totalSalesBySalesperson = sales
            //        .GroupBy(s => s.Salesperson)
            //        .Select(group => new
            //        {
            //            Salesperson = group.Key,
            //            TotalSales = group.Sum(s => s.Amount)
            //        });

            //    foreach (var result in totalSalesBySalesperson)
            //    {
            //        Console.WriteLine($"Total sales amount for {result.Salesperson}: {result.TotalSales}");
            //    }

            #endregion

            #region q9


            //    List<Student> scores = new List<Student>
            //{
            //    new Student("Ali", "Math", 90),
            //    new Student("Ali", "Science", 85),
            //    new Student("Ramy", "Math", 80)
            //};

            //    // Using LINQ to group scores by student and find the highest score
            //    var res = scores
            //        .GroupBy(s => s.StudentName)
            //        .Select(group => new
            //        {
            //            StudentName = group.Key,
            //            HighestScore = group.Max(s => s.Score)
            //        });

            //    /
            //    foreach (var result in res)
            //    {
            //        Console.WriteLine($"Highest score for {result.StudentName}: {result.HighestScore}");
            //    }

            #endregion




            #region q10
            //    List<Order> orders = new List<Order>
            //{
            //    new Order(101, 50),
            //    new Order(102, 200),
            //    new Order(103, 150)
            //};

            //    // Using LINQ to calculate the average order price
            //    decimal averagePrice = orders.Average(o => o.Price);

            //    // Printing the average order price
            //    Console.WriteLine($"Average order price: {averagePrice}");


            #endregion




            #region q11
            //List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3 };


            //var res = numbers
            //    .GroupBy(n => n)
            //    .Select(g => (Number: g.Key, Frequency: g.Count()))
            //    .ToList();

            //Console.WriteLine("[");
            //foreach (var tuple in res)
            //{
            //    Console.WriteLine($"  ({tuple.Number}, {tuple.Frequency}),");
            //}
            //Console.WriteLine("]");

            #endregion



            #region q12


            //    List<string> words = new List<string> { "cat", "elephant", "dog", "tiger" };

            //    // Using LINQ to find the first string containing 'e'
            //    string result = words.FirstOrDefault(word => word.Contains('e'));

            //    // Printing the result
            //    Console.WriteLine(result); // Output: "elephant"
            //}
            #endregion


            #region q13

            //List<int> numbers = new List<int> { 1, 2, 3, 4 };

            //var result=numbers.Select((x,Index) => x*Index);

            //foreach (int x in result) { 
            //Console.Write(x+" ");

            //}


            #endregion


            #region q14
            //List<string> words = new List<string> { "apple", "banana" };
            //var result=words.SelectMany(x => x.ToCharArray().Distinct());

            //foreach (var word in result)
            //{
            //    Console.Write(word+",");
            //}


            #endregion


            #region q15
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            //var even=numbers.Count(x => x % 2 == 0);
            //var odd=numbers.Count(x => x % 2 == 1);


            //Console.WriteLine($"even :{even} , odd :{odd}");

            #endregion



            #region q16



            //List<Employee> employees = new List<Employee> { new Employee("Ali", "HR"), new Employee("Ramy", "IT"), 
            //    new Employee("Samy", "HR"), 
            //    new Employee("Sara", "IT"), new Employee("John", "IT") };



            //var res= employees
            //.GroupBy(e => e.dep)
            //.OrderByDescending(g => g.Count())
            //.FirstOrDefault();
            //Console.WriteLine($"{res.Key} : {res.Count()}");
            //Console.ReadKey();

            #endregion


            #region q17
            //  List<Product> products = new List<Product> { new Product("Laptop", "Electronics", 1000),
            //      new Product("Phone", "Electronics", 800), new Product("Shirt", "Clothing", 50),
            //      new Product("Pants", "Clothing", 60) };


            //  var res = products
            //.GroupBy(p => p.Category)
            //.Select(group => group.OrderByDescending(p => p.Price).First());


            //  foreach (var product in res)
            //  {
            //      Console.WriteLine($"Most expensive product in {product.Category}: {product.Name} (${product.Price})");
            //  }

            #endregion


            #region q18
            //List<Student> grades = new List<Student> { new Student("Ali", "Math", 90), new Student("Ali", "Science", 85),
            //    new Student("Ramy", "Math", 80),
            //    new Student("Ramy", "Science", 70) };


            //var res = grades
            //.GroupBy(g => g.StudentName)
            //.Select(group => new
            //{
            //    StudentName = group.Key,
            //    AverageGrade = group.Average(g => g.grade)
            //});

            //// Printing the average grade for each student
            //foreach (var result in res)
            //{
            //    Console.WriteLine($"Average grade for {result.StudentName}: {result.AverageGrade}");
            //}

            #endregion


            #region q19
            //    List<Transaction> transactions = new List<Transaction>
            //{
            //    new Transaction(new DateTime(2024, 1, 10), 100),
            //    new Transaction(new DateTime(2024, 1, 20), 200),
            //    new Transaction(new DateTime(2024, 2, 5), 150)
            //};


            //    var results = transactions
            //        .GroupBy(t => new { Month = t.TransactionDate.Month, Year = t.TransactionDate.Year })
            //        .Select(group => new
            //        {
            //            MonthYear = new DateTime(group.Key.Year, group.Key.Month, 1),
            //            TotalAmount = group.Sum(t => t.Amount)
            //        })
            //        .OrderBy(entry => entry.MonthYear);


            //    foreach (var result in results)
            //    {
            //        Console.WriteLine($"Total amount for {result.MonthYear.ToString("MMMM yyyy")}: {result.TotalAmount}");
            //    }
            #endregion



            #region q20
            List<Order> orders = new List<Order>
        {
            new Order(new DateTime(2024, 7, 10), 50),
            new Order(new DateTime(2024, 7, 15), 200),
            new Order(new DateTime(2024, 7, 16), 150)
        };

            // Calculate the date 7 days ago from today
            DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);

            // Using LINQ to filter orders within the last 7 days and sum the amounts
            decimal totalAmountLast7Days = orders
                .Where(o => o.OrderDate >= sevenDaysAgo)
                .Sum(o => o.Amount);

            // Printing the total order amounts for the last 7 days
            Console.WriteLine($"Order amounts for the last 7 days: {totalAmountLast7Days}");
        

        #endregion



    }
    }
}
