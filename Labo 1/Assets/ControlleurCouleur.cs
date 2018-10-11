using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Renderer))]
public class ControlleurCouleur : MonoBehaviour
{
    Renderer ImageAChanger { get; set; }

	void Start ()
    {
        ImageAChanger = GetComponent<Renderer>();   		
	}

    public void ChangerCouleur(ref Color nouvelleCouleur)
    {
        ImageAChanger.material.color = nouvelleCouleur;
    }
}
