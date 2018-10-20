using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlleurJoueur : MonoBehaviour
{
    public Joueur JoueurModel;
    public Color CouleurActuelle { get; set; }
    public string[] IntrantsManette = { "Horizontal", "Vertical" };

    public void SetJoueurModel(Joueur model)
    {
        try
        {
            JoueurModel = model;
        }
        catch (System.ArgumentNullException e)
        {
            Debug.Log("Erreur dans SetJoueurModel" + e.Message.ToString());
        }
    }

    public void SetIntrantsManette(string[] intrants)
    {
        try
        {
            IntrantsManette = intrants;
        }
        catch (System.ArgumentNullException e)
        {
            Debug.Log("Erreur dans SetIntrantsManette" + e.Message.ToString());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var InputX = Input.GetAxis("Horizontal") * Time.deltaTime *150.0f;
        var InputY = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        if (!Mathf.Approximately(InputX, 0) || !Mathf.Approximately(InputY, 0))
        {
            
        }
    }
}

