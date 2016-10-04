using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

  public Character character;
  public float speed = 5;
  private Animator anim;
  private Rigidbody2D myRigibody;
  private bool moving;
  private Vector2 lastMove;
  // Use this for initialization
  void Start () {
    anim = GetComponent<Animator>();
    character = new Character();
    myRigibody = GetComponent<Rigidbody2D>();
  }
  
  // Update is called once per frame
  void Update () { 
    float yAxis = Input.GetAxisRaw("Vertical");
    float xAxis = Input.GetAxisRaw("Horizontal");
    moving = false;

    
    if (xAxis != 0f){
      // transform.Translate(
      //   new Vector3(xAxis * Time.deltaTime * speed, 0f, 0f)
      // );
      myRigibody.velocity = new Vector2(xAxis * speed, myRigibody.velocity.y);
      lastMove.Set(
        xAxis,
        0f
      );
      moving = true;
    } else {
      myRigibody.velocity = new Vector2(0f, myRigibody.velocity.y);
    }
    
    if(yAxis != 0f) {
      // transform.Translate(
      //   new Vector3(0f, yAxis * Time.deltaTime * speed, 0f)
      // );
      myRigibody.velocity = new Vector2(myRigibody.velocity.x, yAxis * speed);
      lastMove.Set(
        0f,
        yAxis
      );
      moving = true;
    } else {
      myRigibody.velocity = new Vector2(myRigibody.velocity.x, 0f);
    }


    anim.SetFloat("MoveX", xAxis);
    anim.SetFloat("MoveY", yAxis);
    anim.SetFloat("LastMoveX", lastMove.x);
    anim.SetFloat("LastMoveY", lastMove.y);
    anim.SetBool("Moving", moving);
  }
}
