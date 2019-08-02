using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private GameObject time;
    [SerializeField] private float second = 120;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Text>().text = ((int)second).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Text();
    }
    void Text()
    {
        Text timeText = time.GetComponent<Text>();
        second -= Time.deltaTime;
        
        timeText.text = "残り " + (int)second + "秒";
        if(second <=0)
        {
            SceneManager.LoadScene("Result");
        }
    }

}
