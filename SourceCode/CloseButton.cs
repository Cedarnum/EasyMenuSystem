using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    [SerializeField] GameObject menuObject;
    public void OnClickClose()
    {
        menuObject.SetActive(false);
    }
}
