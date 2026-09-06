using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class ModButton : MonoBehaviour
{
	private sealed class _003CDownload_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ModButton _003C_003E4__this;

		private GameObject _003Cdownloading_003E5__2;

		private TextMeshPro _003Ctmp_003E5__3;

		private string _003Coutputfile_003E5__4;

		private UnityWebRequest _003Cwww_003E5__5;

		private UnityWebRequestAsyncOperation _003CasyncOperation_003E5__6;

		private float _003CtimeStart_003E5__7;

		private float _003Ctimeout_003E5__8;

		private float _003CminAvgSpeedThreshold_003E5__9;

		private float _003CtotalDownloaded_003E5__10;

		private int _003CnumSamples_003E5__11;

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

		public _003CDownload_003Ed__6(int _003C_003E1__state)
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

	public bool isOnline;

	public ModInfo modInfo;

	public SpriteRenderer modLogo;

	public TextMeshPro modTitle;

	public TextMeshPro modDescription;

	public void Uninstall()
	{
		throw null;
	}

	public IEnumerator Download()
	{
		throw null;
	}

	public ModButton()
	{
		throw null;
	}
}
