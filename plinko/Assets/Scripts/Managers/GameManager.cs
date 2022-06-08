using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace PLINKO
{

    /// <summary>
    /// @gObj === GameManager ===
    /// 
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        // ==== singleton
        private static GameManager s_instance;
        public static GameManager Instance { get { return s_instance; } }

        // ==== Global utilities
        public bool m_canAddDisc = false;
        public bool m_gameOver = false;

        // ==== refs
        [SerializeField] private TextMeshProUGUI m_coinsText;
        [SerializeField] private TextMeshProUGUI m_livesText;
        [SerializeField] private GameObject m_gameOverPanel;

        // ==== vars
        private int m_score;
        private int m_lives;
        


        private void Awake()
        {
            // singleton
            if (s_instance != null && s_instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                s_instance = this;
            }
            // DontDestroyOnLoad(gameObject);
        }


        // Start is called before the first frame update
        void Start()
        {
            SetUpNewGame();
        }

        private void SetUpNewGame()
        {
            m_gameOver = false;
            m_gameOverPanel.SetActive(false);
            m_score = 0;
            m_lives = 3;
            UpdateLivesText();
            UpdateCoinsText();
            m_canAddDisc = true;
        }

        private void UpdateLivesText()
        {
            m_livesText.text = $"x {m_lives}";
        }

        private void UpdateCoinsText()
        {
            m_coinsText.text = $"{m_score}";
        }

        public void AddScore(int score)
        {
            m_score += score;
            UpdateCoinsText();
        }

        public void DecreaseLives() 
        {
            m_lives--;
            UpdateLivesText();
            if (m_lives > 0)
            {
                m_canAddDisc = true;
            }
            else
            {  
                if(!m_gameOver) AudioManager.Instance.Play("gameOver");
                m_gameOver = true;
                m_canAddDisc = false;
                m_gameOverPanel.SetActive(true);
                // print("GAME OVER");
            }

        }


    }


} // SNAKE namespace
