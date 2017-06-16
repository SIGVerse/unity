// Generated by gencs from geometry_msgs/TwistWithCovariance.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;

using SIGVerse.ROSBridge.geometry_msgs;

namespace SIGVerse.ROSBridge 
{
	namespace geometry_msgs 
	{
		[System.Serializable]
		public class TwistWithCovariance : ROSMessage
		{
			public geometry_msgs.Twist twist;
			public double[]  covariance;


			public TwistWithCovariance()
			{
				this.twist = new geometry_msgs.Twist();
				this.covariance = new double[36];
			}

			public TwistWithCovariance(geometry_msgs.Twist twist, double[]  covariance)
			{
				this.twist = twist;
				this.covariance = covariance;
			}

			new public static string GetMessageType()
			{
				return "geometry_msgs/TwistWithCovariance";
			}

			new public static string GetMD5Hash()
			{
				return "1fe8a28e6890a4cc3ae4c3ca5c7d82e6";
			}
		} // class TwistWithCovariance
	} // namespace geometry_msgs
} // namespace SIGVerse.ROSBridge
