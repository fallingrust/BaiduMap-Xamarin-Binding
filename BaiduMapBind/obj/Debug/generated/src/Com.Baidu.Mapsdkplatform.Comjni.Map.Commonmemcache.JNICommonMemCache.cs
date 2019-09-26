using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Map.Commonmemcache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/map/commonmemcache/JNICommonMemCache", DoNotGenerateAcw=true)]
	public partial class JNICommonMemCache : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/map/commonmemcache/JNICommonMemCache", typeof (JNICommonMemCache));
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

		protected JNICommonMemCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/constructor[@name='JNICommonMemCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNICommonMemCache ()
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

		static Delegate cb_Create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_Create == null)
				cb_Create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Create);
			return cb_Create;
		}

		static long n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Commonmemcache.JNICommonMemCache __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Commonmemcache.JNICommonMemCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/method[@name='Create' and count(parameter)=0]"
		[Register ("Create", "()J", "GetCreateHandler")]
		public virtual unsafe long Create ()
		{
			const string __id = "Create.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_Init_J;
#pragma warning disable 0169
		static Delegate GetInit_JHandler ()
		{
			if (cb_Init_J == null)
				cb_Init_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Init_J);
			return cb_Init_J;
		}

		static void n_Init_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Commonmemcache.JNICommonMemCache __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Commonmemcache.JNICommonMemCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/method[@name='Init' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Init", "(J)V", "GetInit_JHandler")]
		public virtual unsafe void Init (long p0)
		{
			const string __id = "Init.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
