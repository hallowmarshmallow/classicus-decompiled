using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExileController : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GameData.PlayerInfo, bool> _003C_003E9__15_0;

		internal bool _003CBegin_003Eb__15_0(GameData.PlayerInfo p)
		{
			return false;
		}
	}

	private sealed class _003CAnimate_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExileController _003C_003E4__this;

		private Vector2 _003Cleft_003E5__2;

		private Vector2 _003Cright_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimate_003Ed__17(int _003C_003E1__state)
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

	public static ExileController Instance;

	public TextRenderer ImpostorText;

	public TextRenderer Text;

	public SpriteRenderer Player;

	public bool reallydoit;

	public SpriteRenderer PlayerHat;

	public HatParent PlayerHatParent;

	public SpriteRenderer PlayerSkin;

	public AnimationCurve LerpCurve;

	public float Duration;

	public AudioClip TextSound;

	protected string completeString;

	protected GameData.PlayerInfo exiled;

	private bool _wrapUpCalled;

	protected virtual void OnDestroy()
	{
	}

	public void Begin(GameData.PlayerInfo exiled, bool tie)
	{
	}

	private void ApplyExileCosmetics(GameData.PlayerInfo info)
	{
	}

	protected virtual IEnumerator Animate()
	{
		return null;
	}

	private void SetExileHat(string hatId, int colorId)
	{
	}

	protected void WrapUp()
	{
	}
}
