using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpVisibilityChanger : MonoBehaviour
{
    [SerializeField] private Animator _popUp;

    public void OpenPopUp()
    {
        _popUp.SetBool("isOpen", true);
    }

    public void ClosePopUp()
    {
        _popUp.SetBool("isOpen", false);
    }
}