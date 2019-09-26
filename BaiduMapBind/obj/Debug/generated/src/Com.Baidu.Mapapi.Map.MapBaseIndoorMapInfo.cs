using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapBaseIndoorMapInfo", DoNotGenerateAcw=true)]
	public sealed partial class MapBaseIndoorMapInfo : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError", DoNotGenerateAcw=true)]
		public sealed partial class SwitchFloorError : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='FLOOR_INFO_ERROR']"
			[Register ("FLOOR_INFO_ERROR")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError FloorInfoError {
				get {
					const string __id = "FLOOR_INFO_ERROR.Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='FLOOR_OVERLFLOW']"
			[Register ("FLOOR_OVERLFLOW")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError FloorOverlflow {
				get {
					const string __id = "FLOOR_OVERLFLOW.Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='FOCUSED_ID_ERROR']"
			[Register ("FOCUSED_ID_ERROR")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError FocusedIdError {
				get {
					const string __id = "FOCUSED_ID_ERROR.Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='SWITCH_ERROR']"
			[Register ("SWITCH_ERROR")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError SwitchError {
				get {
					const string __id = "SWITCH_ERROR.Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/field[@name='SWITCH_OK']"
			[Register ("SWITCH_OK")]
			public static global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError SwitchOk {
				get {
					const string __id = "SWITCH_OK.Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError", typeof (SwitchFloorError));
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

			internal SwitchFloorError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo.SwitchFloorError']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapBaseIndoorMapInfo", typeof (MapBaseIndoorMapInfo));
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

		internal MapBaseIndoorMapInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/constructor[@name='MapBaseIndoorMapInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapBaseIndoorMapInfo ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/constructor[@name='MapBaseIndoorMapInfo' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapBaseIndoorMapInfo']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V", "")]
		public unsafe MapBaseIndoorMapInfo (global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/constructor[@name='MapBaseIndoorMapInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;)V", "")]
		public unsafe MapBaseIndoorMapInfo (string p0, string p1, global::System.Collections.Generic.IList<string> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		public unsafe string CurFloor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/method[@name='getCurFloor' and count(parameter)=0]"
			[Register ("getCurFloor", "()Ljava/lang/String;", "GetGetCurFloorHandler")]
			get {
				const string __id = "getCurFloor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<string> Floors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/method[@name='getFloors' and count(parameter)=0]"
			[Register ("getFloors", "()Ljava/util/ArrayList;", "GetGetFloorsHandler")]
			get {
				const string __id = "getFloors.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapBaseIndoorMapInfo']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()Ljava/lang/String;", "GetGetIDHandler")]
			get {
				const string __id = "getID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
