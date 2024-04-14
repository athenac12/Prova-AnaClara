using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator Prova;
    private Transform character;
    private float xValue;
    void Start()
    {
        character = gameObject.GetComponent<Transform>();
        xValue = character.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !Prova.GetBool("Walk"))
        {
            character.localScale = new Vector3(xValue, character.localScale.y, character.localScale.z);
            Prova.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.A) && Prova.GetBool("Walk"))
        {
            Prova.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.D) && !Prova.GetBool("Walk"))
        {
            character.localScale = new Vector3(xValue * -1, character.localScale.y, character.localScale.z);
            Prova.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.D) && Prova.GetBool("Walk"))
        {
            Prova.SetBool("Walk", false);
        }

        // esse dq é a animação para correr
        if (Input.GetKeyDown(KeyCode.S) && !Prova.GetBool("Run"))
        {
            character.localScale = new Vector3(xValue, character.localScale.y, character.localScale.z);
            Prova.SetBool("Run", true);
        }
        else if (Input.GetKeyUp(KeyCode.S) && Prova.GetBool("Run"))
        {
            Prova.SetBool("Run", false);
        }
        if (Input.GetKeyDown(KeyCode.F) && !Prova.GetBool("Run"))
        {
            character.localScale = new Vector3(xValue * -1, character.localScale.y, character.localScale.z);
            Prova.SetBool("Run", true);
        }
        else if (Input.GetKeyUp(KeyCode.F) && Prova.GetBool("Run"))
        {
            Prova.SetBool("Run", false);
        }

        // esse dq é a animação para rolar
        if (Input.GetKeyDown(KeyCode.Q) && !Prova.GetBool("Roll"))
        {
            character.localScale = new Vector3(xValue, character.localScale.y, character.localScale.z);
            Prova.SetBool("Roll", true);
        }
        else if (Input.GetKeyUp(KeyCode.Q) && Prova.GetBool("Roll"))
        {
            Prova.SetBool("Roll", false);
        }
        if (Input.GetKeyDown(KeyCode.W) && !Prova.GetBool("Roll"))
        {
            character.localScale = new Vector3(xValue * -1, character.localScale.y, character.localScale.z);
            Prova.SetBool("Roll", true);
        }
        else if (Input.GetKeyUp(KeyCode.W) && Prova.GetBool("Roll"))
        {
            Prova.SetBool("Roll", false);
        }
        

        // esse dq é a animação para pular
        if (Input.GetButtonDown("Jump") && !Prova.GetBool("Jump"))
        {
            character.localScale = new Vector3(xValue, character.localScale.y, character.localScale.z);
            Prova.SetBool("Jump", true);
        }
        else if (Input.GetButtonUp("Jump") && Prova.GetBool("Jump"))
        {
            Prova.SetBool("Jump", false);
        }
        if (Input.GetButtonDown("Jump") && !Prova.GetBool("Jump"))
        {
            character.localScale = new Vector3(xValue * -1, character.localScale.y, character.localScale.z);
            Prova.SetBool("Jump", true);
        }
        else if (Input.GetButtonUp("Jump") && Prova.GetBool("Jump"))
        {
            Prova.SetBool("Jump", false);
        }
        // esse dq é a animação para atacar

        if (Input.GetKeyDown(KeyCode.Z) && !Prova.GetBool("Atack"))
        {
            character.localScale = new Vector3(xValue, character.localScale.y, character.localScale.z);
            Prova.SetBool("Atack", true);
        }
        else if (Input.GetKeyUp(KeyCode.Z) && Prova.GetBool("Atack"))
        {
            Prova.SetBool("Atack", false);
        }
        if (Input.GetKeyDown(KeyCode.X) && !Prova.GetBool("Atack"))
        {
            character.localScale = new Vector3(xValue * -1, character.localScale.y, character.localScale.z);
            Prova.SetBool("Atack", true);
        }
        else if (Input.GetKeyUp(KeyCode.X) && Prova.GetBool("Atack"))
        {
            Prova.SetBool("Atack", false);
        }

        //agachar 

        if (Input.GetKeyDown(KeyCode.C) && !Prova.GetBool("Crounch"))
        {
            character.localScale = new Vector3(xValue, character.localScale.y, character.localScale.z);
            Prova.SetBool("Crounch", true);
        }
        else if (Input.GetKeyUp(KeyCode.C) && Prova.GetBool("Crounch"))
        {
            Prova.SetBool("Crounch", false);
        }
        if (Input.GetKeyDown(KeyCode.V) && !Prova.GetBool("Crounch"))
        {
            character.localScale = new Vector3(xValue * -1, character.localScale.y, character.localScale.z);
            Prova.SetBool("Crounch", true);
        }
        else if (Input.GetKeyUp(KeyCode.V) && Prova.GetBool("Crounch"))
        {
            Prova.SetBool("Crounch", false);
        }
    }
}


