using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
	public Text timerText;
    public float startTime = 103f;
    public float t;
    public string secs;
    public bool start = false;
    public GameObject lose;
    // Update is called once per frame
    void Update()
    {
        if (start == false)
            t = startTime - Time.timeSinceLevelLoad;
            secs = (t).ToString("f2");
            timerText.text = secs; 
        if (t < 0f && start == false)
        {
        	start = true;
            lose.SetActive(true);
        }
    }
}
