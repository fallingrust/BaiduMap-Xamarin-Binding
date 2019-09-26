using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/LogoPosition", DoNotGenerateAcw=true)]
	public sealed partial class LogoPosition : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionCenterBottom']"
		[Register ("logoPostionCenterBottom")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionCenterBottom {
			get {
				const string __id = "logoPostionCenterBottom.Lcom/baidu/mapapi/map/LogoPosition;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionCenterTop']"
		[Register ("logoPostionCenterTop")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionCenterTop {
			get {
				const string __id = "logoPostionCenterTop.Lcom/baidu/mapapi/map/LogoPosition;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionRightBottom']"
		[Register ("logoPostionRightBottom")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionRightBottom {
			get {
				const string __id = "logoPostionRightBottom.Lcom/baidu/mapapi/map/LogoPosition;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionRightTop']"
		[Register ("logoPostionRightTop")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionRightTop {
			get {
				const string __id = "logoPostionRightTop.Lcom/baidu/mapapi/map/LogoPosition;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionleftBottom']"
		[Register ("logoPostionleftBottom")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionleftBottom {
			get {
				const string __id = "logoPostionleftBottom.Lcom/baidu/mapapi/map/LogoPosition;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/field[@name='logoPostionleftTop']"
		[Register ("logoPostionleftTop")]
		public static global::Com.Baidu.Mapapi.Map.LogoPosition LogoPostionleftTop {
			get {
				const string __id = "logoPostionleftTop.Lcom/baidu/mapapi/map/LogoPosition;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/LogoPosition", typeof (LogoPosition));
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

		internal LogoPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/LogoPosition;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.LogoPosition ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/LogoPosition;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='LogoPosition']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/map/LogoPosition;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.LogoPosition[] Values ()
		{
			const string __id = "values.()[Lcom/baidu/mapapi/map/LogoPosition;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Baidu.Mapapi.Map.LogoPosition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.LogoPosition));
			} finally {
			}
		}

	}
}
