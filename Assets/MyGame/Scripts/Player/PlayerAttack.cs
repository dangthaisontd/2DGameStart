using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("DangSon/PlayerAttack")]
public class PlayerAttack : MonoBehaviour
{
    public float radiusAttack = 2f;
    public Transform pointAttack;
    private Animator anim;
    private int isAttackAnimationId;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        isAttackAnimationId = Animator.StringToHash("isAttack");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
           anim.SetTrigger(isAttackAnimationId); 
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        if(pointAttack!=null)
        {
            Gizmos.DrawWireSphere(pointAttack.position, radiusAttack);
        }
    }
}
