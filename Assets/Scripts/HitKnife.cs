using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitKnife : MonoBehaviour
{
    public float force;
    GameObject knife;
    public GameObject knifePrefabs, loseTable, wood, soundLose;
    Animator anim;

    private void Start()
    {
        soundLose.SetActive(false);
        knife = Instantiate(knifePrefabs, transform);
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            knife.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
            knife = Instantiate(knifePrefabs, transform);
            anim.SetTrigger("Tap");
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetTrigger("Wait");
        }

            if (PlayerPrefs.GetInt("Lose") == 1)
        {
            Destroy(gameObject);
            Destroy(wood);
            loseTable.SetActive(true);
            soundLose.SetActive(true);
        }
    }
}
