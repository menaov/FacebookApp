using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookFeaturesLogic
{
    public class Analyzer
    {
        private User m_LoggedInUser;
        private Dictionary<string, User> m_Friends;

        public Analyzer(User i_LoggedUser)
        {
            FacebookService.s_CollectionLimit = 20;
            m_LoggedInUser = i_LoggedUser;
            m_Friends = new Dictionary<string, User>();
        }

        public FacebookObjectCollection<User> GetNotActiveUsers()
        {
            FacebookObjectCollection<User> friends = m_LoggedInUser.Friends;
            FacebookObjectCollection<User> notActiveFriends = new FacebookObjectCollection<User>();
            bool activeUser = false;

            foreach (User u in friends)
            {
                foreach (Post p in u.Posts)
                {
                    if (p.CreatedTime.Value.Year.Equals(DateTime.Today.Year))
                    {
                        activeUser = true;
                    }
                }

                if (!activeUser)
                {
                    notActiveFriends.Add(u);
                    m_Friends.Add(u.FirstName + " " + u.LastName, u);
                }

                activeUser = false;
            }

            return notActiveFriends;
        }

        public FacebookObjectCollection<User> GetActiveUsers()
        {
            FacebookObjectCollection<User> activeUsers = new FacebookObjectCollection<User>();
            User activeUser = mostPictures();

            if (activeUser != null)
            {
                activeUsers.Add(activeUser);
            }

            activeUser = mostPosts();
            if (!activeUsers.Contains(activeUser) && activeUser != null)
            {
                activeUsers.Add(activeUser);
            }

            return activeUsers;
        }

        private User mostPosts()
        {
            FacebookObjectCollection<User> friends = m_LoggedInUser.Friends;
            User activeUser = null;
            int countPost = 0, maxCount = 0;
            string key = string.Empty;

            try
            {
                foreach (User u in friends)
                {
                    foreach (Post p in u.Posts)
                    {
                        if (p.CreatedTime.Value.Year < DateTime.Today.Year)
                        {
                            break;
                        }

                        if (p.CreatedTime.Value.Year.Equals(DateTime.Today.Year))
                        {
                            countPost++;
                        }
                    }

                    if (maxCount < countPost)
                    {
                        activeUser = u;
                        maxCount = countPost;
                    }

                    if (countPost > 0)
                    {
                        key = u.FirstName + " " + u.LastName;
                        if (!m_Friends.ContainsKey(key))
                        {
                            m_Friends.Add(key, u);
                        }
                    }

                    countPost = 0;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            if (activeUser == null)
            {
                return null;
            }

            return activeUser;
        }

        private User mostPictures()
        {
            FacebookObjectCollection<User> friends = m_LoggedInUser.Friends;
            User activeUser = null;
            int countPicture = 0, maxCount = 0;
            string key = string.Empty;

            try
            {
                foreach (User u in friends)
                {
                    foreach (Album a in u.Albums)
                    {
                        foreach (Photo p in a.Photos)
                        {
                            if (p.CreatedTime.Value.Year < DateTime.Today.Year)
                            {
                                break;
                            }

                            if (p.CreatedTime.Value.Year.Equals(DateTime.Today.Year))
                            {
                                countPicture++;
                            }
                        }

                        if (maxCount < countPicture)
                        {
                            activeUser = u;
                            maxCount = countPicture;
                        }

                        if (countPicture > 0)
                        {
                            key = u.FirstName + " " + u.LastName;
                            if (!m_Friends.ContainsKey(key))
                            {
                                m_Friends.Add(key, u);
                            }
                        }

                        countPicture = 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            if (activeUser == null)
            {
                return null;
            }

            return activeUser;
        }

        public void PostUser(string i_ToPost)
        {
            m_LoggedInUser.PostStatus("Whats up?", null, null, m_Friends[i_ToPost].Id, null, null);
        }

        public void GetFriendPosts(User i_ActiveUser, ref List<Post> io_Posts)
        {
            bool hasValue = m_Friends.ContainsValue(i_ActiveUser);
            if (hasValue == true)
            {
                try
                {
                    foreach (Post p in i_ActiveUser.Posts)
                    {
                        if (io_Posts.Count.Equals(20))
                        {
                            break;
                        }

                        if (!string.IsNullOrEmpty(p.Message))
                        {
                            io_Posts.Add(p);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public ImageList GetFriendImages(User i_ActiveUser, ref ImageList io_ImageList)
        {
            bool hasValue = m_Friends.ContainsValue(i_ActiveUser);

            if (hasValue == true)
            {
                try
                {
                    foreach (Album a in i_ActiveUser.Albums)
                    {
                        foreach (Photo p in a.Photos)
                        {
                            if (io_ImageList.Images.Count.Equals(20))
                            {
                                break;
                            }

                            io_ImageList.Images.Add(p.ImageNormal);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }

                io_ImageList.ImageSize = new Size(100, 100);
            }

            return io_ImageList;
        }

        public void LikeImages(string i_FriendName)
        {
            int count = 0;

            foreach (Album a in m_Friends[i_FriendName].Albums)
            {
                try
                {
                    foreach (Photo p in a.Photos)
                    {
                        p.Like();
                        count++;
                        if (count == 20)
                        {
                            break;
                        }
                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }

        public void LikePosts(string i_FriendName)
        {
            int count = 0;
            foreach (Post p in m_Friends[i_FriendName].Posts)
            {
                try
                {
                    p.Like();
                    count++;
                    if (count == 20)
                    {
                        break;
                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }
    }
}
