using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;

    private static int _score;
    public static int CurrentScore => _score;

    private void Update()
    {
        if (!(transform.position.y >= _score)) return;

        _score = (int) transform.position.y;
        scoreTxt.text = _score.ToString();
    }
}