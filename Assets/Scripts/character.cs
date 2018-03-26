using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class character : MonoBehaviour {

    public Animator animator;

    [SerializeField]
    private float speed;
    
    protected Vector2 direction;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        move();
    }

    public void move(){
        transform.Translate(direction * speed * Time.deltaTime);

        AnimateMovement(direction);

    }
    public void AnimateMovement(Vector2 direction){
        animator.SetFloat("X", direction.x);
        animator.SetFloat("Y", direction.y);
    
    }

}
