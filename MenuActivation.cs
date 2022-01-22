using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuActivation : MonoBehaviour
{
    // 最初に選択状態にするボタン
    [SerializeField] private GameObject firstSelect;

    // 内包するボタンのinteractableを設定する
    public void CheckInteractable(bool check)
    {
        // 内包するボタンの数だけ繰り返す
        for(var i = 0; i < transform.childCount; i++)
        {
            // check　で受け取ったbool をinteractableに設定する
            transform.GetChild(i).GetComponent<Button>().interactable = check;
        }
        if(check)
        {
            // check が true なら(ボタン群がアクティブなら)
            // firstSelect に指定したボタンを選択状態にする
            EventSystem.current.SetSelectedGameObject(firstSelect);
        }
    }
}
