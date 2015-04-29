using UnityEngine;
using System.Collections;

public class StartManger : MonoBehaviour {

	public void StartGame()
	{
		Application.LoadLevel("CongaScene");
	}

	public void RestartGame()
	{
		Application.LoadLevel("LaunchScene");
	}
}
