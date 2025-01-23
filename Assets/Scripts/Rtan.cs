using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rtan : MonoBehaviour
{
    // �����
    SpriteRenderer renderer;

    float direction = 0.05f;
    
    void Start()
    {
        Debug.Log("�ȳ�");

        //������Ʈ ����
        Application.targetFrameRate = 60;

        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //���콺�� ���� ��ȯ
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("���콺�� ���� ��ȯ");
            direction *= -1;
            renderer.flipX = !renderer.flipX;
        }

        //���� ƨ���
        if(transform.position.x > 2.5f)
        {
            //Debug.Log("������ ƨ���");
            renderer.flipX = true;
            direction = -0.05f;
        }
        if (transform.position.x < -2.5f)
        {
            //Debug.Log("���� ƨ���");
            renderer.flipX = false;
            direction = 0.05f;
        }

        //�ڵ� �̵�
        transform.position += Vector3.right * direction * Time.timeScale;
    }
}
