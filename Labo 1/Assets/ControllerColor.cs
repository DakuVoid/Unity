using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Renderer))]
public class ControllerColor : MonoBehaviour
{
    Renderer ImageAChanger { get; set; }

	void Start ()
    {
        ImageAChanger = GetComponent<Renderer>();   		
	}

    public void ChangerCouleur(Color nouvelleCouleur)
    {
        ImageAChanger.material.color = nouvelleCouleur;
    }

    public void DevenirRouge()
    {
        ChangerCouleur(Color.red);
    }
    public void DevenirBleu()
    {
        ChangerCouleur(Color.blue);
    }
}
