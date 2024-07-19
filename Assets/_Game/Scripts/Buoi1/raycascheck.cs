using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycascheck : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform vTriBan;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Check();
    }

    public void Check(){
        RaycastHit2D hit = Physics2D.Raycast(vTriBan.position, Vector2.left,20f);
        
        if(hit){
            Debug.DrawRay(vTriBan.position, Vector2.left * hit.distance, Color.red);
            
        }else{
            Debug.DrawRay(vTriBan.position, Vector2.left, Color.blue);
        }
    }
}
