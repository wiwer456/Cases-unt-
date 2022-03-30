using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker2 : MonoBehaviour
{
    int razr = 0;
    Transform case_transform;
    // Start is called before the first frame update
    void Start()
    {
       case_transform = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(razr == 1){
            case_transform.Rotate(1, 1, 0);
        }
    }
    void OnMouseDown(){
            print("мимо");
            razr += 1;
        
    }
}
