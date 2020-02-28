using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using SpeechLib;

namespace FacebookFeaturesUI
{
    public sealed partial class MainForm : Form
    {
        private static MainForm s_Instance = null;
        private static object s_LockObj = new object();
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private AppSettings m_AppSettings;

        private MainForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 20;
            buttonFetchData.Visible = false;
            buttonLogout.Enabled = false;
        }

        public static MainForm Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new MainForm();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            m_LoginResult = FacebookService.Login(
                                                "447911472574100",
                                                "public_profile",
                                                "email",
                                                "user_gender",
                                                "user_photos",
                                                "user_posts",
                                                "user_friends",
                                                "user_location",
                                                "user_birthday",
                                                "user_likes");
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                prepareAppAfterLogin();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void getUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            lblWelcome.Text = string.Format(
                @"Welcome {0} {1}!",
                m_LoggedInUser.FirstName,
                m_LoggedInUser.LastName);
            SpVoice speaker = new SpVoice();
            speaker.Speak(lblWelcome.Text);
            lblWelcome.Visible = true;
        }

        private void fetchImages()
        {
            if (!listViewImages.InvokeRequired)
            {
                new Thread(fillImages).Start();
            }
            else
            {
                listViewImages.Invoke(new Action(() => new Thread(fillImages).Start()));
            }
        }

        private void fillImages()
        {
            ImageList imageList = new ImageList();

            foreach (Album a in m_LoggedInUser.Albums)
            {
                foreach (Photo p in a.Photos)
                {
                    if (imageList.Images.Count.Equals(20))
                    {
                        break;
                    }

                    imageList.Images.Add(p.ImageNormal);
                }
            }

            foreach (Photo p in m_LoggedInUser.PhotosTaggedIn)
            {
                if (imageList.Images.Count == 20)
                {
                    break;
                }

                imageList.Images.Add(p.ImageNormal);
            }

            imageList.ImageSize = new Size(100, 100);
            listViewImages.Invoke(new Action(() => listViewImages.LargeImageList = imageList));
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                listViewImages.Invoke(new Action(() => listViewImages.Items.Add(string.Empty, i)));
            }
        }

        private void btnRecognizer_Click(object sender, EventArgs e)
        {
            IFormsVisitor colorChangeVisitor = new AutoChangeColorForm();

            if (m_LoggedInUser != null)
            {
                try
                {
                    VisitableForm recognizerForm = new RecognizerForm(m_LoggedInUser);
                    recognizerForm.Accept(colorChangeVisitor);
                    recognizerForm.Show();
                    this.Visible = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(string.Format("Facbook API doesn't support this function! \n\nCause: {0}", exception.Message));
                }
            }
            else
            {
                MessageBox.Show("Please Log In.");
            }
        }

        private void logoutUser()
        {
            if (m_LoggedInUser != null)
            {
                m_LoggedInUser = null;
            }

            listViewImages.Clear();
            listBoxAlbums.DataSource = null;
            nameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            birthdayTextBox.Text = string.Empty;
            panelAlbumDetails.Visible = false;
            birthdayLabel.Visible = false;
            emailLabel.Visible = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(logoutUser);
            pictureBoxProfile.Image = null;
            lblWelcome.Text = "Please login.";
            btnLogin.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_AppSettings = AppSettings.LoadFromFile();
            this.checkBoxRememberMe.Checked = m_AppSettings.m_RememberUser;
            listViewImages.View = View.LargeIcon;
            listViewImages.Columns.Add("Photos:", 400);
        }

        private void buttonFetchData_Click(object sender, EventArgs e)
        {
            albumBindingSource.DataSource = m_LoggedInUser.Albums;
            userBindingSource.DataSource = m_LoggedInUser;
            listBoxAlbums.DataSource = albumBindingSource.DataSource;
            listBoxAlbums.DisplayMember = "Name";
            panelAlbumDetails.Visible = true;
            birthdayLabel.Visible = true;
            emailLabel.Visible = true;
            MessageBox.Show(string.Format(
@"We are getting user data.
This may take some time so please be patient."));
            new Thread(fetchImages).Start();
            MessageBox.Show("Data loaded successfuly =)");
        }

        private void buttonAnalyzer_Click(object sender, EventArgs e)
        {
            IFormsVisitor colorChangeVisitor = new AutoChangeColorForm();

            if (m_LoggedInUser != null)
            {
                try
                {
                    VisitableForm analyzerForm = new AnalyzerForm(m_LoggedInUser);
                    analyzerForm.Accept(colorChangeVisitor);
                    analyzerForm.Show();
                    this.Visible = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(string.Format("Facbook API doesn't support this function! \n\nCause: {0}", exception.Message));
                }
            }
            else
            {
                MessageBox.Show("Please Log In.");
            }
        }

        private void startButtonsEffect()
        {
            btnRecognizer.StartEffect();
            buttonAnalyzer.StartEffect();
            buttonFetchData.StartEffect();
        }

        private void prepareAppAfterLogin()
        {
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            getUserInfo();
            buttonFetchData.Visible = true;
            buttonLogout.Enabled = true;
            startButtonsEffect();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_AppSettings.m_RememberUser)
            {
                this.Location = m_AppSettings.m_LastWindowLocation;
                try
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.m_LastAccessToken);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(
@"Operation terminated by server.
Reason{0}",
ex.Message));
                }

                btnLogin.Enabled = false;
                prepareAppAfterLogin();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppSettings.m_LastWindowLocation = this.Location;
            m_AppSettings.m_RememberUser = this.checkBoxRememberMe.Checked;

            if (m_AppSettings.m_RememberUser)
            {
                m_AppSettings.m_LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.m_LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();

            buttonLogout.PerformClick();
        }
    }
}
