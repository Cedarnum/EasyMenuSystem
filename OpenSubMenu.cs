using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSubMenu : MonoBehaviour
{
    // [SerializeField] GameObject subMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickMenuButton(GameObject subMenu)
    {
        subMenu.SetActive(true);
    }
}
