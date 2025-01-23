using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;
    public GameObject endPanel;

    public Text totalScoreText;
    public Text timeText;

    int totalScore = 0;
    float totalTime = 30.0f;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }

    void Start()
    {
        //InvokeRepeating 반복적으로 함수를 실행시키는 함수 , 어떤함수를 ? 언제부터 ? 얼마마다 ?
        InvokeRepeating("MakeRain", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(totalTime > 0f)
        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            //시간 멈추기
            totalTime = 0f;
            Time.timeScale = 0f;
            
            //종료 UI 활성화
            endPanel.SetActive(true);
        }

        timeText.text = totalTime.ToString("N2");
        //N2 소숫점 둘째 자리까지만 문자열로 변경

    }

    void MakeRain()
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;

        totalScoreText.text = totalScore.ToString();
    }
}
