using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootBullet : MonoBehaviour
{
    public Transform FirePos;
    public GameObject bullet;
    Animator anim;
  

    public int health = 3;
    void Start()
    {
        FirePos = gameObject.transform;
      
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(health <= 0)
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //}
        if (Input.GetKeyDown("[0]"))
        {
            anim.SetBool("IsShoot",true);
            Instantiate(bullet, FirePos.transform.position, FirePos.transform.rotation);            
        }
        else
            anim.SetBool("IsShoot", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            // float scalex = gameObject.transform.localScale.x;
            // float scaley = gameObject.transform.localScale.y;
            gameObject.transform.position = new Vector2(x, -y);
            float scaley = gameObject.transform.localScale.y;
            gameObject.transform.localScale = new Vector3(1,-scaley,1);

        }

    } 
}
