using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Atish Appadu
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Atish";
        private readonly List<post> posts;


        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<post>();
            MessagePost post = new MessagePost(AUTHOR, "Programming is great!");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "image1.jpg", "Mountains");
            AddPhotoPost(photoPost);
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }


        }

        public void FindUser(string user)
        {
            int counter = 0;
            foreach (post Post in posts)
            {
                if (Post.Username == user)
                {
                    Post.Display();
                    Console.WriteLine();
                    counter++;
                }
                if (counter == 0)
                {
                    Console.WriteLine("\n This User does not Exist in the current context");
                }

            }
        }
        ///<summary>
        ///This function is to find a post by using the ID 
        /// </summary>
        /// <param name="id"></param>
        public void FindID(int id)
        {
            int counter = 0;
            foreach (post Post in posts)
            {
                if (Post.PostID == id)
                {
                    posts.Remove(Post);
                    Console.WriteLine("You have removed your Post");
                    return;
                    counter++;
                }
            }
        }
        ///<summary>
        ///This function is to fina a post by id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public post FindPost(int id)
        {
            foreach (post Post in posts)
            {
                if (id == post.PostID)
                {
                    return post;
                }
            }
            return null;
        }
    }

}