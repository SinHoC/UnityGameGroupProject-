using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class enemycontroll : MonoBehaviour
{
    //TODO
    GameObject scoreUITextGO;

    float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;

        //TODO
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");
        //Debug.Log(scoreUITextGO.GetComponent<GameScore>());

    }


    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);
        transform.position = position;
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if(transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if ((collider.tag == "playershiptag") || (collider.tag == "playershipbullettag"))
        {
            //TODO
            playercontroll.score -= 1;
            scoreUITextGO.GetComponent<TMP_Text>().text = playercontroll.score.ToString();

            Destroy(gameObject);

            if (playercontroll.score == 0)
            {
                SceneManager.LoadScene(5);
            }

        }
    }
}
