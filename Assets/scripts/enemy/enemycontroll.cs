using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemycontroll : MonoBehaviour
{
    //TODO
    GameObject scoreUITextGO;
    public TextMeshProUGUI scoreUITextGO2;
    double scoreValue = 0;

    float speed;

    //TODO
    //private void Awake()
    //{
    //    scoreUITextGO2 = GetComponent<TextMeshProUGUI>();
    //}


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

        //TODO
        //scoreUITextGO2.text = scoreValue.ToString();
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if ((collider.tag == "playershiptag") || (collider.tag == "playershipbullettag"))
        {
            //TODO
            //scoreUITextGO.GetComponent<GameScore>().Score += 100;

            scoreUITextGO.GetComponent<TMP_Text>().text += 100;

            //scoreValue += 100;

            Destroy(gameObject);
        }
    }
}
