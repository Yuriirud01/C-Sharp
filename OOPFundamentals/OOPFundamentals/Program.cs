using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace OOPFundamentals // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var post = new StackOverflowPost("Best Film", "I think the best film is Godfather 2");
            post.MakeVote("Up");
            post.MakeVote("Up");
            post.MakeVote("down");
            post.GetPost();
            post.GetVotes();
        }
    }
}
