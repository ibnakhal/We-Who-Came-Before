using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationControl : MonoBehaviour {

    [Header("Populations")]
    public float m_population;
    public int m_MaxPopulation;
    public float m_PopulationGrowthRate;
    public float m_GrowthInterval;
    [Header("Script Links")]
    public CrisisManager m_Crisis;
    public TechTree m_Tech;
	void Start () {
        StartCoroutine(GrowthRate());
	}
	
	// Update is called once per frame
	void Update () {
		if( m_population >= m_MaxPopulation)
        {
            m_Crisis.m_Overpopulated = true;
        }
	}

    public IEnumerator GrowthRate()
    {
        while(isActiveAndEnabled)
        {
            yield return new WaitForSeconds(m_GrowthInterval);
            m_population += m_PopulationGrowthRate;
            Debug.Log(m_population + " Because of " + m_PopulationGrowthRate);
        }
    }
}
