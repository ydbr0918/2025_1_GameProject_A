using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boll : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") // �浿�� �Ͼ ��ü�� Tag�� Ground ��� 
        {
            Debug.Log("���� �浹"); // ����� �α׸� ����
        }
;
    }
    private void OnTriggerEnter(Collider other)

    {
        Debug.Log("Ʈ���� �ȿ� ����");
    }


}
