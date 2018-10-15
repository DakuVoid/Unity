using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur
{
    GameObject j1 = GameObject.Instantiate((GameObject)Resources.Load("Joueur"));
    GameObject j2 = GameObject.Instantiate((GameObject)Resources.Load("Joueur"));
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreatePlayer(ref GameObject gameObject)
    {
        gameObject = Instantiate(Resources.Load<GameObject>("Joueur");
    }
}
