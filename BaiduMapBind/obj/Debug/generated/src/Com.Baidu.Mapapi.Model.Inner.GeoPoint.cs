using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Model.Inner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/inner/GeoPoint", DoNotGenerateAcw=true)]
	public partial class GeoPoint : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/model/inner/GeoPoint", typeof (GeoPoint));
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

		protected GeoPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe GeoPoint (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(DD)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getLatitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLatitudeE6Handler ()
		{
			if (cb_getLatitudeE6 == null)
				cb_getLatitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitudeE6);
			return cb_getLatitudeE6;
		}

		static double n_GetLatitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitudeE6_D;
#pragma warning disable 0169
		static Delegate GetSetLatitudeE6_DHandler ()
		{
			if (cb_setLatitudeE6_D == null)
				cb_setLatitudeE6_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitudeE6_D);
			return cb_setLatitudeE6_D;
		}

		static void n_SetLatitudeE6_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LatitudeE6 = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double LatitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='getLatitudeE6' and count(parameter)=0]"
			[Register ("getLatitudeE6", "()D", "GetGetLatitudeE6Handler")]
			get {
				const string __id = "getLatitudeE6.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='setLatitudeE6' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitudeE6", "(D)V", "GetSetLatitudeE6_DHandler")]
			set {
				const string __id = "setLatitudeE6.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLongitudeE6Handler ()
		{
			if (cb_getLongitudeE6 == null)
				cb_getLongitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitudeE6);
			return cb_getLongitudeE6;
		}

		static double n_GetLongitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitudeE6_D;
#pragma warning disable 0169
		static Delegate GetSetLongitudeE6_DHandler ()
		{
			if (cb_setLongitudeE6_D == null)
				cb_setLongitudeE6_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitudeE6_D);
			return cb_setLongitudeE6_D;
		}

		static void n_SetLongitudeE6_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LongitudeE6 = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double LongitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='getLongitudeE6' and count(parameter)=0]"
			[Register ("getLongitudeE6", "()D", "GetGetLongitudeE6Handler")]
			get {
				const string __id = "getLongitudeE6.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='GeoPoint']/method[@name='setLongitudeE6' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitudeE6", "(D)V", "GetSetLongitudeE6_DHandler")]
			set {
				const string __id = "setLongitudeE6.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
