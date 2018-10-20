
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Video.VideoPlayer;

public class Joueur
{
    //public event EventHandler OnPositionChangée
    //public event EventHandler OnCouleurChangée


    public static readonly Joueur Joueur1 = new Joueur(new Vector3(0,1,0), Color.blue);
    public static readonly Joueur Joueur2 = new Joueur(new Vector3(0,0,0), Color.red);

    ControlleurCouleur CtrCouleur { get; set; }
    public Vector3 PositionLocale;
    public Color Couleur;

    public event EventHandler OnPositionChangee;
    public event EventHandler OnCouleurChangee;

    public Joueur(Vector2 positionLocale, Color couleur)
    {
        //CtrCouleur = this.AddComponent<ControlleurCouleur>();
        PositionLocale = positionLocale;
        //this.transform.Translate(positionLocale);
        Couleur = couleur;
        //CtrCouleur.ChangerCouleur(ref couleur);
    }
  
    public void Deplacer(ref Vector3 positionLocale)
    {
        PositionLocale = positionLocale;
        //this.transform.Translate(positionLocale);

    }

    public void ChangerCouleur(ref Color couleur)
    {
        Couleur = couleur;
        //CtrCouleur.ChangerCouleur(ref couleur);
    }
}
