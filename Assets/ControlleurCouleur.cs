using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Renderer))]
public class ControlleurCouleur : MonoBehaviour
{
    Renderer Renderer { get; set; }

	void Awake ()
    {
        Renderer = GetComponent<Renderer>();   		
	}

    public void ChangerCouleur(ref Color nouvelleCouleur)
    {
        Renderer.material.color = nouvelleCouleur;
    }
}
