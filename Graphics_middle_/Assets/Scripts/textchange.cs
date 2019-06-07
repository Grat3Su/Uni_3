using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textchange : MonoBehaviour
{    
    public Text monologue;
    int scriptcount = 0;
    public GameObject tutopanel;
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        checknextScript();
        ChangeScripts();
        
    }
    void checknextScript()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scriptcount++;
        }
    }
    private void ChangeScripts()
    {
        if(scriptcount == 0)
        monologue.text = "안녕! \n튜토리얼에 온걸 환영해요!";
        else if (scriptcount == 1)
            monologue.text = "어떻게 움직일지 고민해봅시다!";
    }
}
