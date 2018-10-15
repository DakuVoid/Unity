using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlleurJoueur : MonoBehaviour
{
    public Joueur JoueurModel;
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
        float InputX = 0;
        float InputY = 0;

        InputX = Input.GetAxis(IntrantsManette[0]);
        InputY = Input.GetAxis(IntrantsManette[1]);

        if (!Mathf.Approximately(InputX, 0) || !Mathf.Approximately(InputY, 0))
        {
            Vector2 deplacement = new Vector2(InputX, InputY);
            JoueurModel.Deplacer(ref deplacement);
        }
    }
}

