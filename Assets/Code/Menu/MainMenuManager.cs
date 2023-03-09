using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour, IOptionReturnPoint
{
	[SerializeField]
	private Canvas mainMenuCanvas;
	[SerializeField]
	private OptionsManager optionsManager;


	public void StartGame()
	{
		GameManager.Instance.StartGame();
	}

	public void ShowOptions()
	{
		mainMenuCanvas.gameObject.SetActive(false);
		optionsManager.ShowOptions(this);
	}

	public void QuitGame()
	{
		GameManager.Instance.QuitApplication();
	}

	public void ShowAfterOptionsClosed()
	{
		mainMenuCanvas.gameObject.SetActive(true);
	}
}
