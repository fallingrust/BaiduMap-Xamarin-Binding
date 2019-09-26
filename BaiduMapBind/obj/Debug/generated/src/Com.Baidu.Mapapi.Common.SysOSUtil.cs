using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/common/SysOSUtil", DoNotGenerateAcw=true)]
	public partial class SysOSUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/common/SysOSUtil", typeof (SysOSUtil));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SysOSUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/constructor[@name='SysOSUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SysOSUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe float Density {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getDensity' and count(parameter)=0]"
			[Register ("getDensity", "()F", "GetGetDensityHandler")]
			get {
				const string __id = "getDensity.()F";
				try {
					var __rm = _members.StaticMethods.InvokeSingleMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int DensityDpi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getDensityDpi' and count(parameter)=0]"
			[Register ("getDensityDpi", "()I", "GetGetDensityDpiHandler")]
			get {
				const string __id = "getDensityDpi.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler")]
			get {
				const string __id = "getDeviceID.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string ModuleFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getModuleFileName' and count(parameter)=0]"
			[Register ("getModuleFileName", "()Ljava/lang/String;", "GetGetModuleFileNameHandler")]
			get {
				const string __id = "getModuleFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string PhoneType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getPhoneType' and count(parameter)=0]"
			[Register ("getPhoneType", "()Ljava/lang/String;", "GetGetPhoneTypeHandler")]
			get {
				const string __id = "getPhoneType.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int ScreenSizeX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getScreenSizeX' and count(parameter)=0]"
			[Register ("getScreenSizeX", "()I", "GetGetScreenSizeXHandler")]
			get {
				const string __id = "getScreenSizeX.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int ScreenSizeY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='SysOSUtil']/method[@name='getScreenSizeY' and count(parameter)=0]"
			[Register ("getScreenSizeY", "()I", "GetGetScreenSizeYHandler")]
			get {
				const string __id = "getScreenSizeY.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
