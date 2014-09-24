// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;

namespace SmartQuant
{
	public class TimeSeries : ISeries
	{
		protected string name;
		protected string description;

		public TimeSeries ()
		{
		}

		public string Name 
		{
			get {
				return name;
			}
		}

		public string Description
		{
			get { 
				return description;
			}
		}

		public virtual int Count {
			get { throw new NotImplementedException (); }
		}

		public List<Indicator> Indicators {
			get { throw new NotImplementedException (); }
		}

        public virtual double First {
			get { throw new NotImplementedException (); }
		}

        public virtual double Last {
			get { throw new NotImplementedException (); }
		}

        public virtual DateTime FirstDateTime {
			get { throw new NotImplementedException (); }
		}

        public virtual DateTime LastDateTime {
			get { throw new NotImplementedException (); }
		}

        public virtual double this [int index] {
			get { throw new NotImplementedException (); }
            set { throw new NotImplementedException (); }
		}

        public virtual double this [int index, BarData barData] {
			get { throw new NotImplementedException (); }
		}

        public double this[int index, int row]
        {
            get { throw new NotImplementedException (); }
        }

        public double this[DateTime dateTime, SearchOption option = SearchOption.ExactFirst]
        {
            get { throw new NotImplementedException (); }
            set
            {
                this.Add(dateTime, value);
            }
        }

		public virtual int GetIndex (DateTime dateTime, IndexOption option = IndexOption.Null)
		{
			throw new NotImplementedException ();
		}

		public virtual DateTime GetDateTime (int index)
		{
			throw new NotImplementedException ();
		}

        public virtual double GetMin (DateTime dateTime1, DateTime dateTime2)
		{
			throw new NotImplementedException ();
		}

		public virtual double GetMin (int index1, int index2, BarData barData)
		{
			throw new NotImplementedException ();
		}

        public virtual double GetMax (DateTime dateTime1, DateTime dateTime2)
		{
			throw new NotImplementedException ();
		}

		public virtual double GetMax (int index1, int index2, BarData barData)
		{
			throw new NotImplementedException ();
		}

        public void Clear()
        {
            throw new NotImplementedException ();
        }

        public void Add(System.DateTime dateTime, double value)
        {
            throw new NotImplementedException ();
        }
	}
}

