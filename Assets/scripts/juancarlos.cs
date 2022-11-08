
using UnityEngine;

public class juancarlos : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 0.5f;
    public int maxHealth = 100;
    public int playerHealth;
    public Animator anim;
    public void OnCollisionEnter(Collision other)
    {
        if (other.transform.gameObject.tag == "enemy")
        {
            playerHealth = playerHealth - 10;
            Debug.Log("Las criaturas te atacan, nunca saldrás con vida");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        CheckRotation();
        Perdiste();
        if(Input.GetKeyDown(KeyCode.W))
        { 
            anim.SetBool("estaCorriendo",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("estaCorriendo", false);
        }
    }
    void CheckMovement()
    {
        var xMove = transform.right * (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
        var zMove = transform.forward * (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        var move = xMove + zMove;

        transform.position += move;
    }
    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime * 100;

        transform.Rotate(0f, rotation, 0f);
    }

    void Perdiste()
    {
        if (playerHealth <= 0)
        {
            Debug.Log("You Died, Ñery");
        }
    }
}
