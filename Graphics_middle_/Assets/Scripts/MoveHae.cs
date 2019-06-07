using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHae : MonoBehaviour
{
    private Ray ray;
    RaycastHit2D hit;

float ScreenLeftWorldPos, ScreenRightWorldPos;
    void Start()
    {
       
      
        ScreenLeftWorldPos = Camera.main.ScreenToWorldPoint(Vector2.zero).x;
        ScreenRightWorldPos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

           if (hit.collider != null)
           {
               float x = Random.Range(ScreenLeftWorldPos,ScreenRightWorldPos);
                float y = Random.Range(-4.8f, 4.8f);
                Debug.Log("충돌!");
               gameObject.transform.position = new Vector2(x,y);
           }


        }
    }
}