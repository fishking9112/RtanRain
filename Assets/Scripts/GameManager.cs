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
        //InvokeRepeating �ݺ������� �Լ��� �����Ű�� �Լ� , ��Լ��� ? �������� ? �󸶸��� ?
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
            //�ð� ���߱�
            totalTime = 0f;
            Time.timeScale = 0f;
            
            //���� UI Ȱ��ȭ
            endPanel.SetActive(true);
        }

        timeText.text = totalTime.ToString("N2");
        //N2 �Ҽ��� ��° �ڸ������� ���ڿ��� ����

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
