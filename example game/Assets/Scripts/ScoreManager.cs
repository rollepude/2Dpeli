using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public Animator animator;
    //public GameObject gameObj;
    public static ScoreManager instance;
    public TextMeshProUGUI text;
        int score;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
        if (score == 55)
        {
            animator.SetBool("alas", true);
            //gameObj.SetActive(false);
        }
    }
}
