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

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("scoreCollider"))
        {
            AudioManager.Instance.Play("win");
            // print(other.GetComponent<ScoreCollider>().m_scoreToAdd);
            GameManager.Instance.AddScore(other.GetComponent<ScoreCollider>().m_scoreToAdd);
            GameManager.Instance.DecreaseLives();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("pin"))
        {
            AudioManager.Instance.Play("hitPin");
            GameManager.Instance.AddScore(10);
        }

        if (collision.collider.CompareTag("redPin"))
        {
            AudioManager.Instance.Play("bling");
            GameManager.Instance.AddScore(20);
        }
    }


}
