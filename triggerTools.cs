using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class triggerTools : MonoBehaviour
{
    //��ȡ�������
    public GameObject trap;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    //��ʼ����
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("������ʼ��:������" + other.gameObject.name);
        //���Player����������,����������Ϊ����״̬,��������κ��������ʱ�����Դ���,ֱ�Ӱ�ifɾ���ͺ�
        if (other.gameObject.name == "Player") { 
            trap.SetActive(true);
        
        }
        
    }
    //������
    private void OnTriggerStay(Collider other)
    {
        
    }
    //��������
    private void OnTriggerExit(Collider other)
    {
        
    }
}
