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

	public bool AmOwner => false;

	public virtual bool IsDirty => false;

	public virtual bool Chunked => false;

	public void Despawn()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public abstract void HandleRpc(byte callId, MessageReader reader);

	public abstract bool Serialize(MessageWriter writer, bool initialState);

	public abstract void Deserialize(MessageReader reader, bool initialState);

	public int CompareTo(InnerNetObject other)
	{
		return 0;
	}

	protected void SetDirtyBit(uint val)
	{
	}

	protected void ClearDirtyBits()
	{
	}
}
