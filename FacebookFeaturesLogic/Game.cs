using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using FacebookWrapper.ObjectModel;

namespace FacebookFeaturesLogic
{
    public class Game
    {
        private const int k_Lives = 5;
        private const int k_MinLives = 0;
        private const int k_NumOfHints = 2;
        private int m_AmountToGuess;
        private int m_GuessedLetters = 0;
        private User m_LoggedUser;
        private List<string> m_HintsOptions = new List<string>(3);

        public event EventHandler ReducedLives;

        public event EventHandler GameOver;

        public event EventHandler Win;

        public event EventHandler CorrectGuess;

        public Image m_FriendsProfilePic
        {
            get;
            private set;
        }

        public string m_FriendsGender
        {
            get;
            private set;
        }

        public string m_FriendsBirthday
        {
            get;
            private set;
        }

        public string m_FriendsName
        {
            get;
            private set;
        }

        public City m_FriendsHometown
        {
            get;
            private set;
        }

        public int m_Score
        {
            get;
            private set;
        }

        public int m_Lives
        {
            get;
            private set;
        }

        public int m_Hints
        {
            get;
            private set;
        }

        public string m_GamePattern
        {
            get;
            private set;
        }

        public Game(User i_UserLogged)
        {
            m_LoggedUser = i_UserLogged;
            initializeGame();
            m_Score = 0;
        }

        private void randomizeFriend()
        {
            int randIndex, index = 0;
            Random rand = new Random();

            randIndex = rand.Next(m_LoggedUser.Friends.Count);
            foreach (User friend in m_LoggedUser.Friends)
            {
                if (randIndex == index)
                {
                    setFriendInfo(friend);
                }

                index++;
            }
        }

        private void setFriendInfo(User i_RandFriend)
        {
            m_FriendsProfilePic = i_RandFriend.ImageSmall;
            m_FriendsGender = i_RandFriend.Gender.ToString();
            m_FriendsBirthday = i_RandFriend.Birthday;
            m_FriendsName = i_RandFriend.Name;
            m_FriendsHometown = i_RandFriend.Hometown;
            m_AmountToGuess = m_FriendsName.Length;
        }

        private void initializeGame()
        {
            if (m_LoggedUser.Friends.Count == 0)
            {
                throw new Exception("Friends list is empty! Facebook API doesn't support friends list.");
            }

            randomizeFriend();
            m_Lives = k_Lives;
            m_Hints = k_NumOfHints;
            m_GuessedLetters = 0;
            if (m_HintsOptions.Count > 0)
            {
                m_HintsOptions.RemoveRange(k_MinLives, m_HintsOptions.Count);
            }

            m_HintsOptions.Add("Gender");
            m_HintsOptions.Add("Birthday");
            setStringPattern();
        }

        public string GetHint()
        {
            string resultHint;
            int randIndex;
            Random rand = new Random();
            randIndex = rand.Next(m_LoggedUser.Friends.Count - 1);
            resultHint = m_HintsOptions[randIndex];
            m_HintsOptions.Remove(m_HintsOptions[randIndex]);
            m_Hints -= 1;

            return resultHint;
        }

        private bool isNameContainsLetter(char i_Lettrer)
        {
            bool containsLowerLetter = m_FriendsName.Contains(char.ToLower(i_Lettrer).ToString());
            bool containsUpperLetter = m_FriendsName.Contains(char.ToUpper(i_Lettrer).ToString());

            if (containsLowerLetter || containsUpperLetter)
            {
                m_GuessedLetters++;
            }
            else
            {
                m_Lives--;
            }

            return containsLowerLetter || containsUpperLetter;
        }

        private void setStringPattern()
        {
            string pattern = m_FriendsName;

            pattern = Regex.Replace(pattern, "[a-z,A-Z]", "*");
            m_GamePattern = pattern;
        }

        private void updatePattern(char i_Letter)
        {
            StringBuilder updatedPattern = new StringBuilder();

            for (int i = 0; i < m_FriendsName.Length; i++)
            {
                if (char.ToLower(m_FriendsName[i]) == i_Letter || char.ToUpper(m_FriendsName[i]) == i_Letter)
                {
                    updatedPattern.Append(m_FriendsName[i]);
                }
                else
                {
                    updatedPattern.Append(m_GamePattern[i]);
                }
            }

            m_GamePattern = updatedPattern.ToString();
            if (!checkIfNameExposed(m_GamePattern))
            {
                OnCorrectGuess(this, new EventArgs());
            }
        }

        public void PlayAnotherRound()
        {
            initializeGame();
        }

        private bool checkIfNameExposed(string i_GuessedName)
        {
            bool isExposed = m_FriendsName.ToLower().Equals(i_GuessedName.ToLower());

            if (isExposed)
            {
                m_Score += m_Lives * m_Hints * m_AmountToGuess;
                OnWin(this, new EventArgs());
            }

            return isExposed;
        }

        private void reduceLives()
        {
            EventArgs e = new EventArgs();
            OnReducedLives(this, e);
        }

        public void GuessLetter(char i_Letter)
        {
            if (isNameContainsLetter(i_Letter))
            {
                updatePattern(i_Letter);
            }
            else
            {
                reduceLives();
            }
        }

        public void GuessFullName(string i_GuessedName)
        {
            if (!checkIfNameExposed(i_GuessedName))
            {
                reduceLives();
            }
            else
            {
                m_GamePattern = m_FriendsName;
            }
        }

        protected virtual void OnCorrectGuess(object sender, EventArgs e)
        {
            if (CorrectGuess != null)
            {
                CorrectGuess.Invoke(sender, e);
            }
        }

        protected virtual void OnReducedLives(object sender, EventArgs e)
        {
            if (ReducedLives != null)
            {
                ReducedLives.Invoke(sender, e);
            }
        }

        protected virtual void OnWin(object sender, EventArgs e)
        {
            if (Win != null)
            {
                Win.Invoke(sender, e);
            }
        }
    }
}
