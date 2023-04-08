using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindBuildingSite : MonoBehaviour
{
    [SerializeField] private bool canBuild = false;
    public bool CanBuild
    {
        get { return canBuild; }
        set { canBuild = value; }
    }

    public GameObject plane;
    private Renderer pRenderer;
    
    // Start is called before the first frame update
    void Awake()
    {
        pRenderer = plane.GetComponent<Renderer>();
    }

    void Start()
    {
        pRenderer.material.color = Color.green;
        canBuild = true;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Building" || other.tag == "Farm")
        {
            pRenderer.material.color = Color.red;
            canBuild = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Building" || other.tag == "Farm")
        {
            pRenderer.material.color = Color.red;
            canBuild = false;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Building" || other.tag == "Farm")
        {
            pRenderer.material.color = Color.green;
            canBuild = true;
        }
    }
    
    
}
