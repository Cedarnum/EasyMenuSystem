using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSelect : MonoBehaviour
{
    [SerializeField] Button okButton;
    // Start is called before the first frame update
    void Start()
    {
        okButton.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
