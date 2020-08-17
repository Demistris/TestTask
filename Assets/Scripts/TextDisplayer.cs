using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textToDisplay;
    private float _timer;

    private void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            _textToDisplay.text = _timer.ToString("F");
        }
        else
        {
            _timer = 0;
            _textToDisplay.text = "0.0";
        }
    }

    public void DisplayTexts()
    {
        _timer = 3f;
        _textToDisplay.gameObject.SetActive(true);
        StartCoroutine(Wait(3f));
    }

    private IEnumerator Wait(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        _textToDisplay.gameObject.SetActive(false);
    }
}
