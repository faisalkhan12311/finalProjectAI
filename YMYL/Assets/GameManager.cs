using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{

    public class GameManager : MonoBehaviour
    {

        public int score;
        public PlayerS player;
        public Text scoreText, playerStatus, livesText;
        public GameObject gameOverPanel;

        //public Text scoreT, statusT;

        private void Update()
        {
            if (scoreText != null) scoreText.text = "Score: " + score;
            if (livesText != null) livesText.text = "Lives: " + player.livesLeft;
            //changing color and status text
            if (player.isDetected)
            {
                if (playerStatus != null) playerStatus.text = "Status: Detected";
                if (playerStatus != null) playerStatus.color = Color.red;
                //player.livesLeft--;
                if (livesText != null) livesText.text = "Lives: " + player.livesLeft;
                if (player.livesLeft <= 0)
                {
                    gameOverPanel.SetActive(true);
                    player.gameObject.GetComponent<FirstPersonController>().enabled = false;
                }
            }


            if (player.isHidden)
            {
                if (playerStatus != null) playerStatus.text = "Status: Hidden";
                if (playerStatus != null) playerStatus.color = Color.green;
            }

            else if (!player.isDetected && !player.isHidden)
            {
                if (playerStatus != null) playerStatus.text = "Status: Not Detected";
                if (playerStatus != null) playerStatus.color = Color.green;
            }
        }
        void EndGame()
        {
            Debug.Log("EndGame");

        }
    }
}