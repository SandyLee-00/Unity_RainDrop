using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    int type = 0;
    float size = 0.0f;
    int score = 0;

    void Start()
    {
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(6.0f, 7.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 5);
        if(type == 1)
        {
            size = 1.2f;
            score = 1;
            GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 2)
        {
            size = 1.0f;
            score = 2;
            GetComponent<SpriteRenderer>().color = new Color(130 / 255f, 130 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 3)
        {
            size = 0.8f;
            score = 3;
            GetComponent<SpriteRenderer>().color = new Color(150 / 255f, 150 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 4)
        {
            size = 0.8f;
            score = -5;
            GetComponent<SpriteRenderer>().color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
        }
        transform.localScale = new Vector3(size, size, 0.0f);
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        else if(col.gameObject.tag == "Player")
        {
            gameManager.I.addScore(score);
            Destroy(gameObject);
        }
    }
}
