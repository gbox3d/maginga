﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;
using UniRx.Triggers;

using UnityEngine.UI;


public class magingaController : MonoBehaviour {


	[SerializeField] GameObject m_btnTest1,m_btnRightArmLift,m_btnShootMissile;
	[SerializeField] GameObject m_leftArmJoint,m_RightArmJoint,m_BodyMissile;


	// Use this for initialization
	void Start () {
		//Button_leftArmLife
		m_btnTest1.transform.GetComponent<Button> ().onClick.AsObservable ().Subscribe ((_) => {
			m_leftArmJoint.transform.GetComponent<Animator>().SetTrigger("leftArmLiftUp");
		});
		m_btnRightArmLift.transform.GetComponent<Button> ().OnClickAsObservable ().Subscribe (_ => {
			m_RightArmJoint.transform.GetComponent<Animator>().SetTrigger("leftArmLiftUp");
		});

		m_btnShootMissile.transform.GetComponent<Button> ().OnClickAsObservable ().Subscribe (_ => {
			m_BodyMissile.transform.GetComponent<Animator>().SetTrigger("shoot");
		});

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
