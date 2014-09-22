// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
	public class IdArray<T>
	{
		private int size;

		public int Size
		{
			get
			{
				return this.size;
			}
		}

		public T this[int id]
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
			
		public IdArray(int size = 1024)
		{
			this.size = size;
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Add(int id, T value)
		{
			throw new NotImplementedException();
		}

		public void Remove(int id)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(IdArray<T> array)
		{
			array.Clear();
			for (int i = 0; i < this.size; ++i)
				array[i] = this[i];
		}
	}
}
