using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/common/EnvironmentUtilities", DoNotGenerateAcw=true)]
	public partial class EnvironmentUtilities : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/common/EnvironmentUtilities", typeof (EnvironmentUtilities));
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

		protected EnvironmentUtilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/constructor[@name='EnvironmentUtilities' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvironmentUtilities ()
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

		public static unsafe string AppCachePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getAppCachePath' and count(parameter)=0]"
			[Register ("getAppCachePath", "()Ljava/lang/String;", "GetGetAppCachePathHandler")]
			get {
				const string __id = "getAppCachePath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string AppSDCardPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getAppSDCardPath' and count(parameter)=0]"
			[Register ("getAppSDCardPath", "()Ljava/lang/String;", "GetGetAppSDCardPathHandler")]
			get {
				const string __id = "getAppSDCardPath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string AppSecondCachePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getAppSecondCachePath' and count(parameter)=0]"
			[Register ("getAppSecondCachePath", "()Ljava/lang/String;", "GetGetAppSecondCachePathHandler")]
			get {
				const string __id = "getAppSecondCachePath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int DomTmpStgMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getDomTmpStgMax' and count(parameter)=0]"
			[Register ("getDomTmpStgMax", "()I", "GetGetDomTmpStgMaxHandler")]
			get {
				const string __id = "getDomTmpStgMax.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int ItsTmpStgMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getItsTmpStgMax' and count(parameter)=0]"
			[Register ("getItsTmpStgMax", "()I", "GetGetItsTmpStgMaxHandler")]
			get {
				const string __id = "getItsTmpStgMax.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int MapTmpStgMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getMapTmpStgMax' and count(parameter)=0]"
			[Register ("getMapTmpStgMax", "()I", "GetGetMapTmpStgMaxHandler")]
			get {
				const string __id = "getMapTmpStgMax.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string SDCardPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='getSDCardPath' and count(parameter)=0]"
			[Register ("getSDCardPath", "()Ljava/lang/String;", "GetGetSDCardPathHandler")]
			get {
				const string __id = "getSDCardPath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='setSDCardPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSDCardPath", "(Ljava/lang/String;)V", "GetSetSDCardPath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSDCardPath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.common']/class[@name='EnvironmentUtilities']/method[@name='initAppDirectory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initAppDirectory", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitAppDirectory (global::Android.Content.Context p0)
		{
			const string __id = "initAppDirectory.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
