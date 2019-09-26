using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkvi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkvi/VDeviceAPI", DoNotGenerateAcw=true)]
	public partial class VDeviceAPI : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkvi/VDeviceAPI", typeof (VDeviceAPI));
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

		protected VDeviceAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/constructor[@name='VDeviceAPI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VDeviceAPI ()
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

		public static unsafe string AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getAppVersion' and count(parameter)=0]"
			[Register ("getAppVersion", "()Ljava/lang/String;", "GetGetAppVersionHandler")]
			get {
				const string __id = "getAppVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe long AvailableMemory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getAvailableMemory' and count(parameter)=0]"
			[Register ("getAvailableMemory", "()J", "GetGetAvailableMemoryHandler")]
			get {
				const string __id = "getAvailableMemory.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string CachePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getCachePath' and count(parameter)=0]"
			[Register ("getCachePath", "()Ljava/lang/String;", "GetGetCachePathHandler")]
			get {
				const string __id = "getCachePath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int CurrentNetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getCurrentNetworkType' and count(parameter)=0]"
			[Register ("getCurrentNetworkType", "()I", "GetGetCurrentNetworkTypeHandler")]
			get {
				const string __id = "getCurrentNetworkType.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe long FreeSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getFreeSpace' and count(parameter)=0]"
			[Register ("getFreeSpace", "()J", "GetGetFreeSpaceHandler")]
			get {
				const string __id = "getFreeSpace.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsWifiConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='isWifiConnected' and count(parameter)=0]"
			[Register ("isWifiConnected", "()Z", "GetIsWifiConnectedHandler")]
			get {
				const string __id = "isWifiConnected.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string ModuleFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getModuleFileName' and count(parameter)=0]"
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

		public static unsafe string OsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getOsVersion' and count(parameter)=0]"
			[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
			get {
				const string __id = "getOsVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int ScreenBrightness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getScreenBrightness' and count(parameter)=0]"
			[Register ("getScreenBrightness", "()I", "GetGetScreenBrightnessHandler")]
			get {
				const string __id = "getScreenBrightness.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe float ScreenDensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getScreenDensity' and count(parameter)=0]"
			[Register ("getScreenDensity", "()F", "GetGetScreenDensityHandler")]
			get {
				const string __id = "getScreenDensity.()F";
				try {
					var __rm = _members.StaticMethods.InvokeSingleMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int ScreenDensityDpi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getScreenDensityDpi' and count(parameter)=0]"
			[Register ("getScreenDensityDpi", "()I", "GetGetScreenDensityDpiHandler")]
			get {
				const string __id = "getScreenDensityDpi.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe long SdcardFreeSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getSdcardFreeSpace' and count(parameter)=0]"
			[Register ("getSdcardFreeSpace", "()J", "GetGetSdcardFreeSpaceHandler")]
			get {
				const string __id = "getSdcardFreeSpace.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string SdcardPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getSdcardPath' and count(parameter)=0]"
			[Register ("getSdcardPath", "()Ljava/lang/String;", "GetGetSdcardPathHandler")]
			get {
				const string __id = "getSdcardPath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe long SdcardTotalSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getSdcardTotalSpace' and count(parameter)=0]"
			[Register ("getSdcardTotalSpace", "()J", "GetGetSdcardTotalSpaceHandler")]
			get {
				const string __id = "getSdcardTotalSpace.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe float SystemMetricsX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getSystemMetricsX' and count(parameter)=0]"
			[Register ("getSystemMetricsX", "()F", "GetGetSystemMetricsXHandler")]
			get {
				const string __id = "getSystemMetricsX.()F";
				try {
					var __rm = _members.StaticMethods.InvokeSingleMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe float SystemMetricsY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getSystemMetricsY' and count(parameter)=0]"
			[Register ("getSystemMetricsY", "()F", "GetGetSystemMetricsYHandler")]
			get {
				const string __id = "getSystemMetricsY.()F";
				try {
					var __rm = _members.StaticMethods.InvokeSingleMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe long TotalMemory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getTotalMemory' and count(parameter)=0]"
			[Register ("getTotalMemory", "()J", "GetGetTotalMemoryHandler")]
			get {
				const string __id = "getTotalMemory.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe long TotalSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='getTotalSpace' and count(parameter)=0]"
			[Register ("getTotalSpace", "()J", "GetGetTotalSpaceHandler")]
			get {
				const string __id = "getTotalSpace.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='makeCall' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeCall", "(Ljava/lang/String;)V", "")]
		public static unsafe void MakeCall (string p0)
		{
			const string __id = "makeCall.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='onNetworkStateChanged' and count(parameter)=0]"
		[Register ("onNetworkStateChanged", "()V", "")]
		public static unsafe void OnNetworkStateChanged ()
		{
			const string __id = "onNetworkStateChanged.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='openUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openUrl", "(Ljava/lang/String;)V", "")]
		public static unsafe void OpenUrl (string p0)
		{
			const string __id = "openUrl.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='sendMMS' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("sendMMS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int SendMMS (string p0, string p1, string p2, string p3)
		{
			const string __id = "sendMMS.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='sendSMS' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendSMS", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendSMS (string p0, string p1)
		{
			const string __id = "sendSMS.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='setNetworkChangedCallback' and count(parameter)=0]"
		[Register ("setNetworkChangedCallback", "()V", "")]
		public static unsafe void SetNetworkChangedCallback ()
		{
			const string __id = "setNetworkChangedCallback.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='setScreenAlwaysOn' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScreenAlwaysOn", "(Z)V", "")]
		public static unsafe void SetScreenAlwaysOn (bool p0)
		{
			const string __id = "setScreenAlwaysOn.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='setupSoftware' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setupSoftware", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetupSoftware (string p0)
		{
			const string __id = "setupSoftware.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VDeviceAPI']/method[@name='unsetNetworkChangedCallback' and count(parameter)=0]"
		[Register ("unsetNetworkChangedCallback", "()V", "")]
		public static unsafe void UnsetNetworkChangedCallback ()
		{
			const string __id = "unsetNetworkChangedCallback.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
