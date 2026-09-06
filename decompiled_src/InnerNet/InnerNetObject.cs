using System;
using Hazel;
using UnityEngine;

namespace InnerNet;

public abstract class InnerNetObject : MonoBehaviour, IComparable<InnerNetObject>
{
	public uint SpawnId;

	public uint NetId;

	public uint DirtyBits;

	public SpawnFlags SpawnFlags;

	public SendOption sendMode;

	public int OwnerId;

	protected bool DespawnOnDestroy;

	public bool AmOwner
	{
		get
		{
			throw null;
		}
	}

	public virtual bool IsDirty
	{
		get
		{
			throw null;
		}
	}

	public virtual bool Chunked
	{
		get
		{
			throw null;
		}
	}

	public void Despawn()
	{
		throw null;
	}

	public virtual void OnDestroy()
	{
		throw null;
	}

	public abstract void HandleRpc(byte callId, MessageReader reader);

	public abstract bool Serialize(MessageWriter writer, bool initialState);

	public abstract void Deserialize(MessageReader reader, bool initialState);

	public int CompareTo(InnerNetObject other)
	{
		throw null;
	}

	protected void SetDirtyBit(uint val)
	{
		throw null;
	}

	protected void ClearDirtyBits()
	{
		throw null;
	}

	protected InnerNetObject()
	{
		throw null;
	}
}
