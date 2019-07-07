using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{

    public Text score;

    public Font font; 

    private ulong multiplier = 1;
    private ulong divider = 2500;
    private BigInteger scoreValue;

    public string ScoreValue { get => scoreValue.ToString(); }


    // Start is called before the first frame update
    void Start()
    {
        score.text = "0";
        scoreValue = new BigInteger(0);
        score.font = font;
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue += 1 + (ulong)Mathf.Pow(1 * multiplier / divider, multiplier/divider);
        multiplier += 1;
        score.text = scoreValue.ToString();
    }
}
