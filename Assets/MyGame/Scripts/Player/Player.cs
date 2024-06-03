using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("DangSon/Player")]
public class Player : MonoBehaviour
{
    public int addCoin = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            GameManager.Instance.coinEvent?.Invoke(addCoin);
            Destroy(collision.gameObject);
        }
    }
}
