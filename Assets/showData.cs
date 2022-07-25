using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showData : MonoBehaviour
{
    public GameObject turbo;
    public GameObject sensor;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSensorEnable(){
        Debug.Log(turbo.transform.position);
        Instantiate(sensor,turbo.transform.position,turbo.transform.rotation);
    }
}
