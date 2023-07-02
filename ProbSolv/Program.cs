using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace ProbSolv
{
    class Program
    {

        static void Main(string[] args)
        {

            PostDatabase db = new PostDatabase();
            List<string> newPosts = new List<string>();
            newPosts.Add("original post");
            newPosts.Add("#tag post");
            newPosts.Add("@mention post");
            newPosts.Add("http post");

            Post postObj;
            foreach (var post in newPosts)
            {
                if (post.StartsWith("#"))
                {
                    postObj = new TagPost();
                }
                else if (post.StartsWith("#"))
                {
                    postObj = new MentionPost();
                }
                else if (post.StartsWith("http"))
                {
                    postObj = new LinkPost();
                }
                else
                {
                    postObj = new Post();
                }

                string result = postObj.CreatePost(db, post);
                Console.WriteLine(result);
            }

            Console.ReadKey();
            //Console.WriteLine(Tet("abcd"));
            
            //string str = "ALi";

            //string str2 = "";

            //for (int i = str.Length - 1; i > -1; i--)
            //{
            //     str2 += str[i];
            //}

            //Console.WriteLine(str2);
            //Console.WriteLine(str.Length - 1);



            //string x = "abcd";
            //d                                // bc               // a
            //Console.WriteLine(x.Substring(x.Length - 1) + x.Substring(1, x.Length - 2) + x.Substring(0, 1));

            //string z = "xy";
            //y                                 //                     // x
            //Console.WriteLine(z.Substring(z.Length - 1) + z.Substring(1, z.Length - 2) + z.Substring(0, 1));

            //string me = "yahya";

            //Console.WriteLine(me.Substring(me.Length - 1) + me.Substring(1, me.Length - 2) + me.Substring(0, 1));

            //Console.WriteLine(char.ToUpper(me[0]) + me.Substring(1)); 


            Console.ReadLine();
        }

        //public static string Tet(string str)
        //{
        //    string ss = " ";

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        ss += str.Substring(0, i + 1);
        //    }
        //    return ss;
        //}

        
               

    }
}
