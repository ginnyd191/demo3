using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject exploe1;
    private GameObject explo1;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            killboar();
        }
    }

    public void killboar(){
        GameObject[] boars;
        boars = GameObject.FindGameObjectsWithTag("boars");
        foreach(GameObject boar in boars){
            // Instantiate(explo1, boar.transform.position, Quaternion.identity);
            Destroy(boar);
            Destroy(explo1, 1f);
        }
    }
}
