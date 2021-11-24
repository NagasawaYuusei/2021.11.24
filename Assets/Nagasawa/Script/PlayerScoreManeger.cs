using UnityEngine;

public class PlayerScoreManeger : MonoBehaviour
{
    int m_score;
    float m_time;
    int m_getMoney;
    [SerializeField] int[] m_getMoneys;
    [SerializeField] int m_oneSecondGet;
    [SerializeField] int m_timeMoney;
    [SerializeField] GameObject[] m_moneyObject;

    /// <summary>
    /// カプセル化開始
    /// </summary>

    public int Score
    {
        get
        {
            return m_score;
        }
    }

    /// <summary>
    /// カプセル化開始
    /// </summary>
    void Start()
    {
        m_score = 1;
    }

    void Update()
    {
        Money();
        PlayerChange();
        Debug.Log(m_score);
    }

    void Money()
    {
        m_time += Time.deltaTime;
        if (m_time >= m_timeMoney)
        {
            m_score += m_oneSecondGet;
            m_time = 0;
        }

        if (m_score <= 0)
        {
            m_score = 0;
        }
    }

    void PlayerChange()
    {
        if (m_score >= 0 && m_score < 10)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[0].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[0], transform);
                m_getMoney = m_getMoneys[0];
            }   
        }
        else if (m_score >= 10 && m_score < 50)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[1].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[1], transform);
                m_getMoney = m_getMoneys[1];
            }
        }
        else if (m_score >= 50 && m_score < 100)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[2].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[2], transform);
                m_getMoney = m_getMoneys[2];
            }
        }
        else if (m_score >= 100 && m_score < 500)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[3].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[3], transform);
                m_getMoney = m_getMoneys[3];
            }
        }
        else if (m_score >= 500 && m_score < 1000)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[4].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[4], transform);
                m_getMoney = m_getMoneys[4];
            }
        }
        else if (m_score >= 1000 && m_score < 5000)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[5].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[5], transform);
                m_getMoney = m_getMoneys[5];
            }
        }
        else if (m_score >= 5000 && m_score < 10000)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[6].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[6], transform);
                m_getMoney = m_getMoneys[6];
            }
        }
        else if (m_score >= 10000 && m_score < 50000)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[7].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[7], transform);
                m_getMoney = m_getMoneys[7];
            }
        }
        else if (m_score >= 50000)
        {
            GameObject child = transform.GetChild(0).gameObject;
            if (child.tag != m_moneyObject[8].tag)
            {
                Destroy(child);
                Instantiate(m_moneyObject[8], transform);
                m_getMoney = m_getMoneys[8];
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Money")
        {
            m_score += m_getMoney;
        }

        if (collision.tag == "Zeikin")
        {
            m_score -= m_getMoney;
        }
    }
}
