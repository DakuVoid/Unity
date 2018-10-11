using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionnaireMenuPrincipal : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Button[] boutonsMenu = GetComponentsInChildren<Button>();
        for (int i = 0; i < boutonsMenu.Length; i++)
        {
            int cpt = i;
            boutonsMenu[cpt].onClick.AddListener(() => SceneManager.LoadScene(cpt + 1));
        }
    }
}
