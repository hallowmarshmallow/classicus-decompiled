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

		internal bool _003CConnectForFindGame_003Eb__15_0()
		{
			return false;
		}
	}

	private sealed class _003CConnectForFindGame_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CConnectForFindGame_003Ed__15(int _003C_003E1__state)
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
	}

	private IEnumerator ConnectForFindGame()
	{
		return null;
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}

	public void SetGame(GameListing gameListing)
	{
	}

	private void SetProximityIcon(bool proximityChat)
	{
	}

	private void SetProximityFilterOffset(bool runner)
	{
	}

	private void SetImpostorInfoVisible(bool visible)
	{
	}

	private Sprite GetMapSprite(byte mapId)
	{
		return null;
	}
}
