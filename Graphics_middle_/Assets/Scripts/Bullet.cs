using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float bullet_speed = 3.0f;
    public GameObject Score;
    float ScreenLeftWorldPos, ScreenRightWorldPos;
    private AudioSource audio;
    public AudioClip jumpSound;
    void Start()
    {
         audio = gameObject.AddComponent<AudioSource>();
        audio.clip = jumpSound;
        audio.loop = false;
        audio.Play();
        ScreenLeftWorldPos = Camera.main.ScreenToWorldPoint(Vector2.zero).x;
        ScreenRightWorldPos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x <= ScreenRightWorldPos)
            transform.Translate(Vector3.right * bullet_speed * Time.deltaTime);
        else
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("red_bullet"))
        {
            if (gameObject.tag == "red_bullet")
            {
                Vector2 vec = new Vector2(-3.94f, 9.69f);
                Instantiate(Score, vec, Quaternion.identity);//score 체크
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else if (gameObject.tag == "blue_bullet")
                Destroy(gameObject);
        }
        else if (collision.CompareTag("blue_bullet"))
        {
            if (gameObject.tag == "blue_bullet")
            {
                Vector2 vec = new Vector2(-3.94f, 9.69f);
                Instantiate(Score, vec, Quaternion.identity);//score 체크
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else if(gameObject.tag == "red_bullet")
                Destroy(gameObject);
        }
        
    }
}
