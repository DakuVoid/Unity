using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionnaireJeu : MonoBehaviour
{
    ControlleurJoueur CtrJoueur { get; set; }
    ControlleurCouleur CtrCouleur { get; set; }
    GestionnairePersonnaliser GestPerso { get; set; }
    // Start is called before the first frame update
    void Awake()
    {
        GameObject Joueur1 = Instantiate(Resources.Load<GameObject>("Joueur"));
        Joueur1.GetComponent<ControlleurJoueur>().JoueurModel = Joueur.Joueur1;
        CtrCouleur = Joueur1.AddComponent<ControlleurCouleur>();
        Color CouleurActuelle = GestPerso.CouleurActuelle;
        //CtrCouleur.ChangerCouleur(ref CouleurActuelle);

        GameObject Joueur2 = Instantiate(Resources.Load<GameObject>("Joueur"));
        Joueur2.GetComponent<ControlleurJoueur>().JoueurModel = Joueur.Joueur2;
      
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
