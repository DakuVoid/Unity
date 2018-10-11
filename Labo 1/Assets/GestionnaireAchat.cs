using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionnaireAchat : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponentInChildren<Button>().onClick.AddListener(() => SceneManager.LoadScene(0));
    }
}
