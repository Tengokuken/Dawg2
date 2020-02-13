using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{

    public GameObject[] inventory = new GameObject[2];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        //Finds an open slot in the inventory
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;
                itemAdded = true;
                break;
            }
        }
        if (!itemAdded)
        {
            Debug.Log("inventory full");
        }
    }

    public KeyCode ItemSpace;
    public string MyItemSpace;

    public void UseItem()
    {
        if (Input.GetKey(MyItemSpace))
        {
            BombDetonation();
            float num = 0;
            // Bombs
            if (ButtonClick.moneyItem == 1) // 1 time use bomb; clears room. does not work on boss
            {
                BombDetonation();
            }
            else if (ButtonClick.moneyItem == 2) // Bomb is rechargable; explodes on a 10 sec timer
            {

            }
            else if (ButtonClick.moneyItem == 3) // Bomb can be used 3 times before disappearing. 5 s cooldown
            {
                ButtonClick.RechargeBombCount++;
            }
            // Decoy Dog
            else if (ButtonClick.moneyItem == 4) // Enemies are confused and you become invincible in that room
            {

            }
            // Fan
            else if (ButtonClick.moneyItem == 5) // Knock backs enemies; 3 sec timer
            {

            }
            // Health Items
            else if (ButtonClick.moneyItem == 6) // Doggo biscuit; +500 health. one-time
            {
                ButtonClick.selectedDog._Health += 500;
                ButtonClick.moneyItem = 0;
            }
            else if (ButtonClick.moneyItem == 7) // 50/50 Candy; +50 health. 50 second timer
            {
                ButtonClick.selectedDog._Health += 10;
                ButtonClick.moneyItem = 0;
            }
            // Flashlight
            else if (ButtonClick.moneyItem == 8) // Stuns all enemies for 5 seconds
            {
                num = EnemyAyyEyeGuess.speed;
                for (int i = 0; i < Time.deltaTime * 5; i++)
                {
                    EnemyAyyEyeGuess.speed = 0;
                }
                EnemyAyyEyeGuess.speed = num;
                ButtonClick.moneyItem = 0;
            }
            // Superdog
            else if (ButtonClick.moneyItem == 9) // Doggo kills all things it touches for 5 seconds; does not affect bosses
            {

            }
            else if (ButtonClick.moneyItem == 10) // Fires lazers around doggo
            {

            }
        }
    }

    // bomb stuff ***********************************************************************************************************************************************
    public float bombRadius = 10f;          // Radius within which enemies are killed.
    public float bombForce = 100f;          // Force that enemies are thrown from the blast.
    public AudioClip boom;                  // Audioclip of explosion.
    public AudioClip fuse;                  // Audioclip of fuse.
    public float fuseTime = 1.5f;
    public GameObject explosion;            // Prefab of explosion effect.
    private ParticleSystem explosionFX;		// Reference to the particle system of the explosion effect.

    IEnumerator BombDetonation()
    {
        // Play the fuse audioclip.
        AudioSource.PlayClipAtPoint(fuse, transform.position);

        // Wait for 2 seconds.
        yield return new WaitForSeconds(fuseTime);

        // Explode the bomb.
        BigExplode();
        if (ButtonClick.moneyItem == 1)
        {
            BigExplode();
        }
        else if (ButtonClick.moneyItem == 2)
        {
            RechargeExplode();
        }
        else if (ButtonClick.moneyItem == 3)
        {
            ThreeExplode();
        }
    }

    // bomb 1 - kill everything bomb
    public void BigExplode()
    {

        // Find all the colliders on the Enemies layer within the bombRadius.
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, (bombRadius * 10));

        // Foreach enemy with the tag, destroy them.
        foreach (Collider2D en in enemies)
        {
            if (GetComponent<Collider2D>().tag == "enemy")
            {
                Destroy(GetComponent<Collider2D>().gameObject);
            }
        }

        // Set the explosion effect's position to the bomb's position and play the particle system.
        explosionFX = GameObject.FindGameObjectWithTag("ExplosionFX").GetComponent<ParticleSystem>();
        explosionFX.transform.position = transform.position;
        explosionFX.Play();

        // Instantiate the explosion prefab.
        Instantiate(explosion, transform.position, Quaternion.identity);

        // Play the explosion sound effect.
        AudioSource.PlayClipAtPoint(boom, transform.position);

        // Destroy the bomb.
        Destroy(gameObject);
    }

    //Bomb 2 - kill recharge every 10 seconds
    public void RechargeExplode()
    {

        // Find all the colliders on the Enemies layer within the bombRadius.
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, bombRadius, 1 << LayerMask.NameToLayer("Enemies"));

        // For each collider...
        foreach (Collider2D en in enemies)
        {
            // Check if it has a rigidbody (since there is only one per enemy, on the parent).
            Rigidbody2D rb = en.GetComponent<Rigidbody2D>();
            if (rb != null && rb.tag == "Enemy")
            {
                // Find the Enemy script and set the enemy's health to zero.
                rb.gameObject.GetComponent<Enemy>().HP = 0;

                // Find a vector from the bomb to the enemy.
                Vector3 deltaPos = rb.transform.position - transform.position;

                // Apply a force in this direction with a magnitude of bombForce.
                Vector3 force = deltaPos.normalized * bombForce;
                rb.AddForce(force);
            }
        }

        // Set the explosion effect's position to the bomb's position and play the particle system.
        explosionFX = GameObject.FindGameObjectWithTag("ExplosionFX").GetComponent<ParticleSystem>();
        explosionFX.transform.position = transform.position;
        explosionFX.Play();

        // Instantiate the explosion prefab.
        Instantiate(explosion, transform.position, Quaternion.identity);

        // Play the explosion sound effect.
        AudioSource.PlayClipAtPoint(boom, transform.position);

        // Destroy the bomb.
        Destroy(gameObject);
    }

    // Bomb 3 - only usable 3 times.
    public void ThreeExplode()
    {

        // Find all the colliders on the Enemies layer within the bombRadius.
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, bombRadius, 1 << LayerMask.NameToLayer("Enemies"));

        // For each collider...
        foreach (Collider2D en in enemies)
        {
            // Check if it has a rigidbody (since there is only one per enemy, on the parent).
            Rigidbody2D rb = en.GetComponent<Rigidbody2D>();
            if (rb != null && rb.tag == "Enemy")
            {
                // Find the Enemy script and set the enemy's health to zero.
                rb.gameObject.GetComponent<Enemy>().HP = 0;

                // Find a vector from the bomb to the enemy.
                Vector3 deltaPos = rb.transform.position - transform.position;

                // Apply a force in this direction with a magnitude of bombForce.
                Vector3 force = deltaPos.normalized * bombForce;
                rb.AddForce(force);
            }
        }

        // Set the explosion effect's position to the bomb's position and play the particle system.
        explosionFX = GameObject.FindGameObjectWithTag("ExplosionFX").GetComponent<ParticleSystem>();
        explosionFX.transform.position = transform.position;
        explosionFX.Play();

        // Instantiate the explosion prefab.
        Instantiate(explosion, transform.position, Quaternion.identity);

        // Play the explosion sound effect.
        AudioSource.PlayClipAtPoint(boom, transform.position);

        // Destroy the bomb after 3 uses.
        if (ButtonClick.RechargeBombCount == 3)
        {
            Destroy(gameObject);
        }
    }
}
