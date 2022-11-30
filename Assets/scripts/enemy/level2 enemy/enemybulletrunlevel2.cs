using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybulletrunlevel2 : MonoBehaviour
{
    public GameObject Enemybullet;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("FireEnemyBullet", 0.2f);
        Invoke("FireEnemyBullet", 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FireEnemyBullet()
    {
        GameObject playerShip = GameObject.Find("Player");

        if (playerShip != null)
        {
            //Debug.Log("shoot");
            GameObject bullet = (GameObject)Instantiate(Enemybullet);

            bullet.transform.position = transform.position;

            Vector2 direction = playerShip.transform.position - bullet.transform.position;

            bullet.GetComponent<enemybullet>().SetDirection(direction);
        }
    }
}
