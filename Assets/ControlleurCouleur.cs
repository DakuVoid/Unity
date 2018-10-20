using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MeshRenderer))]
public class ControlleurCouleur : MonoBehaviour
{
    Renderer Renderer { get; set; }

	void Awake ()
    {
        Renderer = GetComponent<MeshRenderer>();   		
	}

    public void ChangerCouleur(ref Color nouvelleCouleur)
    {
        Renderer.material.color = nouvelleCouleur;
    }


}
