using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GestionnaireJeu : MonoBehaviour
{
    GestionnairePersonaliser GestionnairePersonaliser { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        GameObject Joueur1 = Instantiate(Resources.Load<GameObject>("Joueur"));
        GameObject Joueur2 = Instantiate(Resources.Load<GameObject>("Joueur"));
        Joueur1.GetComponent<ControlleurJoueur>().JoueurModel = Joueur.Joueur1;
        Joueur2.GetComponent<ControlleurJoueur>().JoueurModel = Joueur.Joueur2;
        Joueur1.ChangerCouleur = GestionnairePersonaliser.CouleurActuelle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject CreatePlayer()
    {
        GameObject gameObject = new GameObject();
        gameObject = Instantiate(Resources.Load<GameObject>("Joueur"));
        return gameObject;
    }
}
