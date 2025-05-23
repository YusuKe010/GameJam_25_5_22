using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpUI : MonoBehaviour
{
    [SerializeField] GameObject lifeimage;
    [SerializeField] GameObject parent;
    [SerializeField] PlayerHealth _health;

    List<GameObject> lifeimagelist=new List<GameObject>();

    private void Start()
    {

        for(int i = 0; i < _health.MaxHP; i++)
        {
            GameObject obj = Instantiate(lifeimage, parent.transform);
            lifeimagelist.Add(obj);
        }

        _health.OnTakeDamage += updatelife;
        _health.OnDeth += updatelife;
    }

    public void updatelife(string text)
    {
        if (lifeimage == null) return;
        for (int i = 0; i < _health.MaxHP; i++)
        {
            Debug.Log(_health.CurrrentHP);
            if(i> _health.CurrrentHP)
            {
                Debug.Log(i);
                lifeimagelist[i].SetActive(false);
            }
        }
    }
}
