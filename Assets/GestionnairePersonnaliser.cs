using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionnairePersonnaliser : MonoBehaviour
{
    GameObject Cube { get; set; }
    ControlleurCouleur CtrCouleur { get; set; }
    Dropdown DdlCouleur { get; set; }
    Button BoutonMenu { get; set; }
    Color[] CouleurCube { get; set; } = { Color.cyan, Color.yellow, Color.magenta, Color.black, Color.white };
    void Start()
    {
        InitCube();
        InitBouton();

        DdlCouleur = GetComponentInChildren<Dropdown>();

        CtrCouleur.ChangerCouleur(ref CouleurCube[DdlCouleur.value]);
        DdlCouleur.onValueChanged.AddListener(optionSel => CtrCouleur.ChangerCouleur(ref CouleurCube[optionSel]));

    }
    private void InitCube()
    {
        Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        CtrCouleur = Cube.AddComponent<ControlleurCouleur>();
        Cube.transform.position = new Vector3(0, 1, -5);
        Cube.transform.Rotate(new Vector3(0, 15, 0));
    }
    private void InitBouton()
    {
        BoutonMenu = GetComponentInChildren<Button>();
        BoutonMenu.onClick.AddListener(() => SceneManager.LoadScene(0));
    }
    void Update()
    {
        GestionRotationDuCube();
    }
    private void GestionRotationDuCube()
    {
        float rotation = Input.GetAxis("Horizontal");
        Cube.transform.Rotate(new Vector3(0, rotation, 0));
    }
}
