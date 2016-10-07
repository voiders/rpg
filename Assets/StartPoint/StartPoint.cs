using UnityEngine;
using System.Collections;

public class StartPoint : MonoBehaviour {

  private CharacterController theCharacter;
  private CameraController theCamera;


  // Use this for initialization
  void Start () {
    Debug.Log("Start" + transform.position.ToString());
    theCharacter = FindObjectOfType<CharacterController>();
    theCharacter.transform.position = transform.position;

    theCamera = FindObjectOfType<CameraController>();
    theCamera.transform.position = new Vector3(
      transform.position.x,
      transform.position.y,
      theCamera.transform.position.z
    );
  }
  
  // Update is called once per frame
  void Update () {
  
  }
}
