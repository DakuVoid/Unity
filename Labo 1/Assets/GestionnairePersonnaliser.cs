using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionnairePersonnaliser : MonoBehaviour
{
    GameObject cube { get; set; }
    ControllerColor controleurCouleur { get; set; }
    Dropdown DdlCouleur { get; set; }
    Button boutonMenu { get; set; }
    Color[] CouleurCube { get; set; } = { Color.cyan, Color.yellow, Color.magenta, Color.black, Color.white };
    void Start ()
    {
        InitCube();
        InitBouton();
    }
    private void InitCube()
    {
        DdlCouleur = GetComponentInChildren<Dropdown>();
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        controleurCouleur = cube.AddComponent<ControllerColor>();
        cube.transform.position = new Vector3(0, 1, -5);
        cube.transform.Rotate(new Vector3(0, 15, 0));
    }
    private void InitBouton()
    {
        boutonMenu = GetComponentInChildren<Button>();
        boutonMenu.onClick.AddListener(() => SceneManager.LoadScene(0));
    }
    void Update()
    {
        GestionRotationDuCube();
        GestionCouleurDuCube();
    }
    private void GestionRotationDuCube()
    {
        float rotation = Input.GetAxis("Horizontal");
        cube.transform.Rotate(new Vector3(0, rotation, 0));
    }
    private void GestionCouleurDuCube()
    {
        if(DdlCouleur != null)
            controleurCouleur.ChangerCouleur(CouleurCube[DdlCouleur.value]);
    }
}
