using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6_FinalExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Instructions
                When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
                - If no one likes your post, it doesn't display anything.
                - If only one person likes your post, it displays: [Friend's Name] likes your post.
                - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
                - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
                Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
                Depending on the number of names provided, display a message based on the above pattern.
             */

            var users = new List<string>();

            while (true)
            {
                Console.WriteLine("Please add a name:");
                var userInput = Console.ReadLine().ToString();
                
                if (userInput == "")
                {
                    break;
                }
                else
                {
                    users.Add(userInput);
                    continue;
                }
            }

            var totalLikes = users.Count();

            switch (totalLikes)
            {
                case 0:
                    Console.WriteLine("{0} Likes", totalLikes);
                    break;
                case 1:
                    Console.WriteLine("{0} liked your post", users[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} liked your post", users[0],users[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1}, and {2} others liked your post", users[0], users[1], totalLikes-2);
                    break;
            }
        }
    }
}
