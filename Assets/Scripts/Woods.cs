using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Woods : MonoBehaviour
{
    public GameObject nextWood, effect, applePrefab;
    GameObject apple;

    public Text textStage;
    public Text textKnife;

    public float speedRotate;

    public int whatWood, whatKnife;

    public static int ammountKnife;

    private void Start()
    {
        textStage.text = "Stage " + whatWood;
        ammountKnife = whatKnife;
        if(Random.Range(0,100) < 25)
        {
            apple = Instantiate(applePrefab, transform);
        }
        effect.GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        textKnife.text = "" + ammountKnife;
        if (whatWood == 1)
        {
            gameObject.transform.Rotate(0, 0, speedRotate);
            ScoreManager.whatStage = 1;
            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
        }

        if(whatWood == 2)
        {
            gameObject.transform.Rotate(0, 0, -speedRotate);
            ScoreManager.whatStage = 2;
            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
        }

        if (whatWood == 3)
        {
            gameObject.transform.Rotate(0, 0, speedRotate);
            ScoreManager.whatStage = 3;
            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
        }

        if (whatWood == 4)
        {
            gameObject.transform.Rotate(0, 0, -speedRotate);
            ScoreManager.whatStage = 4;
            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
           
        }

        if (whatWood == 5)
        {
            ScoreManager.whatStage = 5;
            textStage.text = "Boss";
          
            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
            }
        }

        if (whatWood == 6)
        {
            ScoreManager.whatStage = 6;

            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
        }

        if (whatWood == 7)
        {
            ScoreManager.whatStage = 7;
            gameObject.transform.Rotate(0, 0, -speedRotate);

            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
        }

        if (whatWood == 8)
        {
            ScoreManager.whatStage = 8;

            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
        }

        if (whatWood == 9)
        {
            ScoreManager.whatStage = 9;

            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
                effect.GetComponent<ParticleSystem>().Play();
            }
        }

        if (whatWood == 10)
        {
            ScoreManager.whatStage = 10;
            textStage.text = "Boss";
            gameObject.transform.Rotate(0, 0, speedRotate);

            if (ammountKnife <= 0)
            {
                Destroy(gameObject);
                Handheld.Vibrate();
                nextWood.SetActive(true);
            }
        }

    }
}
