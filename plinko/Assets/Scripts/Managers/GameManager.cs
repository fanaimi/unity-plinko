using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        

        // ==== refs
        

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
            DontDestroyOnLoad(gameObject);
        }


        // Start is called before the first frame update
        void Start()
        {
        }

        private void SetUpNewGame()
        {
        }



        // Update is called once per frame
        void Update()
        {

        }

       
        private void OnDisable()
        {
            // unsubscribing
        }

       
    }


} // SNAKE namespace
