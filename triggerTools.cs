using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class triggerTools : MonoBehaviour
{
    //获取陷阱组件
    public GameObject trap;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    //开始触发
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("触发开始了:触发了" + other.gameObject.name);
        //如果Player触发了陷阱,则将陷阱设置为激活状态,如果你想任何物件经过时都可以触发,直接把if删掉就好
        if (other.gameObject.name == "Player") { 
            trap.SetActive(true);
        
        }
        
    }
    //触发中
    private void OnTriggerStay(Collider other)
    {
        
    }
    //结束触发
    private void OnTriggerExit(Collider other)
    {
        
    }
}
