using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionnaireJeu : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Awake()
    {

        //JOUEUR 1
        GameObject Joueur1 = Instantiate(Resources.Load<GameObject>("Joueur"));
        Joueur1.GetComponent<ControlleurJoueur>().JoueurModel = Joueur.Joueur1;

        //Mouvement
        string[] IntrantsJoueur1 = { "Horizontal", "Vertical" };
        Joueur1.GetComponent<ControlleurJoueur>().IntrantsManette = IntrantsJoueur1;
        Joueur1.transform.position = new Vector3(0, 1, 0);

        //Couleur
        GestionnairePersonnaliser GestPersonnaliser = new GestionnairePersonnaliser();
        Color CouleurActuelle = GestPersonnaliser.CouleurActuelle;
        Joueur1.GetComponentInChildren<ControlleurCouleur>().ChangerCouleur(ref CouleurActuelle);


        //JOUEUR 2
        GameObject Joueur2 = Instantiate(Resources.Load<GameObject>("Joueur"));
        Joueur2.GetComponent<ControlleurJoueur>().JoueurModel = Joueur.Joueur2;

        //Mouvement
        string[] IntrantsJoueur2 = { "HorizontalManette", "VerticalManette" };
        Joueur2.GetComponent<ControlleurJoueur>().IntrantsManette = IntrantsJoueur2;
        Joueur2.transform.position = new Vector3(0, 0, 0);

        //Couleur
        Color CouleurJoueur2 = Joueur.Joueur2.Couleur;
        Joueur2.GetComponentInChildren<ControlleurCouleur>().ChangerCouleur(ref CouleurJoueur2);
    }
}
