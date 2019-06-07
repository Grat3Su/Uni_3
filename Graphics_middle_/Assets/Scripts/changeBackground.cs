using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBackground : MonoBehaviour
{
    SpriteRenderer sprender;
   public  Sprite[] sp;
    bool check = false;
    void Start()
    {
        sprender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (check == true)
            {
                sprender.sprite = sp[0];
           
                check = false;
            }
            else if (check == false)//반대
            {                
                float y = gameObject.transform.localScale.y;
               
                sprender.sprite = sp[1];
                check = true;
            }
        }
    }
}
