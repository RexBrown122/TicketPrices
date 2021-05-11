using System;

namespace TicketPrices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user1 = new(-15, false);
            try
            {
                //int ticketPrice = 0;
                if (user1.Age < 0) throw new Exception();
                if (user1.Age <= 12)
                    user1.Price = 8;
                else if (user1.IsStudent)
                    user1.Price = 8;
                // check for student
                else if (user1.Age >= 65)
                    user1.Price = 10;
                // check if user is senior
                else if ((user1.Age >= 13) & (user1.Age <= 64))
                    user1.Price = 14;
                // checks for regular person
                else
                    throw new Exception("This is an Exception");
                // throw ex for neg or incorrect values
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (user1.Price > 0) Console.WriteLine(user1.Price);
            }
        }

        private class User
        {
            public User(int age, bool isStudent)
            {
                Age = age;
                IsStudent = isStudent;
            }

            public int Age { get; }
            public bool IsStudent { get; }
            public int Price { get; set; }
        }
    }
}