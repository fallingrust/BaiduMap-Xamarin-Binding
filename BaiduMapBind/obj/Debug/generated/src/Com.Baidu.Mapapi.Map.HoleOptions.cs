using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HoleOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/HoleOptions", DoNotGenerateAcw=true)]
	public partial class HoleOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HoleOptions']/field[@name='mHoleType']"
		[Register ("mHoleType")]
		protected string MHoleType {
			get {
				const string __id = "mHoleType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHoleType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/HoleOptions", typeof (HoleOptions));
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

		protected HoleOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HoleOptions']/constructor[@name='HoleOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HoleOptions ()
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

		static Delegate cb_getHoleType;
#pragma warning disable 0169
		static Delegate GetGetHoleTypeHandler ()
		{
			if (cb_getHoleType == null)
				cb_getHoleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHoleType);
			return cb_getHoleType;
		}

		static IntPtr n_GetHoleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.HoleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HoleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HoleType);
		}
#pragma warning restore 0169

		public virtual unsafe string HoleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HoleOptions']/method[@name='getHoleType' and count(parameter)=0]"
			[Register ("getHoleType", "()Ljava/lang/String;", "GetGetHoleTypeHandler")]
			get {
				const string __id = "getHoleType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
