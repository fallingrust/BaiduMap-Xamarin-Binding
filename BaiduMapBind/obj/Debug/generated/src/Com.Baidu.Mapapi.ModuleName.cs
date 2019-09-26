using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/ModuleName", DoNotGenerateAcw=true)]
	public sealed partial class ModuleName : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']/field[@name='TILE_OVERLAY_MODULE']"
		[Register ("TILE_OVERLAY_MODULE")]
		public static global::Com.Baidu.Mapapi.ModuleName TileOverlayModule {
			get {
				const string __id = "TILE_OVERLAY_MODULE.Lcom/baidu/mapapi/ModuleName;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.ModuleName> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/ModuleName", typeof (ModuleName));
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

		internal ModuleName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/ModuleName;", "")]
		public static unsafe global::Com.Baidu.Mapapi.ModuleName ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/ModuleName;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.ModuleName> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='ModuleName']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/ModuleName;", "")]
		public static unsafe global::Com.Baidu.Mapapi.ModuleName[] Values ()
		{
			const string __id = "values.()[Lcom/baidu/mapapi/ModuleName;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Baidu.Mapapi.ModuleName[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.ModuleName));
			} finally {
			}
		}

	}
}
