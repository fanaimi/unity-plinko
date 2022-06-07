using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PLINKO;

/// <summary>
/// @obj    Disc
/// @desc   this will control disc, lives, score
/// </summary>
public class DiscController : MonoBehaviour
{
    public event Action OnTouchBottom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("scoreCollider"))
        {
            // print(other.GetComponent<ScoreCollider>().m_scoreToAdd);
            GameManager.Instance.AddScore(other.GetComponent<ScoreCollider>().m_scoreToAdd);
            GameManager.Instance.DecreaseLives();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("pin"))
        {
            GameManager.Instance.AddScore(10);
        }

        if (collision.collider.CompareTag("redPin"))
        {
            GameManager.Instance.AddScore(20);
        }
    }


}
