using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    
    public void StartGame()
    {
        GameManager.Instance.StartGame(); 
    }

    public void ShowOptions()
    {
        //Show options here
    }

    public void QuitGame()
    {
        GameManager.Instance.QuitApplication();
	}

}
