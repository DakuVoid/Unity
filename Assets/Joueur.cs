using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Joueur
{
    //public event EventHandler OnPositionChangée
    //public event EventHandler OnCouleurChangée


    public static readonly Joueur Joueur1 = new Joueur(new Vector2(1,0), Color.cyan);
    public static readonly Joueur Joueur2 = new Joueur(new Vector2(0,0), Color.red);

    public Vector2 PositionLocale;
    public Color Couleur;

    public event EventHandler OnPositionChangee;
    public event EventHandler OnCouleurChangee;

    public Joueur(Vector2 positionLocale, Color couleur)
    {
        PositionLocale = positionLocale;
        Couleur = couleur;
    }
  
    public void Deplacer(ref Vector2 positionLocale)
    {
        PositionLocale += positionLocale;
        OnPositionChangee?.Invoke(this, EventArgs.Empty);
    }

    public void ChangerCouleur(ref Color couleur)
    {
        Couleur = couleur;
        OnCouleurChangee?.Invoke(this, EventArgs.Empty);
    }
}
