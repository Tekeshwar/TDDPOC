using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.App_Data
{
   public class Reservation
    {
       public User MadeBy { get; set; }
       /// <summary>
       /// Admin and user can cancel reservatoin (ture) and other can not (false)
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       public bool CanBeCancelledBy(User user)
       {
           return (user.IsAdmin || MadeBy == user);
       }
    }
}
