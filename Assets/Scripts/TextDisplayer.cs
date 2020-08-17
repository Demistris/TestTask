using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textToDisplay;
    [SerializeField] private Button _displayTextButton;
    private float _timer;

    private void Update()
    {
        if (_timer > 0f)
        {
            _timer -= Time.deltaTime;
            _textToDisplay.text = _timer.ToString("F");
        }
        else if(_timer <= 0f)
        {
            _timer = 0f;
            _textToDisplay.text = _timer.ToString("F");
        }
    }

    public void DisplayTexts()
    {
        _displayTextButton.interactable = false;
        _timer = 3f;
        _textToDisplay.gameObject.SetActive(true);

        StartCoroutine(Wait(3f));
    }

    private IEnumerator Wait(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        _textToDisplay.gameObject.SetActive(false);
        _displayTextButton.interactable = true;
    }
}