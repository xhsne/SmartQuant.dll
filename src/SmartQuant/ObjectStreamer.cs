// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.IO;

namespace SmartQuant
{
	public class ObjectStreamer
	{
		protected internal byte typeId;
		protected internal Type type;
		protected internal StreamerManager streamerManager;

		public StreamerManager StreamerManager
		{
			get
			{
				return this.streamerManager;
			}
		}

		public ObjectStreamer()
		{
			this.typeId = DataObjectType.DataObject;
			this.type = typeof(object);
		}

		public virtual object Read(BinaryReader reader)
		{
			throw new NotImplementedException ();
		}

		public virtual void Write(BinaryWriter writer, object obj)
		{
			throw new NotImplementedException ();
		}
	}
}
