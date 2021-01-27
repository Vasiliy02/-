using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knife : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool whatThis;
    private int whatLose;
    AudioSource soundWood;
    AudioClip clip;

    private void Start()
    {
        PlayerPrefs.GetInt("Lose");
        soundWood = gameObject.GetComponent<AudioSource>();
        soundWood.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ThisWood")
        {
            rb.velocity = Vector2.zero;
            transform.parent = other.transform;
            whatThis = true;
            soundWood.enabled = true;
            soundWood.PlayOneShot(clip);
            ScoreManager.score += 2;
            Woods.ammountKnife -= 1;
        }
        else
        {
            soundWood.enabled = false;
        }

        if (other.gameObject.tag == "ThisKnife")
        {
            if (whatThis == true)
            {
                rb.velocity = Vector2.zero;
                rb.gravityScale = 1;
                PlayerPrefs.SetInt("Lose", 1);
                Destroy(gameObject, 1);
                Handheld.Vibrate();
            }
        }

        if (other.gameObject.tag == "ThisApple")
        {
            Destroy(other.gameObject);
            ScoreManager.appleAmmount += 1;
            Handheld.Vibrate();
        }

        if (other.gameObject.tag == "Restart")
        {
            rb.velocity = Vector2.zero;
            rb.gravityScale = 1;
            PlayerPrefs.SetInt("Lose", 1);
            Destroy(gameObject, 1);
            Handheld.Vibrate();
        }
    }


}

