using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
	public GameObject Camera;
	public GameObject Player;
	public Animator anim;
	public GameObject text;
	public GameObject text2;
	void OnTriggerEnter()
	{
		Camera.SetActive(true);
		Player.SetActive(false);
		text.SetActive(false);
		text2.SetActive(false);
		anim.SetBool("fly", true);
	}
}
