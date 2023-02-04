using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  float direction = 0.05f;
  float flip = 1.0f;
  float speed = 0.5f;

  void Start()
  {

  }

  void Update()
  {
    if (transform.position.x > 2.8f || transform.position.x < -2.8f || Input.GetMouseButtonDown(0))
    {
      direction *= -1;
      flip *= -1;

    }
    transform.localScale = new Vector3(flip, 1, 1);
    transform.position += new Vector3(direction, 0.0f, 0.0f) * speed;
  }
}
