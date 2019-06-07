using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 3;
    public GameObject health;
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Vector2 vec = new Vector2(-3.94f, 9.69f);
            Instantiate(health, vec, Quaternion.identity);//hp 체크
            Destroy(gameObject);
        }
    }
    }
