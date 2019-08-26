using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject verificaplataforma;
    [SerializeField]
    GameObject plataforma;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(player.transform.position.x > verificaplataforma.transform.position.x)
        {

            verificaplataforma.transform.position = new Vector2(player.transform.position.x + 6.7f, 0);

            Instantiate(plataforma, verificaplataforma.transform.position, Quaternion.identity);

            
        }
    }
}
