
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject Luz1;
    public GameObject Luz2;
    public GameObject Luz3;
    public GameObject Luz4;
    public GameObject Luz5;
    public GameObject Luz6;
    public GameObject Luz7;

    public GameObject enemyX;
    //public Transform spotSpw;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name == "juancarlos")
        {
            Luz1.SetActive(false);
            Luz2.SetActive(false);
            Luz3.SetActive(false);
            Luz4.SetActive(false);
            Luz5.SetActive(false);
            Luz6.SetActive(false);
            Luz7.SetActive(false);
            enemyX.SetActive(true);
            Debug.Log("apagando las luces");
            //Instantiate(enemyX, spotSpw.position, spotSpw.rotation);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 }


