using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ControlleurJoueur : MonoBehaviour
{
    private Joueur joueurModel;
    public Joueur JoueurModel
    {
        get
        {
            return joueurModel;
        }
        set
        {
            if (value != null)
                joueurModel = value;
            else
                throw new ArgumentNullException();
        }
    }

    private string[] intrantsManette;
    public string[] IntrantsManette
    {
        get
        {
            return intrantsManette;
        }
        set
        {
            if (value != null)
                intrantsManette = value;
            else
                throw new ArgumentNullException();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector2 PositionBase = transform.position;
        JoueurModel.Deplacer(ref PositionBase);
    }

    // Update is called once per frame
    void Update()
    {
        var InputX = Input.GetAxis(IntrantsManette[0]);
        var InputY = Input.GetAxis(IntrantsManette[1]);
        Vector2 Deplacement = new Vector2(InputX, InputY);

        if (!Mathf.Approximately(InputX, 0) || !Mathf.Approximately(InputY, 0))
        {
            joueurModel.Deplacer(ref Deplacement);
            transform.position = JoueurModel.PositionLocale;
        }
    }
}

