using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi']/class[@name='NativeLoader']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comapi/NativeLoader", DoNotGenerateAcw=true)]
	public partial class NativeLoader : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comapi/NativeLoader", typeof (NativeLoader));
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

		protected NativeLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Baidu.Mapsdkplatform.Comapi.NativeLoader Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi']/class[@name='NativeLoader']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapsdkplatform/comapi/NativeLoader;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/baidu/mapsdkplatform/comapi/NativeLoader;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.NativeLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_loadLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_loadLibrary_Ljava_lang_String_ == null)
				cb_loadLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LoadLibrary_Ljava_lang_String_);
			return cb_loadLibrary_Ljava_lang_String_;
		}

		static bool n_LoadLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comapi.NativeLoader __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.NativeLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoadLibrary (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi']/class[@name='NativeLoader']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)Z", "GetLoadLibrary_Ljava_lang_String_Handler")]
		public virtual unsafe bool LoadLibrary (string p0)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi']/class[@name='NativeLoader']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetContext (global::Android.Content.Context p0)
		{
			const string __id = "setContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
