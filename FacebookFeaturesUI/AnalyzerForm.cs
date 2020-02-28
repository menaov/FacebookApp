using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookFeaturesLogic;

namespace FacebookFeaturesUI
{
    public partial class AnalyzerForm : VisitableForm
    {
        private User m_LoggedInUser;
        private Dictionary<string, User> m_Friends;
        private FacebookFeatures m_FacebookFeatures;

        public AnalyzerForm(User i_User)
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 20;
            m_LoggedInUser = i_User;
            initializeAnalyzer();
        }

        private void initializeAnalyzer()
        {
            m_FacebookFeatures = new FacebookFeatures(m_LoggedInUser);
            labelActiveUser.Visible = false;
            labelNonActiveUser.Visible = false;
            labelImages.Visible = false;
            labelPosts.Visible = false;
            listBoxActive.Visible = false;
            listBoxNotActive.Visible = false;
            listBoxPosts.Visible = false;
            buttonLikeImage.Visible = false;
            buttonLikePost.Visible = false;
            listViewImages.Visible = false;
            m_Friends = new Dictionary<string, User>();
            foreach (User u in m_LoggedInUser.Friends)
            {
                m_Friends.Add(u.Name, u);
            }
        }

        private void AnalyzerForm_Load(object sender, EventArgs e)
        {
            listViewImages.View = View.LargeIcon;
            listViewImages.Columns.Add("Photos:", 400);
        }

        private void buttonAnalyzer_Click(object sender, EventArgs e)
        {
            AnalyzedFriendsCollection notActiveFriends = null;
            AnalyzedFriendsCollection activeFriends = null;
            IEnumerator<string> userToAdd; 

            Thread threadNotActive = new Thread(() =>
            {
                try
                {
                    notActiveFriends = new AnalyzedFriendsCollection(m_FacebookFeatures.GetNotActiveAnalyzer());
                }
                catch (Exception exc)
                {
                    MessageBox.Show(string.Format(
@"Operation terminated by server.
Reason: {0}",
exc.Message));
                }
            });
            Thread threadActive = new Thread(() =>
            {
                try
                {
                    activeFriends = new AnalyzedFriendsCollection(m_FacebookFeatures.GetActiveAnalyzer());
                }
                catch (Exception exc)
                {
                    MessageBox.Show(string.Format(
@"Operation terminated by server.
Reason: {0}",
    exc.Message));
                }
            });
            labelActiveUser.Visible = true;
            labelNonActiveUser.Visible = true;
            listBoxActive.Visible = true;
            listBoxNotActive.Visible = true;
            threadActive.Start();
            threadNotActive.Start();
            threadActive.Join();
            threadNotActive.Join();

            if (notActiveFriends != null)
            {
                userToAdd = notActiveFriends.GetEnumerator();
                while(userToAdd.MoveNext())
                {
                    listBoxNotActive.Invoke(new Action(() => listBoxNotActive.Items.Add(userToAdd.Current)));
                }
            }

            if (activeFriends != null)
            {
                userToAdd = activeFriends.GetEnumerator();
                while (userToAdd.MoveNext())
                {
                    listBoxActive.Invoke(new Action(() => listBoxActive.Items.Add(userToAdd.Current)));
                }
            }
        }

        private void AnalyzerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Instance.Visible = true;
        }

        private void listBoxNotActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
string.Format(
@"Do you want to post on this friend's wall?"),
"Connect Friend",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    m_FacebookFeatures.PostToUser((string)listBoxNotActive.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(
@"This feature is unavailable.
Reason: {0}",
ex.Message));
                }

                MessageBox.Show("Post published successfuly on friend's timeline");
            }
            else
            {
                MessageBox.Show("We recommend to contact unactive friends to filter them.");
            }
        }

        private void listBoxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelImages.Visible = true;
            labelPosts.Visible = true;
            listBoxPosts.Visible = true;
            listViewImages.Visible = true;
            buttonLikeImage.Visible = true;
            buttonLikePost.Visible = true;
            listViewImages.Visible = true;
            if (listBoxActive.SelectedItem == null)
            {
                MessageBox.Show(string.Format(
@"You selected a null value in the ListBox.
We don't allow that."));
                return;
            }

            MessageBox.Show(string.Format(
@"We are getting friend's data.
This may take some time so please be patient."));
            User toFetch = m_Friends[(string)listBoxActive.SelectedItem];
            new Thread(() => fetchImages(toFetch)).Start();
            new Thread(() => fetchPosts(toFetch)).Start();
            MessageBox.Show("Data loaded successfully! =)");
        }

        private void fetchPosts(User i_ToFetch)
        {
            if (!listBoxPosts.InvokeRequired)
            {
                new Thread(() => fillProxyPosts(i_ToFetch)).Start();
            }
            else
            {
                listBoxPosts.Invoke(new Action(() => new Thread(() => fillProxyPosts(i_ToFetch)).Start()));
            }
        }

        private void fillProxyPosts(User i_ToFetch)
        {
            List<Post> posts = new List<Post>();

            try
            {
                m_FacebookFeatures.GetFriendPosts(i_ToFetch, ref posts);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Operation terminated by server.
Reason: {0}",
e.Message));
            }

            foreach (Post p in posts)
            {
                PostProxy postProxy;

                postProxy = new PostProxy(p);
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(postProxy)));
            }
        }

        private void fetchImages(User i_ToFetch)
        {
            if (!listViewImages.InvokeRequired)
            {
                new Thread(() => fillImages(i_ToFetch)).Start();
            }
            else
            {
                listViewImages.Invoke(new Action(() => new Thread(() => fillImages(i_ToFetch)).Start()));
            }
        }

        private void fillImages(User i_Selected)
        {
            ImageList imageList = new ImageList();

            try
            {
                m_FacebookFeatures.GetFriendImages(i_Selected, ref imageList);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Operation terminated by server.
Reason: {0}",
e.Message));
            }

            for (int i = 0; i < imageList.Images.Count; i++)
            {
                listViewImages.Invoke(new Action(() =>
                {
                    listViewImages.LargeImageList = imageList;
                    listViewImages.Items.Add(string.Empty, i);
                }));
            }
        }

        private void performLike(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Equals(buttonLikeImage))
                {
                    m_FacebookFeatures.LikeImages((string)listBoxActive.SelectedItem);
                }
                else
                {
                    m_FacebookFeatures.LikePosts((string)listBoxActive.SelectedItem);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format(
@"This feature is unavailable.
Reason: {0}",
exception.Message));
            }
        }
    }
}
