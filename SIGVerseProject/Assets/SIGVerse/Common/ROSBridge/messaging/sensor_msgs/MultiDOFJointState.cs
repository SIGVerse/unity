// Generated by gencs from sensor_msgs/MultiDOFJointState.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;
using SIGVerse.RosBridge.geometry_msgs;

namespace SIGVerse.RosBridge 
{
	namespace sensor_msgs 
	{
		[System.Serializable]
		public class MultiDOFJointState : RosMessage
		{
			public std_msgs.Header header;
			public System.Collections.Generic.List<string>  joint_names;
			public System.Collections.Generic.List<geometry_msgs.Transform>  transforms;
			public System.Collections.Generic.List<geometry_msgs.Twist>  twist;
			public System.Collections.Generic.List<geometry_msgs.Wrench>  wrench;


			public MultiDOFJointState()
			{
				this.header = new std_msgs.Header();
				this.joint_names = new System.Collections.Generic.List<string>();
				this.transforms = new System.Collections.Generic.List<geometry_msgs.Transform>();
				this.twist = new System.Collections.Generic.List<geometry_msgs.Twist>();
				this.wrench = new System.Collections.Generic.List<geometry_msgs.Wrench>();
			}

			public MultiDOFJointState(std_msgs.Header header, System.Collections.Generic.List<string>  joint_names, System.Collections.Generic.List<geometry_msgs.Transform>  transforms, System.Collections.Generic.List<geometry_msgs.Twist>  twist, System.Collections.Generic.List<geometry_msgs.Wrench>  wrench)
			{
				this.header = header;
				this.joint_names = joint_names;
				this.transforms = transforms;
				this.twist = twist;
				this.wrench = wrench;
			}

			new public static string GetMessageType()
			{
				return "sensor_msgs/MultiDOFJointState";
			}

			new public static string GetMD5Hash()
			{
				return "690f272f0640d2631c305eeb8301e59d";
			}
		} // class MultiDOFJointState
	} // namespace sensor_msgs
} // namespace SIGVerse.ROSBridge

