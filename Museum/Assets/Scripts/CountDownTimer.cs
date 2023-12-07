using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public Text timerText;
    public float timerLeftSeconds = 3f;
    public static bool TimesUp = false;
    public string GameName;
    void Start()
    {
        TimesUp = false;
    }

    
    void Update()
    {
        float t = timerLeftSeconds -= Time.deltaTime;

        string minutes = ((int) t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        //string milliseconds = ((int)(t*100f) % 100).ToString("00");

         timerText.text = minutes + ":" + seconds;

        if(timerLeftSeconds<=0){
            timerLeftSeconds=0;
            timerText.text = minutes + ":" + seconds;
            TimesUp = true;
        }

        if(TimesUp == true && Input.GetKeyDown("p"))
            SceneManager.LoadScene(GameName, LoadSceneMode.Single);

        
    }   
    void OnGUI()
        {
            if(TimesUp == true)
                GUI.Box(new Rect(0,50,250,25), "Shift is Over. Press 'P' to Play Again.");
        }

}
