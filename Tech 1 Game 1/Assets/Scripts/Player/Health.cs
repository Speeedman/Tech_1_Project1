using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image HPBar;
    public float HP;
    float MaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = HP;
    }

    // Update is called once per frame
    void Update()
    {
        HPBar.fillAmount = HP / MaxHealth;
        if(HP <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void TakeDamage(float damage)
    {
        HP -= damage;
    }
}
