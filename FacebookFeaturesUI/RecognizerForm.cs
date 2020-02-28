using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookFeaturesLogic;

namespace FacebookFeaturesUI
{
    public partial class RecognizerForm : VisitableForm
    {
        private const int k_OneLife = 1;
        private const int k_ThreeLives = 3;
        private const int k_NoLives = 0;
        private FacebookFeatures m_FacebookFeatures;
        private User m_LoggedUser;

        public RecognizerForm(User i_LoggedUser)
        {
            InitializeComponent();
            m_LoggedUser = i_LoggedUser;
            m_FacebookFeatures = new FacebookFeatures(m_LoggedUser);
            initializeRecognizerGame();
        }

        private void RecognizerForm_Shown(object sender, EventArgs e)
        {
            pictureBoxGuess.Image = m_FacebookFeatures.GetRecognizerFriendsProfile();
            pictureBoxGuess.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGif.Visible = false;
            textBoxHints.Text = m_FacebookFeatures.RecognizerHintsAmount().ToString();
            textBoxLives.Text = m_FacebookFeatures.GetRecognizerLives().ToString();
            textBoxScore.Text = m_FacebookFeatures.RecognizerGetScore().ToString();
            textBoxHint.Text = string.Empty;
            textBoxHint.Visible = false;
            labelPattern.Text = m_FacebookFeatures.GetRecognizerPattern();
        }

        private void RecognizerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Instance.Visible = true;
        }

        private void buttonLuckyGuess_Click(object sender, EventArgs e)
        {
            m_FacebookFeatures.GuessFullName(textBoxLuckyGuess.Text);
            textBoxLives.Text = m_FacebookFeatures.GetRecognizerLives().ToString();
            textBoxLuckyGuess.Text = string.Empty;
            this.Validate();
        }

        private void performGuess(object sender, EventArgs e)
        {
            string oldLabelText = labelPattern.Text;
            m_FacebookFeatures.GuessLetter((sender as Button).Text[0]);
            labelPattern.Text = m_FacebookFeatures.GetRecognizerPattern();
            if (oldLabelText.Equals(labelPattern.Text))
            {
                pictureBoxGif.Image = Properties.Resources.OrangeAjarIriomotecat_size_restricted;
                pictureBoxGif.Visible = true;
            }

            textBoxLives.Text = m_FacebookFeatures.GetRecognizerLives().ToString();
            this.Validate();
        }

        private void initializeRecognizerGame()
        {
            m_FacebookFeatures.RecognizerReducedLives += m_RecognizerReducedLives;
            m_FacebookFeatures.RecognizerGameOver += m_RecognizerGameOver;
            m_FacebookFeatures.RecognizerWin += m_RecognizerGameWin;
            m_FacebookFeatures.RecognizerCorrectGuess += m_CorrectGuess;
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            string hintValue = string.Empty;
            string hint = m_FacebookFeatures.RecognizerHint();

            if (m_FacebookFeatures.RecognizerHintsAmount() > 0)
            {
                if (hint.Equals("Gender"))
                {
                    hintValue = m_FacebookFeatures.GetRecognizerFriendsGender();
                }
                else
                {
                    hintValue = m_FacebookFeatures.GetRecognizerFriendsBirthday();
                }

                textBoxHints.Text = m_FacebookFeatures.RecognizerHintsAmount().ToString();
                textBoxHint.Text = hint + ": " + hintValue;
                textBoxHint.Visible = true;
            }
            else
            {
                MessageBox.Show("No hints left!");
            }
        }

        private void m_CorrectGuess(object sender, EventArgs e)
        {
            pictureBoxGif.Image = Properties.Resources.tenor;
            pictureBoxGif.Visible = true;
        }

        private void m_RecognizerGameWin(object sender, EventArgs e)
        {
            pictureBoxGif.Image = Properties.Resources.sameh;
            pictureBoxGif.Visible = true;
            DialogResult result = MessageBox.Show(
string.Format(
@"Good job!
You know your friends very well!
Do you want another round?"),
"Correct Guess",
MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                m_FacebookFeatures.PlayNewGame();
                this.RecognizerForm_Shown(this, null);
            }
            else
            {
                this.Close();
            }
        }

        private void m_RecognizerGameOver(object sender, EventArgs e)
        {
            pictureBoxGif.Image = Properties.Resources.bohe;
            DialogResult result = MessageBox.Show(
string.Format(
@"The game is over!
Do you want another round?"),
"GAME OVER",
MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                m_FacebookFeatures.PlayNewGame();
                this.RecognizerForm_Shown(this, null);
            }
            else
            {
                this.Close();
            }
        }

        private void m_RecognizerReducedLives(object sender, EventArgs e)
        {
            string message = string.Empty;

            if (m_FacebookFeatures.GetRecognizerLives() == k_OneLife)
            {
                message = string.Format("Oh no! Only 1 more chance!\nTake a hint..\n");
                MessageBox.Show(message);
            }
            else if (m_FacebookFeatures.GetRecognizerLives() == k_ThreeLives)
            {
                message = string.Format("Oh no! Only 3 more chance!\nTake a hint..\n");
                MessageBox.Show(message);
            }
            else if (m_FacebookFeatures.GetRecognizerLives() == k_NoLives)
            {
                m_RecognizerGameOver(this, null);
            }
        }
    }
}
