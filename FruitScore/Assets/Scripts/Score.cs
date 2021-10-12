using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public GameObject sccore;
    static int highscore = 0;
    public Text highscore1;
    // Start is called before the first frame update
    void Start()
    {
         PlayerPrefs.GetInt("High Score", highscore).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        sccore.GetComponent<Text>().text = Game.ScrDestroyOnCol.count.ToString();

        int number = Random.Range(1, 3);
        // highscore.text = number.ToString();
        if (Game.ScrDestroyOnCol.count>=highscore)
        {
            highscore = Game.ScrDestroyOnCol.count;
            PlayerPrefs.GetInt("High Score", highscore).ToString();
            PlayerPrefs.SetInt("High Score", highscore);
        }
        PlayerPrefs.SetInt("High Score", number);


    }
}
