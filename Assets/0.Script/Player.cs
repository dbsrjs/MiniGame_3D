using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator m_animator = null;
    [HideInInspector] public bool isStart = false;
    [HideInInspector] public bool isFinish = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_animator.SetBool("Crouch", true);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            m_animator.SetBool("Crouch", false);
        }
        */
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Door")
        {
            GameObject.Find("DoorAnimation").GetComponent<Animator>().SetTrigger("open");
        }

        if (other.name == "EndBox")
        {
            isFinish = true;
        }

        if (other.GetComponent<Wood>())
        {
            Vector3 vec = transform.position;
            vec.x -= 1;
            transform.position = vec;
            Destroy(other.GetComponent<CapsuleCollider>());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "Door")
        {
            GameObject.Find("DoorAnimation").GetComponent<Animator>().SetTrigger("close");
        }

        if(other.name == "StartBox")
        {
            isStart = true;
        }
    }

    public void Dead()
    {
        GetComponent<SimpleSampleCharacterControl>().m_moveSpeed = 0;
        GetComponent<Animator>().SetTrigger("Wave");
    }

    public void ShitDown()
    {
        GetComponent<CapsuleCollider>().center = new Vector3(0, 0.25f, 0);
        GetComponent<CapsuleCollider>().height = 0.5f;
    }

    public void StandUP()
    {
        GetComponent<CapsuleCollider>().height = 1f;
        GetComponent<CapsuleCollider>().center = new Vector3(0, 0.5f, 0);
    }
}
