using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Hazel;

public sealed class ObjectPool<T> where T : IRecyclable
{
	private int numberCreated;

	private readonly List<T> pool;

	private readonly ConcurrentDictionary<T, bool> inuse;

	private readonly Func<T> objectFactory;

	public ObjectPool(Func<T> objectFactory)
	{
		throw null;
	}

	public T GetObject()
	{
		throw null;
	}

	public void PutObject(T item)
	{
		throw null;
	}
}
