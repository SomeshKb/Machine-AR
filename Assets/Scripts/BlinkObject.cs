using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkObject : MonoBehaviour
{

    public GameObject sphere; 
    Renderer m_ObjectRenderer;

    public  double  timer =0.0;
    public bool  onoff = false;

    // Start is called before the first frame update
    void Start()
    {
            m_ObjectRenderer = sphere.GetComponent<Renderer>();
            m_ObjectRenderer.enabled = onoff;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer && m_ObjectRenderer)
        {       
            timer = Time.time + .4;
            onoff = !onoff;
            m_ObjectRenderer.enabled = onoff;
        }
        
    }
}
