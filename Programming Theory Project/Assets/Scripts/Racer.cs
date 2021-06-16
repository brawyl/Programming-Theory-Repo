using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//base class for racers
public abstract class Racer : MonoBehaviour
{
    public abstract string racerName { get; }
    public abstract string description { get; }
    public abstract float speed { get; }
    public abstract float luck { get; }

    public void Accelerate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * speed, ForceMode.Impulse);
    }

    public void LuckyBoost()
    {
        float randomNumber = Random.Range(0f, 100f);
        if (randomNumber <= luck)
        {
            Accelerate();
        }
    }

    private void OnMouseDown()
    {
        SelectRacer();
    }

    public void SelectRacer()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (!gameManager.gameStart)
        {
            gameManager.selector.SetActive(true);
            gameManager.selector.transform.position = new Vector3(transform.position.x, 0f, transform.position.z + (transform.position.z * 0.1f));

            gameManager.nameText.text = racerName;
            gameManager.infoText.text = description;
        }
    }
}
