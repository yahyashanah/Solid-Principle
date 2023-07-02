using System;
using System.Collections.Generic;
using System.Text;

namespace ProbSolv
{
    public class PostDatabase
    {
        public string Add(string post)
        {
            return "Original Post: " + post;
        }
        public string AddTagPost(string post)
        {
            return "Tag Post: " + post;
        }
        public string AddMentionPost(string post)
        {
            return "Mention Post: " + post;
        }
        public string AddLinkPost(string post)
        {
            return "Link Post: " + post;
        }
    }
}
