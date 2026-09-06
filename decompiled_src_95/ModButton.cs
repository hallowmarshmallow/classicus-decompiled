using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ModButton : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__7_1;

		internal void _003CDownload_003Eb__7_1(string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public TextMeshPro label;

		internal void _003CDownload_003Eb__0(float progress)
		{
		}
	}

	private sealed class _003CDownload_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ModButton _003C_003E4__this;

		private GameObject _003Cpanel_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownload_003Ed__7(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public bool isOnline;

	public ModInfo modInfo;

	public SpriteRenderer modLogo;

	public TextMeshPro modTitle;

	public TextMeshPro modDescription;

	public void Bind(ModInfo mod, bool online)
	{
	}

	public void Uninstall()
	{
	}

	private IEnumerator Download()
	{
		return null;
	}

	private void _003CBind_003Eb__5_0(Sprite sprite)
	{
	}
}
