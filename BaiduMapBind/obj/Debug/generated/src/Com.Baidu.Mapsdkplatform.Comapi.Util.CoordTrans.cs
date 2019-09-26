using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comapi.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='CoordTrans']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comapi/util/CoordTrans", DoNotGenerateAcw=true)]
	public partial class CoordTrans : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comapi/util/CoordTrans", typeof (CoordTrans));
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

		protected CoordTrans (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='CoordTrans']/constructor[@name='CoordTrans' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordTrans ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='CoordTrans']/method[@name='baiduToGcj' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("baiduToGcj", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng BaiduToGcj (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "baiduToGcj.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='CoordTrans']/method[@name='gcjToBaidu' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("gcjToBaidu", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng GcjToBaidu (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "gcjToBaidu.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='CoordTrans']/method[@name='wgsToBaidu' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("wgsToBaidu", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng WgsToBaidu (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "wgsToBaidu.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
