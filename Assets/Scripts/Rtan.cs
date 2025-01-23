using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rtan : MonoBehaviour
{
    // 선언부
    SpriteRenderer renderer;

    float direction = 0.05f;
    
    void Start()
    {
        Debug.Log("안녕");

        //업데이트 고정
        Application.targetFrameRate = 60;

        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //마우스로 방향 전환
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("마우스로 방향 전환");
            direction *= -1;
            renderer.flipX = !renderer.flipX;
        }

        //벽에 튕기기
        if(transform.position.x > 2.5f)
        {
            //Debug.Log("오른쪽 튕기기");
            renderer.flipX = true;
            direction = -0.05f;
        }
        if (transform.position.x < -2.5f)
        {
            //Debug.Log("왼쪽 튕기기");
            renderer.flipX = false;
            direction = 0.05f;
        }

        //자동 이동
        transform.position += Vector3.right * direction * Time.timeScale;
    }
}
