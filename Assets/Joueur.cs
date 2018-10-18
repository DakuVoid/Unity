
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Video.VideoPlayer;

public class Joueur
{
    public static readonly Joueur Joueur1 = new Joueur(new Vector2(0,0), Color.blue);
    public static readonly Joueur Joueur2 = new Joueur(new Vector2(0, 0), Color.red);

    private Vector2 PositionLocale;
    private Color Couleur;

    public event EventHandler OnPositionChangee;
    public event EventHandler OnCouleurChangee;

    public Joueur(Vector2 positionLocale, Color couleur)
    {
            PositionLocale = positionLocale;
            Couleur = couleur;
    }
  
    public void Deplacer(ref Vector2 positionLocale)
    {
        PositionLocale = positionLocale;
    }

    public void ChangerCouleur(ref Color couleur)
    {
        Couleur = couleur;
    }
}
