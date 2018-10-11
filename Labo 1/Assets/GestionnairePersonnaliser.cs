using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionnairePersonnaliser : MonoBehaviour
{
    GameObject Cube { get; set; }
    ControlleurCouleur ControleurCouleur { get; set; }
    Dropdown DdlCouleur { get; set; }
    Button boutonMenu { get; set; }
    Color[] CouleurCube = new Color[]{ Color.cyan, Color.yellow, Color.magenta, Color.black, Color.white };
    void Start ()
    {
        InitCube();
        InitBouton();

        DdlCouleur = GetComponentInChildren<Dropdown>();

        ControleurCouleur.ChangerCouleur(CouleurCube[DdlCouleur.value]);
        DdlCouleur.onValueChanged.AddListener(optionSel => ControleurCouleur.ChangerCouleur(CouleurCube[optionSel]));
    }
    private void InitCube()
    {
        Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ControleurCouleur = Cube.AddComponent<ControlleurCouleur>();
        Cube.transform.position = new Vector3(0, 1, -5);
        Cube.transform.Rotate(new Vector3(0, 15, 0));
    }
    private void InitBouton()
    {
        boutonMenu = GetComponentInChildren<Button>();
        boutonMenu.onClick.AddListener(() => SceneManager.LoadScene(0));
    }
    void Update()
    {
        GestionRotationDuCube();
    }
    private void GestionRotationDuCube()
    {
        float rotation = Input.GetAxis("Horizontal");
        if (!Mathf.Approximately(rotation, 0))
            Cube.transform.Rotate(new Vector3(0, rotation, 0));
    }
}
