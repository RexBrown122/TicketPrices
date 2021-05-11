using System;

namespace TicketPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticketPrice = 0;
            User user1 = new User(15, true);
            //User user2 = new User(70, false);
            
            if (user1.isStudent)
            {

            }

            if (user1.age >= 0 || user1.age <= 12)
            {

            }
        }

        class User
        {
            public int age { get; set; }
            public bool isStudent { get; set; }

            public User(int _age, bool _isStudent)
            {
                age = _age;
                isStudent = _isStudent;
            }
        }
    }
}
