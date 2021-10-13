using TMPro;
using UnityEngine;

namespace Pong
{
    public class GameManager : MonoBehaviour
    {
        public int Player1Score;
        public int Player2Score;

        public TMP_Text Player1ScoreUI;
        public TMP_Text Player2ScoreUI;

        private void Start()
        {
            Player1ScoreUI.text = Player1Score.ToString();
            Player2ScoreUI.text = Player2Score.ToString();
        }

        public void Player1Scored()
        {
            print("Player 1 scored!");
            Player1Score++;
            Player1ScoreUI.text = Player1Score.ToString();
        }

        public void Player2Scored()
        {
            print("Player 2 scored!");
            Player2Score++;
            Player2ScoreUI.text = Player2Score.ToString();
        }
    }
}

