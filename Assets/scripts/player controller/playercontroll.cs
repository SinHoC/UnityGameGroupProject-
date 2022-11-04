using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroll : MonoBehaviour
{
    public float speed;
	public GameObject bullet;
	public GameObject bulletposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject shipbullet = (GameObject)Instantiate(bullet);
            shipbullet.transform.position = bulletposition.transform.position;

        }
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");        
        Vector2 direction = new Vector2(x, y).normalized;
        Move(direction);
    }
	void Move(Vector2 direction)
	{
		//find the screen limits to the player's movement
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //bottom-left of the screen
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //top-right the screen

		max.x = max.x - 0.8f; 
		min.x = min.x + 0.8f; 

		max.y = max.y - 1.2f; 
		min.y = min.y + 1.2f; 

		Vector2 pos = transform.position;
		pos += direction * speed * Time.deltaTime;
		pos.x = Mathf.Clamp(pos.x, min.x, max.x);
		pos.y = Mathf.Clamp(pos.y, min.y, max.y);
		transform.position = pos;
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        if((collider.tag == "enemyshiptag") ||(collider.tag == "enemybullettag"))
        {
            Destroy(gameObject);
        }
    }
}
