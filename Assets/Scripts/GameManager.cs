using System.Collections;
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

        public TMP_Text CountdownText;
        
        [SerializeField]
        private Ball _ball;

        [SerializeField]
        private Paddle _player1;

        [SerializeField]
        private Paddle _player2;

        [Range(1, 3)]
        
        [SerializeField]
        private int _numberOfSeconds;

        private WaitForSeconds _timeToWait;
        
        private void Start()
        {
            Player1ScoreUI.text = Player1Score.ToString();
            Player2ScoreUI.text = Player2Score.ToString();

            _timeToWait = new WaitForSeconds(1);
            StartCoroutine(Run());
        }

        private IEnumerator Run()
        {
            print("Run before");
            _ball.ResetPosition();

            _player1.ResetPosition();
            _player2.ResetPosition();

            CountdownText.text = _numberOfSeconds.ToString();
            CountdownText.gameObject.SetActive(true);

            for (int i = _numberOfSeconds; i > 0; i--)
            {
                CountdownText.text = i.ToString();
                yield return _timeToWait;
            }

            CountdownText.gameObject.SetActive(false);

            _ball.AddForceInRandomDirection();
            print("Run after");
        }

        public void Player1Scored()
        {
            print("Player 1 scored!");
            Player1Score++;
            Player1ScoreUI.text = Player1Score.ToString();

            // _ball.ResetPosition();
            // _ball.AddForceInRandomDirection();

            StopCoroutine(Run());
            StartCoroutine(Run());

        }

        public void Player2Scored()
        {
            print("Player 2 scored!");
            Player2Score++;
            Player2ScoreUI.text = Player2Score.ToString();

            // _ball.ResetPosition();
            // _ball.AddForceInRandomDirection();

            StopCoroutine(Run());
            StartCoroutine(Run());
        }
    }
}

