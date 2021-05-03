﻿using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Atish Appadu
    /// version 0.1
    /// </author>
    public class MessagePost : post 
    {


        // an arbitrarily long, multi-line message
        public String Message { get; }

       

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, String text): base(author)
        {
            Message = text;
        }

        public override void Display()
        {
            Console.WriteLine($" Message: {Message}");
        }
    }
}
