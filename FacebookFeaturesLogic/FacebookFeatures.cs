using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookFeaturesLogic
{
    public class FacebookFeatures
    {
        private readonly Game m_Recognizer;
        private Analyzer m_Analyzer;

        public event EventHandler RecognizerReducedLives;

        public event EventHandler RecognizerGameOver;

        public event EventHandler RecognizerWin;

        public event EventHandler RecognizerCorrectGuess;

        public FacebookFeatures(User i_LoggedInUser)
        {
            m_Analyzer = new Analyzer(i_LoggedInUser);
            m_Recognizer = new Game(i_LoggedInUser);
            initializeRecognizerGame();
        }

        private void initializeRecognizerGame()
        {
            m_Recognizer.ReducedLives += m_RecognizerReducedLives;
            m_Recognizer.GameOver += m_RecognizerGameOver;
            m_Recognizer.Win += m_RecognizerGameWin;
            m_Recognizer.CorrectGuess += m_RecognizerCorrectGuess;
        }

        private void m_RecognizerCorrectGuess(object sender, EventArgs e)
        {
            OnRecognizerCorrectGuess(sender, e);
        }

        protected virtual void OnRecognizerCorrectGuess(object sender, EventArgs e)
        {
            if (RecognizerCorrectGuess != null)
            {
                RecognizerCorrectGuess.Invoke(sender, e);
            }
        }

        private void m_RecognizerGameWin(object sender, EventArgs e)
        {
            OnGuessWhoWin(sender, e);
        }

        protected virtual void OnGuessWhoWin(object sender, EventArgs e)
        {
            if (RecognizerWin != null)
            {
                RecognizerWin.Invoke(sender, e);
            }
        }

        private void m_RecognizerGameOver(object sender, EventArgs e)
        {
            OnRecognizerGameOver(sender, e);
        }

        protected virtual void OnRecognizerGameOver(object sender, EventArgs e)
        {
            if (RecognizerGameOver != null)
            {
                RecognizerGameOver.Invoke(sender, e);
            }
        }

        private void m_RecognizerReducedLives(object sender, EventArgs e)
        {
            OnRecognizerReducedLives(sender, e);
        }

        protected virtual void OnRecognizerReducedLives(object sender, EventArgs e)
        {
            if (RecognizerReducedLives != null)
            {
                RecognizerReducedLives.Invoke(sender, e);
            }
        }

        public void PlayNewGame()
        {
            m_Recognizer.PlayAnotherRound();
        }

        public int GetRecognizerLives()
        {
            return m_Recognizer.m_Lives;
        }

        public string GetRecognizerFriendsBirthday()
        {
            return m_Recognizer.m_FriendsBirthday;
        }

        public string GetRecognizerFriendsGender()
        {
            return m_Recognizer.m_FriendsGender;
        }

        public string GetRecognizerFriendsName()
        {
            return m_Recognizer.m_FriendsName;
        }

        public string GetRecognizerPattern()
        {
            return m_Recognizer.m_GamePattern;
        }

        public Image GetRecognizerFriendsProfile()
        {
            return m_Recognizer.m_FriendsProfilePic;
        }

        public void GuessLetter(char i_InputLetter)
        {
            m_Recognizer.GuessLetter(i_InputLetter);
        }

        public void GuessFullName(string i_Text)
        {
            m_Recognizer.GuessFullName(i_Text);
        }

        public string RecognizerHint()
        {
            return m_Recognizer.GetHint();
        }

        public int RecognizerHintsAmount()
        {
            return m_Recognizer.m_Hints;
        }

        public int RecognizerGetScore()
        {
            return m_Recognizer.m_Score;
        }

        public void PostToUser(string i_SelectedItem)
        {
            m_Analyzer.PostUser(i_SelectedItem);
        }

        public FacebookObjectCollection<User> GetNotActiveAnalyzer()
        {
            return m_Analyzer.GetNotActiveUsers();
        }

        public FacebookObjectCollection<User> GetActiveAnalyzer()
        {
            return m_Analyzer.GetActiveUsers();
        }

        public void GetFriendPosts(User i_SelectedItem, ref List<Post> io_Posts)
        {
            m_Analyzer.GetFriendPosts(i_SelectedItem, ref io_Posts);
        }

        public ImageList GetFriendImages(User i_SelectedItem, ref ImageList io_ImageList)
        {
            return m_Analyzer.GetFriendImages(i_SelectedItem, ref io_ImageList);
        }

        public void LikeImages(string i_SelectedItem)
        {
            m_Analyzer.LikeImages(i_SelectedItem);
        }

        public void LikePosts(string i_SelectedItem)
        {
            m_Analyzer.LikePosts(i_SelectedItem);
        }
    }
}
