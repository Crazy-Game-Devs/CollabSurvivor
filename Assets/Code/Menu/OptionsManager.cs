using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManager : MonoBehaviour
{
	private IOptionReturnPoint returnPoint;

	public void ShowOptions(IOptionReturnPoint returnPoint)
	{
		this.returnPoint = returnPoint;
		gameObject.SetActive(true);
	}

	public void HideOptions()
	{
		gameObject.SetActive(false);
		if (returnPoint != null) returnPoint.ShowAfterOptionsClosed();
	}
}

public interface IOptionReturnPoint
{
	public void ShowAfterOptionsClosed();
}
