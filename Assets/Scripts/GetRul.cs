using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetRul : MonoBehaviour
{

    public Text rultext;
    // Start is called before the first frame update
    void Start()
    {
        // rultext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void rulCalculate(){
        Debug.Log(rultext.gameObject);
        rultext.gameObject.SetActive(true);
        rultext.text = "75 Cycles";
    }
}
