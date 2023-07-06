using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChooser : MonoBehaviour
{
    public bool randomMaterial = true;
    public Material[] materials;

    // Start is called before the first frame update
    void Start()
    {
        if (randomMaterial)
        {
            InvokeRepeating("changeMaterial", 2.0f, 0.3f);
        }
    }

    void changeMaterial()
    {
        this.GetComponent <MeshRenderer>().material = materials[Random.Range(0, 6)];
    }
}
