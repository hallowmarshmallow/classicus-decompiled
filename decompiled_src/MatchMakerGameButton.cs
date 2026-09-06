using System;
using System.Collections;
using System.Collections.Generic;
using InnerNet;
using PowerTools;
using UnityEngine;

public class MatchMakerGameButton : PoolableBehavior, IConnectButton
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__15_0;

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CConnectForFindGame_003Eb__15_0()
		{
			throw null;
		}
	}

	private sealed class _003CConnectForFindGame_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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

		public _003CConnectForFindGame_003Ed__15(int _003C_003E1__state)
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

	public TextRenderer NameText;

	public TextRenderer PlayerCountText;

	public TextRenderer ImpostorCountText;

	public SpriteRenderer MapIcon;

	public Sprite[] MapIcons;

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public SpriteRenderer ProximityIcon;

	public Sprite ProximityOnSprite;

	public Sprite ProximityOffSprite;

	public Transform ProximityFilterRoot;

	public GameListing myListing;

	private SpriteRenderer impostorIcon;

	private bool impostorIconSearched;

	private const float ProximityFilterDefaultX = -2.1013f;

	private const float ProximityFilterRunnerX = -1.106f;

	public void OnClick()
	{
		throw null;
	}

	private IEnumerator ConnectForFindGame()
	{
		throw null;
	}

	public void StartIcon()
	{
		throw null;
	}

	public void StopIcon()
	{
		throw null;
	}

	public void SetGame(GameListing gameListing)
	{
		throw null;
	}

	private void SetProximityIcon(bool proximityChat)
	{
		throw null;
	}

	private void SetProximityFilterOffset(bool runner)
	{
		throw null;
	}

	private void SetImpostorInfoVisible(bool visible)
	{
		throw null;
	}

	private Sprite GetMapSprite(byte mapId)
	{
		throw null;
	}

	public MatchMakerGameButton()
	{
		throw null;
	}
}
