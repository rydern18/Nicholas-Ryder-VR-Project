using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public TextMesh timerText;
    public float gameTimer = 60f;
    public TextMesh gameName;
    public TextMesh Score;
    public static bool Started;
    public TextMesh Instruct;
    
    
    public TextMesh High;

    

    public GameObject Hammer;
    
    public GameObject spiderContainer;
    private Spider[] spiders;
    public float showSpiderTime = 1.5f;

   
    // Start is called before the first frame update
    void Start()
    {
        
        spiders = spiderContainer.GetComponentsInChildren<Spider>();

        High.text = "High Score: " + PlayerPrefs.GetFloat("HighScore", 0).ToString();
       

    }

    // Update is called once per frame
    void Update()
    {

        if (Started == true)
        { 
            gameTimer -= Time.deltaTime;
            Instruct.text = "GAME STARTED";

            if (gameTimer > 0f)
            {
                Score.text = "" + OnCollisionSpider.points;
                timerText.text = "" + Mathf.Floor(gameTimer);
                showSpiderTime -= Time.deltaTime;
                if (showSpiderTime < 0f)
                {

                    spiders[Random.Range(0, spiders.Length)].ShowSpider();

                    showSpiderTime = 1.5f;
                }
                ;

            }
            else
            {
                gameName.text = "GAME OVER";
                Instruct.text = "To Reset Game Place the Hammer\n on the Platform to the left of the Game Table.";
                if(OnCollisionSpider.points > PlayerPrefs.GetFloat("HighScore", 0))
                {
                    PlayerPrefs.SetFloat("HighScore", OnCollisionSpider.points);
                    High.text = "High Score: " + OnCollisionSpider.points;
                }
            }
        }
    }
    
}
