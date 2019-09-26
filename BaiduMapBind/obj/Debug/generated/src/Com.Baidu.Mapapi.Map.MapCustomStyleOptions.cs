using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapCustomStyleOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapCustomStyleOptions", DoNotGenerateAcw=true)]
	public partial class MapCustomStyleOptions : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapCustomStyleOptions", typeof (MapCustomStyleOptions));
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

		protected MapCustomStyleOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapCustomStyleOptions']/constructor[@name='MapCustomStyleOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapCustomStyleOptions ()
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

		static Delegate cb_getCustomMapStyleId;
#pragma warning disable 0169
		static Delegate GetGetCustomMapStyleIdHandler ()
		{
			if (cb_getCustomMapStyleId == null)
				cb_getCustomMapStyleId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomMapStyleId);
			return cb_getCustomMapStyleId;
		}

		static IntPtr n_GetCustomMapStyleId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomMapStyleId);
		}
#pragma warning restore 0169

		public virtual unsafe string CustomMapStyleId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapCustomStyleOptions']/method[@name='getCustomMapStyleId' and count(parameter)=0]"
			[Register ("getCustomMapStyleId", "()Ljava/lang/String;", "GetGetCustomMapStyleIdHandler")]
			get {
				const string __id = "getCustomMapStyleId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalCustomStyleFilePath;
#pragma warning disable 0169
		static Delegate GetGetLocalCustomStyleFilePathHandler ()
		{
			if (cb_getLocalCustomStyleFilePath == null)
				cb_getLocalCustomStyleFilePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalCustomStyleFilePath);
			return cb_getLocalCustomStyleFilePath;
		}

		static IntPtr n_GetLocalCustomStyleFilePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalCustomStyleFilePath);
		}
#pragma warning restore 0169

		public virtual unsafe string LocalCustomStyleFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapCustomStyleOptions']/method[@name='getLocalCustomStyleFilePath' and count(parameter)=0]"
			[Register ("getLocalCustomStyleFilePath", "()Ljava/lang/String;", "GetGetLocalCustomStyleFilePathHandler")]
			get {
				const string __id = "getLocalCustomStyleFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_customStyleId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCustomStyleId_Ljava_lang_String_Handler ()
		{
			if (cb_customStyleId_Ljava_lang_String_ == null)
				cb_customStyleId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CustomStyleId_Ljava_lang_String_);
			return cb_customStyleId_Ljava_lang_String_;
		}

		static IntPtr n_CustomStyleId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CustomStyleId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapCustomStyleOptions']/method[@name='customStyleId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("customStyleId", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapCustomStyleOptions;", "GetCustomStyleId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions CustomStyleId (string p0)
		{
			const string __id = "customStyleId.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapCustomStyleOptions;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_localCustomStylePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLocalCustomStylePath_Ljava_lang_String_Handler ()
		{
			if (cb_localCustomStylePath_Ljava_lang_String_ == null)
				cb_localCustomStylePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LocalCustomStylePath_Ljava_lang_String_);
			return cb_localCustomStylePath_Ljava_lang_String_;
		}

		static IntPtr n_LocalCustomStylePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LocalCustomStylePath (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapCustomStyleOptions']/method[@name='localCustomStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("localCustomStylePath", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapCustomStyleOptions;", "GetLocalCustomStylePath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions LocalCustomStylePath (string p0)
		{
			const string __id = "localCustomStylePath.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapCustomStyleOptions;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
