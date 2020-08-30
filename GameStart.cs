using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject Camera;
	public GameTimer timer;
	public GameObject Camera2;
    // Start is called before the first frame update
    void Start()
    {
        Camera.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        timer.enabled = false;
        StartCoroutine(WaitCoroutine());
    }
    IEnumerator WaitCoroutine()
    {
    	yield return new WaitForSeconds(3);
    	Camera.SetActive(true);
        text1.SetActive(true);
        text2.SetActive(true);
        text3.SetActive(false);
        timer.enabled = true;
        Camera2.SetActive(false);
    }
}
