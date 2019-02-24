using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
	public GameObject registerPanel, loginPanel, profilePanel, listpanel;

	public void OnBtnClick(int panelNo)
	{
		ClosePanels ();
		if (panelNo == 0) {
			loginPanel.SetActive (true);
		} else if (panelNo == 1) {
			profilePanel.SetActive (true);
		} else if (panelNo == 2) {
			listpanel.SetActive (true);
		} else if (panelNo == 3) {
			registerPanel.SetActive (true);
		}
	}

	void ClosePanels()
	{
		loginPanel.SetActive (false);
		registerPanel.SetActive (false);
		profilePanel.SetActive (false);
		listpanel.SetActive (false);
	}
}
