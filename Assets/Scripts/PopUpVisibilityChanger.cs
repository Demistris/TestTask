using UnityEngine;

public class PopUpVisibilityChanger : MonoBehaviour
{
    [SerializeField] private Animator _popUp = null;

    private static readonly int isOpen = Animator.StringToHash("isOpen");

    public void OpenPopUp()
    {
        _popUp.SetBool(isOpen, true);
    }

    public void ClosePopUp()
    {
        _popUp.SetBool(isOpen, false);
    }
}