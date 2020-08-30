using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
	public JoystickPlayerExample playerScript;
    public AgenyAI Agent_AI;
    public AgenyAI Agent_AI2;
	public Text CountdownUI;
    public GameObject UI_1;
    public GameObject UI_2;
    public GameObject UI_3;
    public GameObject UI_4;
    public GameObject UI_5;

	public int num = 3; 

    // Start is called before the first frame update
    void Awake()
    {
        playerScript.enabled = false;
        Agent_AI.enabled = false;
        Agent_AI2.enabled = false;
        CountdownUI.enabled = true;
        UI_1.SetActive(false);
        UI_2.SetActive(false);
        UI_3.SetActive(false);
        UI_4.SetActive(false);
        UI_5.SetActive(false);
        CountdownUI.text = num.ToString();
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        yield return new WaitForSeconds(1);
        num = 2;
        CountdownUI.text = num.ToString();
        yield return new WaitForSeconds(1);
        num = 1;
        CountdownUI.text = num.ToString();
        yield return new WaitForSeconds(1);
        CountdownUI.text = "GO!";
        yield return new WaitForSeconds(1);
        CountdownUI.enabled = false;
        UI_1.SetActive(true);
        UI_2.SetActive(true);
        UI_3.SetActive(true);
        UI_4.SetActive(true);
        UI_5.SetActive(true);
        playerScript.enabled = true;
        Agent_AI.enabled = true;
        Agent_AI2.enabled = true;
    }

}
