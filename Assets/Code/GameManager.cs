using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	[SerializeField]
	private GameObject mainCamera;

	public static GameManager Instance { get; protected set; }

	private void Start()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(this);
		}

		DontDestroyOnLoad(this);
		DontDestroyOnLoad(mainCamera);
		StartCoroutine($"{nameof(ChangeToMainMenu)}");
	}

	private IEnumerator ChangeToMainMenu()
	{
		yield return new WaitForEndOfFrame();
		SceneManager.LoadScene(1);
	}

	public void StartGame()
	{
		SceneManager.LoadScene(2);
	}

	public void QuitApplication()
	{
		//save Data here

		Debug.Log("Tschau");
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
	}
}
