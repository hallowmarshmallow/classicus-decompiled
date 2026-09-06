using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaffMenuController : MonoBehaviour
{
	private sealed class _003CCoRegisterButtons_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StaffMenuController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoRegisterButtons_003Ed__28(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	public GameObject StaffMenuObject;

	public GameObject StaffOptionMenuObject;

	public PassiveButton BackdropButton;

	public PassiveButton AnonymousButton;

	public TextMeshPro AnonymousText;

	public PassiveButton NoMuzikButton;

	public TextMeshPro NoMuzikText;

	public AudioClip StaffIntroClip;

	public AudioClip StaffLoopClip;

	public float StaffSequenceVolume;

	public float StaffFadeInDuration;

	private const string PersistentRootName = "StaffMenuPersistent";

	private static StaffMenuController persistentInstance;

	private static bool adoptNextInstance;

	private bool isPersistent;

	private bool dormant;

	private Camera anchorCamera;

	private void Awake()
	{
		throw null;
	}

	private void OnEnable()
	{
		throw null;
	}

	private void OnDisable()
	{
		throw null;
	}

	private void OnDestroy()
	{
		throw null;
	}

	private void Start()
	{
		throw null;
	}

	private void DiscardSceneCopy()
	{
		throw null;
	}

	private void PromoteToPersistent()
	{
		throw null;
	}

	private void LateUpdate()
	{
		throw null;
	}

	private static Camera ResolveAnchorCamera()
	{
		throw null;
	}

	private void HandleSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		throw null;
	}

	private void QueueButtonRegistration()
	{
		throw null;
	}

	private IEnumerator CoRegisterButtons()
	{
		throw null;
	}

	private void RegisterButtons()
	{
		throw null;
	}

	private void ResolveNoMuzikButton()
	{
		throw null;
	}

	private static Transform FindChildDeep(Transform root, string name)
	{
		throw null;
	}

	public void RefreshStaffMenuVisibility()
	{
		throw null;
	}

	private static bool IsStaffMenuScene()
	{
		throw null;
	}

	private void StartStaffMusic()
	{
		throw null;
	}

	public void CloseStaffOptionMenu()
	{
		throw null;
	}

	private void OnAnonymousClicked()
	{
		throw null;
	}

	private void RefreshAnonymousLabel()
	{
		throw null;
	}

	private void OnNoMuzikClicked()
	{
		throw null;
	}

	private void RestartDefaultMusic()
	{
		throw null;
	}

	private void RefreshNoMuzikLabel()
	{
		throw null;
	}

	public StaffMenuController()
	{
		throw null;
	}
}
