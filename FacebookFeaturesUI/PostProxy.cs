using FacebookWrapper.ObjectModel;

namespace FacebookFeaturesUI
{
    public class PostProxy
    {
        private Post m_Post;

        public string m_Link
        {
            get;
            private set;
        }

        public PostProxy(Post i_Post)
        {
            m_Post = i_Post;
            m_Link = i_Post.Link;
        }

        public override string ToString()
        {
            string postString;

            if (m_Post.Message != null)
            {
                postString = m_Post.Message;
            }
            else if (m_Post.Caption != null)
            {
                postString = m_Post.Caption;
            }
            else
            {
                postString = getPostDateAndTypeString(m_Post);
            }

            return postString;
        }

        private string getPostDateAndTypeString(Post i_Post)
        {
            return i_Post.Type + " " + i_Post.CreatedTime.ToString();
        }
    }
}
