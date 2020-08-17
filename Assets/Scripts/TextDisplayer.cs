using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] private GameObject _textToDisplay;
    private float _timeToWait = 3f;

    public void DisplayTexts()
    {
        _textToDisplay.SetActive(true);
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(_timeToWait);
        _textToDisplay.SetActive(false);
    }
}
