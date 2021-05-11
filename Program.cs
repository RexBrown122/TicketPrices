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

      // if (user1.isStudent)
      // {

      // }

      // if (user1.age >= 0 || user1.age <= 12)
      // {

      // }

      try
      {
        if (user1.age >= 0 & user1.age <= 12)
        {
          // check if user is child
        }
        else if (user1.age >= 65)
        {
          // check if user is senior
        }
        else if (user1.isStudent)
        {
          // check for student
        }
        else if (user1.age >= 13 & user1.age <= 64)
        {
          // checks for regular person
        }
        else
        {
          // throw ex for neg or incorrect values
        }
      }
      catch (Exception ex)
      {
        throw ex;
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
