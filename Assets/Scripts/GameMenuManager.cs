using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour {


	void Start () {

	}




	void Update () {

	}

	public void OneOne()
	{
		SceneManager.LoadScene ("1vs1");

	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void SwitchSound()
	{

	}
}
