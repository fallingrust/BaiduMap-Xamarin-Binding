using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/map/basemap/JNIBaseMap", DoNotGenerateAcw=true)]
	public partial class JNIBaseMap : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/field[@name='a']"
		[Register ("a")]
		public long A {
			get {
				const string __id = "a.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "a.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/map/basemap/JNIBaseMap", typeof (JNIBaseMap));
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

		protected JNIBaseMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/constructor[@name='JNIBaseMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNIBaseMap ()
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

		static Delegate cb_AddLayer_JIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLayer_JIILjava_lang_String_Handler ()
		{
			if (cb_AddLayer_JIILjava_lang_String_ == null)
				cb_AddLayer_JIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr, long>) n_AddLayer_JIILjava_lang_String_);
			return cb_AddLayer_JIILjava_lang_String_;
		}

		static long n_AddLayer_JIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.AddLayer (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='AddLayer' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("AddLayer", "(JIILjava/lang/String;)J", "GetAddLayer_JIILjava_lang_String_Handler")]
		public virtual unsafe long AddLayer (long p0, int p1, int p2, string p3)
		{
			const string __id = "AddLayer.(JIILjava/lang/String;)J";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_CleanCache_JI;
#pragma warning disable 0169
		static Delegate GetCleanCache_JIHandler ()
		{
			if (cb_CleanCache_JI == null)
				cb_CleanCache_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool>) n_CleanCache_JI);
			return cb_CleanCache_JI;
		}

		static bool n_CleanCache_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CleanCache (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='CleanCache' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("CleanCache", "(JI)Z", "GetCleanCache_JIHandler")]
		public virtual unsafe bool CleanCache (long p0, int p1)
		{
			const string __id = "CleanCache.(JI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ClearLayer_JJ;
#pragma warning disable 0169
		static Delegate GetClearLayer_JJHandler ()
		{
			if (cb_ClearLayer_JJ == null)
				cb_ClearLayer_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_ClearLayer_JJ);
			return cb_ClearLayer_JJ;
		}

		static void n_ClearLayer_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearLayer (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ClearLayer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("ClearLayer", "(JJ)V", "GetClearLayer_JJHandler")]
		public virtual unsafe void ClearLayer (long p0, long p1)
		{
			const string __id = "ClearLayer.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='Create' and count(parameter)=0]"
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

		static Delegate cb_CreateDuplicate_J;
#pragma warning disable 0169
		static Delegate GetCreateDuplicate_JHandler ()
		{
			if (cb_CreateDuplicate_J == null)
				cb_CreateDuplicate_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_CreateDuplicate_J);
			return cb_CreateDuplicate_J;
		}

		static long n_CreateDuplicate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateDuplicate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='CreateDuplicate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("CreateDuplicate", "(J)J", "GetCreateDuplicate_JHandler")]
		public virtual unsafe long CreateDuplicate (long p0)
		{
			const string __id = "CreateDuplicate.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_GeoPtToScrPoint_JII;
#pragma warning disable 0169
		static Delegate GetGeoPtToScrPoint_JIIHandler ()
		{
			if (cb_GeoPtToScrPoint_JII == null)
				cb_GeoPtToScrPoint_JII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr>) n_GeoPtToScrPoint_JII);
			return cb_GeoPtToScrPoint_JII;
		}

		static IntPtr n_GeoPtToScrPoint_JII (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GeoPtToScrPoint (p0, p1, p2));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GeoPtToScrPoint' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("GeoPtToScrPoint", "(JII)Ljava/lang/String;", "GetGeoPtToScrPoint_JIIHandler")]
		public virtual unsafe string GeoPtToScrPoint (long p0, int p1, int p2)
		{
			const string __id = "GeoPtToScrPoint.(JII)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_GetBaiduHotMapCityInfo_J;
#pragma warning disable 0169
		static Delegate GetGetBaiduHotMapCityInfo_JHandler ()
		{
			if (cb_GetBaiduHotMapCityInfo_J == null)
				cb_GetBaiduHotMapCityInfo_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GetBaiduHotMapCityInfo_J);
			return cb_GetBaiduHotMapCityInfo_J;
		}

		static bool n_GetBaiduHotMapCityInfo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetBaiduHotMapCityInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetBaiduHotMapCityInfo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("GetBaiduHotMapCityInfo", "(J)Z", "GetGetBaiduHotMapCityInfo_JHandler")]
		public virtual unsafe bool GetBaiduHotMapCityInfo (long p0)
		{
			const string __id = "GetBaiduHotMapCityInfo.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_GetMapStatus_J;
#pragma warning disable 0169
		static Delegate GetGetMapStatus_JHandler ()
		{
			if (cb_GetMapStatus_J == null)
				cb_GetMapStatus_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetMapStatus_J);
			return cb_GetMapStatus_J;
		}

		static IntPtr n_GetMapStatus_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMapStatus (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetMapStatus' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("GetMapStatus", "(J)Landroid/os/Bundle;", "GetGetMapStatus_JHandler")]
		public virtual unsafe global::Android.OS.Bundle GetMapStatus (long p0)
		{
			const string __id = "GetMapStatus.(J)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_GetNearlyObjID_JJIII;
#pragma warning disable 0169
		static Delegate GetGetNearlyObjID_JJIIIHandler ()
		{
			if (cb_GetNearlyObjID_JJIII == null)
				cb_GetNearlyObjID_JJIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, int, int, int, IntPtr>) n_GetNearlyObjID_JJIII);
			return cb_GetNearlyObjID_JJIII;
		}

		static IntPtr n_GetNearlyObjID_JJIII (IntPtr jnienv, IntPtr native__this, long p0, long p1, int p2, int p3, int p4)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetNearlyObjID (p0, p1, p2, p3, p4));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetNearlyObjID' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("GetNearlyObjID", "(JJIII)Ljava/lang/String;", "GetGetNearlyObjID_JJIIIHandler")]
		public virtual unsafe string GetNearlyObjID (long p0, long p1, int p2, int p3, int p4)
		{
			const string __id = "GetNearlyObjID.(JJIII)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_GetScreenBuf_JarrayIII;
#pragma warning disable 0169
		static Delegate GetGetScreenBuf_JarrayIIIHandler ()
		{
			if (cb_GetScreenBuf_JarrayIII == null)
				cb_GetScreenBuf_JarrayIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, int, IntPtr>) n_GetScreenBuf_JarrayIII);
			return cb_GetScreenBuf_JarrayIII;
		}

		static IntPtr n_GetScreenBuf_JarrayIII (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.GetScreenBuf (p0, p1, p2, p3));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetScreenBuf' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("GetScreenBuf", "(J[III)[I", "GetGetScreenBuf_JarrayIIIHandler")]
		public virtual unsafe int[] GetScreenBuf (long p0, int[] p1, int p2, int p3)
		{
			const string __id = "GetScreenBuf.(J[III)[I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_GetZoomToBound_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetZoomToBound_JLandroid_os_Bundle_Handler ()
		{
			if (cb_GetZoomToBound_JLandroid_os_Bundle_ == null)
				cb_GetZoomToBound_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, float>) n_GetZoomToBound_JLandroid_os_Bundle_);
			return cb_GetZoomToBound_JLandroid_os_Bundle_;
		}

		static float n_GetZoomToBound_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetZoomToBound (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='GetZoomToBound' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("GetZoomToBound", "(JLandroid/os/Bundle;)F", "GetGetZoomToBound_JLandroid_os_Bundle_Handler")]
		public virtual unsafe float GetZoomToBound (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "GetZoomToBound.(JLandroid/os/Bundle;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_IsBaseIndoorMapMode_J;
#pragma warning disable 0169
		static Delegate GetIsBaseIndoorMapMode_JHandler ()
		{
			if (cb_IsBaseIndoorMapMode_J == null)
				cb_IsBaseIndoorMapMode_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_IsBaseIndoorMapMode_J);
			return cb_IsBaseIndoorMapMode_J;
		}

		static bool n_IsBaseIndoorMapMode_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBaseIndoorMapMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='IsBaseIndoorMapMode' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("IsBaseIndoorMapMode", "(J)Z", "GetIsBaseIndoorMapMode_JHandler")]
		public virtual unsafe bool IsBaseIndoorMapMode (long p0)
		{
			const string __id = "IsBaseIndoorMapMode.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_LayersIsShow_JJ;
#pragma warning disable 0169
		static Delegate GetLayersIsShow_JJHandler ()
		{
			if (cb_LayersIsShow_JJ == null)
				cb_LayersIsShow_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, bool>) n_LayersIsShow_JJ);
			return cb_LayersIsShow_JJ;
		}

		static bool n_LayersIsShow_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayersIsShow (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='LayersIsShow' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("LayersIsShow", "(JJ)Z", "GetLayersIsShow_JJHandler")]
		public virtual unsafe bool LayersIsShow (long p0, long p1)
		{
			const string __id = "LayersIsShow.(JJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='MapProc' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("MapProc", "(JIII)I", "")]
		public static unsafe int MapProc (long p0, int p1, int p2, int p3)
		{
			const string __id = "MapProc.(JIII)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_OnBackground_J;
#pragma warning disable 0169
		static Delegate GetOnBackground_JHandler ()
		{
			if (cb_OnBackground_J == null)
				cb_OnBackground_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnBackground_J);
			return cb_OnBackground_J;
		}

		static void n_OnBackground_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackground (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnBackground' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnBackground", "(J)V", "GetOnBackground_JHandler")]
		public virtual unsafe void OnBackground (long p0)
		{
			const string __id = "OnBackground.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_OnForeground_J;
#pragma warning disable 0169
		static Delegate GetOnForeground_JHandler ()
		{
			if (cb_OnForeground_J == null)
				cb_OnForeground_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnForeground_J);
			return cb_OnForeground_J;
		}

		static void n_OnForeground_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnForeground (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnForeground' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnForeground", "(J)V", "GetOnForeground_JHandler")]
		public virtual unsafe void OnForeground (long p0)
		{
			const string __id = "OnForeground.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_OnHotcityGet_J;
#pragma warning disable 0169
		static Delegate GetOnHotcityGet_JHandler ()
		{
			if (cb_OnHotcityGet_J == null)
				cb_OnHotcityGet_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_OnHotcityGet_J);
			return cb_OnHotcityGet_J;
		}

		static IntPtr n_OnHotcityGet_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OnHotcityGet (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnHotcityGet' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnHotcityGet", "(J)Ljava/lang/String;", "GetOnHotcityGet_JHandler")]
		public virtual unsafe string OnHotcityGet (long p0)
		{
			const string __id = "OnHotcityGet.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_OnPause_J;
#pragma warning disable 0169
		static Delegate GetOnPause_JHandler ()
		{
			if (cb_OnPause_J == null)
				cb_OnPause_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnPause_J);
			return cb_OnPause_J;
		}

		static void n_OnPause_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnPause' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnPause", "(J)V", "GetOnPause_JHandler")]
		public virtual unsafe void OnPause (long p0)
		{
			const string __id = "OnPause.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_OnRecordAdd_JI;
#pragma warning disable 0169
		static Delegate GetOnRecordAdd_JIHandler ()
		{
			if (cb_OnRecordAdd_JI == null)
				cb_OnRecordAdd_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool>) n_OnRecordAdd_JI);
			return cb_OnRecordAdd_JI;
		}

		static bool n_OnRecordAdd_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordAdd (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordAdd' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("OnRecordAdd", "(JI)Z", "GetOnRecordAdd_JIHandler")]
		public virtual unsafe bool OnRecordAdd (long p0, int p1)
		{
			const string __id = "OnRecordAdd.(JI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_OnRecordGetAll_J;
#pragma warning disable 0169
		static Delegate GetOnRecordGetAll_JHandler ()
		{
			if (cb_OnRecordGetAll_J == null)
				cb_OnRecordGetAll_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_OnRecordGetAll_J);
			return cb_OnRecordGetAll_J;
		}

		static IntPtr n_OnRecordGetAll_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OnRecordGetAll (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordGetAll' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnRecordGetAll", "(J)Ljava/lang/String;", "GetOnRecordGetAll_JHandler")]
		public virtual unsafe string OnRecordGetAll (long p0)
		{
			const string __id = "OnRecordGetAll.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_OnRecordGetAt_JI;
#pragma warning disable 0169
		static Delegate GetOnRecordGetAt_JIHandler ()
		{
			if (cb_OnRecordGetAt_JI == null)
				cb_OnRecordGetAt_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr>) n_OnRecordGetAt_JI);
			return cb_OnRecordGetAt_JI;
		}

		static IntPtr n_OnRecordGetAt_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OnRecordGetAt (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordGetAt' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("OnRecordGetAt", "(JI)Ljava/lang/String;", "GetOnRecordGetAt_JIHandler")]
		public virtual unsafe string OnRecordGetAt (long p0, int p1)
		{
			const string __id = "OnRecordGetAt.(JI)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_OnRecordImport_JZZ;
#pragma warning disable 0169
		static Delegate GetOnRecordImport_JZZHandler ()
		{
			if (cb_OnRecordImport_JZZ == null)
				cb_OnRecordImport_JZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool, bool, bool>) n_OnRecordImport_JZZ);
			return cb_OnRecordImport_JZZ;
		}

		static bool n_OnRecordImport_JZZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1, bool p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordImport (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordImport' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("OnRecordImport", "(JZZ)Z", "GetOnRecordImport_JZZHandler")]
		public virtual unsafe bool OnRecordImport (long p0, bool p1, bool p2)
		{
			const string __id = "OnRecordImport.(JZZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_OnRecordReload_JIZ;
#pragma warning disable 0169
		static Delegate GetOnRecordReload_JIZHandler ()
		{
			if (cb_OnRecordReload_JIZ == null)
				cb_OnRecordReload_JIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, bool>) n_OnRecordReload_JIZ);
			return cb_OnRecordReload_JIZ;
		}

		static bool n_OnRecordReload_JIZ (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordReload (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordReload' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("OnRecordReload", "(JIZ)Z", "GetOnRecordReload_JIZHandler")]
		public virtual unsafe bool OnRecordReload (long p0, int p1, bool p2)
		{
			const string __id = "OnRecordReload.(JIZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_OnRecordRemove_JIZ;
#pragma warning disable 0169
		static Delegate GetOnRecordRemove_JIZHandler ()
		{
			if (cb_OnRecordRemove_JIZ == null)
				cb_OnRecordRemove_JIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, bool>) n_OnRecordRemove_JIZ);
			return cb_OnRecordRemove_JIZ;
		}

		static bool n_OnRecordRemove_JIZ (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordRemove (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordRemove' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("OnRecordRemove", "(JIZ)Z", "GetOnRecordRemove_JIZHandler")]
		public virtual unsafe bool OnRecordRemove (long p0, int p1, bool p2)
		{
			const string __id = "OnRecordRemove.(JIZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_OnRecordStart_JIZI;
#pragma warning disable 0169
		static Delegate GetOnRecordStart_JIZIHandler ()
		{
			if (cb_OnRecordStart_JIZI == null)
				cb_OnRecordStart_JIZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, int, bool>) n_OnRecordStart_JIZI);
			return cb_OnRecordStart_JIZI;
		}

		static bool n_OnRecordStart_JIZI (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2, int p3)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordStart (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordStart' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("OnRecordStart", "(JIZI)Z", "GetOnRecordStart_JIZIHandler")]
		public virtual unsafe bool OnRecordStart (long p0, int p1, bool p2, int p3)
		{
			const string __id = "OnRecordStart.(JIZI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_OnRecordSuspend_JIZI;
#pragma warning disable 0169
		static Delegate GetOnRecordSuspend_JIZIHandler ()
		{
			if (cb_OnRecordSuspend_JIZI == null)
				cb_OnRecordSuspend_JIZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool, int, bool>) n_OnRecordSuspend_JIZI);
			return cb_OnRecordSuspend_JIZI;
		}

		static bool n_OnRecordSuspend_JIZI (IntPtr jnienv, IntPtr native__this, long p0, int p1, bool p2, int p3)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnRecordSuspend (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnRecordSuspend' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("OnRecordSuspend", "(JIZI)Z", "GetOnRecordSuspend_JIZIHandler")]
		public virtual unsafe bool OnRecordSuspend (long p0, int p1, bool p2, int p3)
		{
			const string __id = "OnRecordSuspend.(JIZI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_OnResume_J;
#pragma warning disable 0169
		static Delegate GetOnResume_JHandler ()
		{
			if (cb_OnResume_J == null)
				cb_OnResume_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnResume_J);
			return cb_OnResume_J;
		}

		static void n_OnResume_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnResume' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("OnResume", "(J)V", "GetOnResume_JHandler")]
		public virtual unsafe void OnResume (long p0)
		{
			const string __id = "OnResume.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_OnSchcityGet_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSchcityGet_JLjava_lang_String_Handler ()
		{
			if (cb_OnSchcityGet_JLjava_lang_String_ == null)
				cb_OnSchcityGet_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnSchcityGet_JLjava_lang_String_);
			return cb_OnSchcityGet_JLjava_lang_String_;
		}

		static IntPtr n_OnSchcityGet_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnSchcityGet (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='OnSchcityGet' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("OnSchcityGet", "(JLjava/lang/String;)Ljava/lang/String;", "GetOnSchcityGet_JLjava_lang_String_Handler")]
		public virtual unsafe string OnSchcityGet (long p0, string p1)
		{
			const string __id = "OnSchcityGet.(JLjava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_PostStatInfo_J;
#pragma warning disable 0169
		static Delegate GetPostStatInfo_JHandler ()
		{
			if (cb_PostStatInfo_J == null)
				cb_PostStatInfo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_PostStatInfo_J);
			return cb_PostStatInfo_J;
		}

		static void n_PostStatInfo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostStatInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='PostStatInfo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("PostStatInfo", "(J)V", "GetPostStatInfo_JHandler")]
		public virtual unsafe void PostStatInfo (long p0)
		{
			const string __id = "PostStatInfo.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_Release_J;
#pragma warning disable 0169
		static Delegate GetRelease_JHandler ()
		{
			if (cb_Release_J == null)
				cb_Release_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_Release_J);
			return cb_Release_J;
		}

		static int n_Release_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='Release' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Release", "(J)I", "GetRelease_JHandler")]
		public virtual unsafe int Release (long p0)
		{
			const string __id = "Release.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ResetImageRes_J;
#pragma warning disable 0169
		static Delegate GetResetImageRes_JHandler ()
		{
			if (cb_ResetImageRes_J == null)
				cb_ResetImageRes_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_ResetImageRes_J);
			return cb_ResetImageRes_J;
		}

		static void n_ResetImageRes_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetImageRes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ResetImageRes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ResetImageRes", "(J)V", "GetResetImageRes_JHandler")]
		public virtual unsafe void ResetImageRes (long p0)
		{
			const string __id = "ResetImageRes.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ == null)
				cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_);
			return cb_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SaveScreenToLocal (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SaveScreenToLocal' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("SaveScreenToLocal", "(JLjava/lang/String;Landroid/os/Bundle;)V", "GetSaveScreenToLocal_JLjava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual unsafe void SaveScreenToLocal (long p0, string p1, global::Android.OS.Bundle p2)
		{
			const string __id = "SaveScreenToLocal.(JLjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ScrPtToGeoPoint_JII;
#pragma warning disable 0169
		static Delegate GetScrPtToGeoPoint_JIIHandler ()
		{
			if (cb_ScrPtToGeoPoint_JII == null)
				cb_ScrPtToGeoPoint_JII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr>) n_ScrPtToGeoPoint_JII);
			return cb_ScrPtToGeoPoint_JII;
		}

		static IntPtr n_ScrPtToGeoPoint_JII (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScrPtToGeoPoint (p0, p1, p2));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ScrPtToGeoPoint' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ScrPtToGeoPoint", "(JII)Ljava/lang/String;", "GetScrPtToGeoPoint_JIIHandler")]
		public virtual unsafe string ScrPtToGeoPoint (long p0, int p1, int p2)
		{
			const string __id = "ScrPtToGeoPoint.(JII)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_SetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_Handler ()
		{
			if (cb_SetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_ == null)
				cb_SetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int>) n_SetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_);
			return cb_SetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_;
		}

		static int n_SetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.BaseMapCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.BaseMapCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetCallback (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetCallback' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.baidu.mapsdkplatform.comjni.map.basemap.BaseMapCallback']]"
		[Register ("SetCallback", "(JLcom/baidu/mapsdkplatform/comjni/map/basemap/BaseMapCallback;)I", "GetSetCallback_JLcom_baidu_mapsdkplatform_comjni_map_basemap_BaseMapCallback_Handler")]
		public virtual unsafe int SetCallback (long p0, global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.BaseMapCallback p1)
		{
			const string __id = "SetCallback.(JLcom/baidu/mapsdkplatform/comjni/map/basemap/BaseMapCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_SetLayersClickable_JJZ;
#pragma warning disable 0169
		static Delegate GetSetLayersClickable_JJZHandler ()
		{
			if (cb_SetLayersClickable_JJZ == null)
				cb_SetLayersClickable_JJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, bool>) n_SetLayersClickable_JJZ);
			return cb_SetLayersClickable_JJZ;
		}

		static void n_SetLayersClickable_JJZ (IntPtr jnienv, IntPtr native__this, long p0, long p1, bool p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLayersClickable (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetLayersClickable' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("SetLayersClickable", "(JJZ)V", "GetSetLayersClickable_JJZHandler")]
		public virtual unsafe void SetLayersClickable (long p0, long p1, bool p2)
		{
			const string __id = "SetLayersClickable.(JJZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_SetMapControlMode_JI;
#pragma warning disable 0169
		static Delegate GetSetMapControlMode_JIHandler ()
		{
			if (cb_SetMapControlMode_JI == null)
				cb_SetMapControlMode_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int>) n_SetMapControlMode_JI);
			return cb_SetMapControlMode_JI;
		}

		static int n_SetMapControlMode_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMapControlMode (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetMapControlMode' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("SetMapControlMode", "(JI)I", "GetSetMapControlMode_JIHandler")]
		public virtual unsafe int SetMapControlMode (long p0, int p1)
		{
			const string __id = "SetMapControlMode.(JI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetMapCustomEnable' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("SetMapCustomEnable", "(JZ)V", "")]
		public static unsafe void SetMapCustomEnable (long p0, bool p1)
		{
			const string __id = "SetMapCustomEnable.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_SetMapStatus_JLandroid_os_Bundle_Z;
#pragma warning disable 0169
		static Delegate GetSetMapStatus_JLandroid_os_Bundle_ZHandler ()
		{
			if (cb_SetMapStatus_JLandroid_os_Bundle_Z == null)
				cb_SetMapStatus_JLandroid_os_Bundle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, bool>) n_SetMapStatus_JLandroid_os_Bundle_Z);
			return cb_SetMapStatus_JLandroid_os_Bundle_Z;
		}

		static void n_SetMapStatus_JLandroid_os_Bundle_Z (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, bool p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMapStatus (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SetMapStatus' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='boolean']]"
		[Register ("SetMapStatus", "(JLandroid/os/Bundle;Z)V", "GetSetMapStatus_JLandroid_os_Bundle_ZHandler")]
		public virtual unsafe void SetMapStatus (long p0, global::Android.OS.Bundle p1, bool p2)
		{
			const string __id = "SetMapStatus.(JLandroid/os/Bundle;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ShowBaseIndoorMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowBaseIndoorMap_JZHandler ()
		{
			if (cb_ShowBaseIndoorMap_JZ == null)
				cb_ShowBaseIndoorMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowBaseIndoorMap_JZ);
			return cb_ShowBaseIndoorMap_JZ;
		}

		static void n_ShowBaseIndoorMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowBaseIndoorMap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowBaseIndoorMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowBaseIndoorMap", "(JZ)V", "GetShowBaseIndoorMap_JZHandler")]
		public virtual unsafe void ShowBaseIndoorMap (long p0, bool p1)
		{
			const string __id = "ShowBaseIndoorMap.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ShowHotMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowHotMap_JZHandler ()
		{
			if (cb_ShowHotMap_JZ == null)
				cb_ShowHotMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowHotMap_JZ);
			return cb_ShowHotMap_JZ;
		}

		static void n_ShowHotMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowHotMap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowHotMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowHotMap", "(JZ)V", "GetShowHotMap_JZHandler")]
		public virtual unsafe void ShowHotMap (long p0, bool p1)
		{
			const string __id = "ShowHotMap.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ShowLayers_JJZ;
#pragma warning disable 0169
		static Delegate GetShowLayers_JJZHandler ()
		{
			if (cb_ShowLayers_JJZ == null)
				cb_ShowLayers_JJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, bool>) n_ShowLayers_JJZ);
			return cb_ShowLayers_JJZ;
		}

		static void n_ShowLayers_JJZ (IntPtr jnienv, IntPtr native__this, long p0, long p1, bool p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowLayers (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowLayers' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("ShowLayers", "(JJZ)V", "GetShowLayers_JJZHandler")]
		public virtual unsafe void ShowLayers (long p0, long p1, bool p2)
		{
			const string __id = "ShowLayers.(JJZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ShowSatelliteMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowSatelliteMap_JZHandler ()
		{
			if (cb_ShowSatelliteMap_JZ == null)
				cb_ShowSatelliteMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowSatelliteMap_JZ);
			return cb_ShowSatelliteMap_JZ;
		}

		static void n_ShowSatelliteMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSatelliteMap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowSatelliteMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowSatelliteMap", "(JZ)V", "GetShowSatelliteMap_JZHandler")]
		public virtual unsafe void ShowSatelliteMap (long p0, bool p1)
		{
			const string __id = "ShowSatelliteMap.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ShowTrafficMap_JZ;
#pragma warning disable 0169
		static Delegate GetShowTrafficMap_JZHandler ()
		{
			if (cb_ShowTrafficMap_JZ == null)
				cb_ShowTrafficMap_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_ShowTrafficMap_JZ);
			return cb_ShowTrafficMap_JZ;
		}

		static void n_ShowTrafficMap_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTrafficMap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='ShowTrafficMap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("ShowTrafficMap", "(JZ)V", "GetShowTrafficMap_JZHandler")]
		public virtual unsafe void ShowTrafficMap (long p0, bool p1)
		{
			const string __id = "ShowTrafficMap.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_);
			return cb_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_SwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SwitchBaseIndoorMapFloor (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SwitchBaseIndoorMapFloor' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwitchBaseIndoorMapFloor", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetSwitchBaseIndoorMapFloor_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SwitchBaseIndoorMapFloor (long p0, string p1, string p2)
		{
			const string __id = "SwitchBaseIndoorMapFloor.(JLjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_SwitchLayer_JJJ;
#pragma warning disable 0169
		static Delegate GetSwitchLayer_JJJHandler ()
		{
			if (cb_SwitchLayer_JJJ == null)
				cb_SwitchLayer_JJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, long, bool>) n_SwitchLayer_JJJ);
			return cb_SwitchLayer_JJJ;
		}

		static bool n_SwitchLayer_JJJ (IntPtr jnienv, IntPtr native__this, long p0, long p1, long p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwitchLayer (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='SwitchLayer' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("SwitchLayer", "(JJJ)Z", "GetSwitchLayer_JJJHandler")]
		public virtual unsafe bool SwitchLayer (long p0, long p1, long p2)
		{
			const string __id = "SwitchLayer.(JJJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_UpdateLayers_JJ;
#pragma warning disable 0169
		static Delegate GetUpdateLayers_JJHandler ()
		{
			if (cb_UpdateLayers_JJ == null)
				cb_UpdateLayers_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_UpdateLayers_JJ);
			return cb_UpdateLayers_JJ;
		}

		static void n_UpdateLayers_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLayers (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='UpdateLayers' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("UpdateLayers", "(JJ)V", "GetUpdateLayers_JJHandler")]
		public virtual unsafe void UpdateLayers (long p0, long p1)
		{
			const string __id = "UpdateLayers.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOneOverlayItem_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAddOneOverlayItem_JLandroid_os_Bundle_Handler ()
		{
			if (cb_addOneOverlayItem_JLandroid_os_Bundle_ == null)
				cb_addOneOverlayItem_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_AddOneOverlayItem_JLandroid_os_Bundle_);
			return cb_addOneOverlayItem_JLandroid_os_Bundle_;
		}

		static void n_AddOneOverlayItem_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddOneOverlayItem (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='addOneOverlayItem' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("addOneOverlayItem", "(JLandroid/os/Bundle;)V", "GetAddOneOverlayItem_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void AddOneOverlayItem (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "addOneOverlayItem.(JLandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOverlayItems_JarrayLandroid_os_Bundle_I;
#pragma warning disable 0169
		static Delegate GetAddOverlayItems_JarrayLandroid_os_Bundle_IHandler ()
		{
			if (cb_addOverlayItems_JarrayLandroid_os_Bundle_I == null)
				cb_addOverlayItems_JarrayLandroid_os_Bundle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_AddOverlayItems_JarrayLandroid_os_Bundle_I);
			return cb_addOverlayItems_JarrayLandroid_os_Bundle_I;
		}

		static void n_AddOverlayItems_JarrayLandroid_os_Bundle_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle[] p1 = (global::Android.OS.Bundle[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Android.OS.Bundle));
			__this.AddOverlayItems (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='addOverlayItems' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle[]'] and parameter[3][@type='int']]"
		[Register ("addOverlayItems", "(J[Landroid/os/Bundle;I)V", "GetAddOverlayItems_JarrayLandroid_os_Bundle_IHandler")]
		public virtual unsafe void AddOverlayItems (long p0, global::Android.OS.Bundle[] p1, int p2)
		{
			const string __id = "addOverlayItems.(J[Landroid/os/Bundle;I)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_addtileOverlay_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAddtileOverlay_JLandroid_os_Bundle_Handler ()
		{
			if (cb_addtileOverlay_JLandroid_os_Bundle_ == null)
				cb_addtileOverlay_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_AddtileOverlay_JLandroid_os_Bundle_);
			return cb_addtileOverlay_JLandroid_os_Bundle_;
		}

		static bool n_AddtileOverlay_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddtileOverlay (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='addtileOverlay' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("addtileOverlay", "(JLandroid/os/Bundle;)Z", "GetAddtileOverlay_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool AddtileOverlay (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "addtileOverlay.(JLandroid/os/Bundle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_cleanSDKTileDataCache_JJ;
#pragma warning disable 0169
		static Delegate GetCleanSDKTileDataCache_JJHandler ()
		{
			if (cb_cleanSDKTileDataCache_JJ == null)
				cb_cleanSDKTileDataCache_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, bool>) n_CleanSDKTileDataCache_JJ);
			return cb_cleanSDKTileDataCache_JJ;
		}

		static bool n_CleanSDKTileDataCache_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CleanSDKTileDataCache (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='cleanSDKTileDataCache' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("cleanSDKTileDataCache", "(JJ)Z", "GetCleanSDKTileDataCache_JJHandler")]
		public virtual unsafe bool CleanSDKTileDataCache (long p0, long p1)
		{
			const string __id = "cleanSDKTileDataCache.(JJ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clearHeatMapLayerCache_J;
#pragma warning disable 0169
		static Delegate GetClearHeatMapLayerCache_JHandler ()
		{
			if (cb_clearHeatMapLayerCache_J == null)
				cb_clearHeatMapLayerCache_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_ClearHeatMapLayerCache_J);
			return cb_clearHeatMapLayerCache_J;
		}

		static void n_ClearHeatMapLayerCache_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearHeatMapLayerCache (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='clearHeatMapLayerCache' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("clearHeatMapLayerCache", "(J)V", "GetClearHeatMapLayerCache_JHandler")]
		public virtual unsafe void ClearHeatMapLayerCache (long p0)
		{
			const string __id = "clearHeatMapLayerCache.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_enableDrawHouseHeight_JZ;
#pragma warning disable 0169
		static Delegate GetEnableDrawHouseHeight_JZHandler ()
		{
			if (cb_enableDrawHouseHeight_JZ == null)
				cb_enableDrawHouseHeight_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_EnableDrawHouseHeight_JZ);
			return cb_enableDrawHouseHeight_JZ;
		}

		static void n_EnableDrawHouseHeight_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDrawHouseHeight (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='enableDrawHouseHeight' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("enableDrawHouseHeight", "(JZ)V", "GetEnableDrawHouseHeight_JZHandler")]
		public virtual unsafe void EnableDrawHouseHeight (long p0, bool p1)
		{
			const string __id = "enableDrawHouseHeight.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCompassPosition_JJ;
#pragma warning disable 0169
		static Delegate GetGetCompassPosition_JJHandler ()
		{
			if (cb_getCompassPosition_JJ == null)
				cb_getCompassPosition_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr>) n_GetCompassPosition_JJ);
			return cb_getCompassPosition_JJ;
		}

		static IntPtr n_GetCompassPosition_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetCompassPosition (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getCompassPosition' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("getCompassPosition", "(JJ)Ljava/lang/String;", "GetGetCompassPosition_JJHandler")]
		public virtual unsafe string GetCompassPosition (long p0, long p1)
		{
			const string __id = "getCompassPosition.(JJ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDrawingMapStatus_J;
#pragma warning disable 0169
		static Delegate GetGetDrawingMapStatus_JHandler ()
		{
			if (cb_getDrawingMapStatus_J == null)
				cb_getDrawingMapStatus_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetDrawingMapStatus_J);
			return cb_getDrawingMapStatus_J;
		}

		static IntPtr n_GetDrawingMapStatus_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawingMapStatus (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getDrawingMapStatus' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDrawingMapStatus", "(J)Landroid/os/Bundle;", "GetGetDrawingMapStatus_JHandler")]
		public virtual unsafe global::Android.OS.Bundle GetDrawingMapStatus (long p0)
		{
			const string __id = "getDrawingMapStatus.(J)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMapStatusLimits_J;
#pragma warning disable 0169
		static Delegate GetGetMapStatusLimits_JHandler ()
		{
			if (cb_getMapStatusLimits_J == null)
				cb_getMapStatusLimits_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetMapStatusLimits_J);
			return cb_getMapStatusLimits_J;
		}

		static IntPtr n_GetMapStatusLimits_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMapStatusLimits (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getMapStatusLimits' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getMapStatusLimits", "(J)Landroid/os/Bundle;", "GetGetMapStatusLimits_JHandler")]
		public virtual unsafe global::Android.OS.Bundle GetMapStatusLimits (long p0)
		{
			const string __id = "getMapStatusLimits.(J)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getProjectionMatrix_JarrayFI;
#pragma warning disable 0169
		static Delegate GetGetProjectionMatrix_JarrayFIHandler ()
		{
			if (cb_getProjectionMatrix_JarrayFI == null)
				cb_getProjectionMatrix_JarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_GetProjectionMatrix_JarrayFI);
			return cb_getProjectionMatrix_JarrayFI;
		}

		static void n_GetProjectionMatrix_JarrayFI (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetProjectionMatrix (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getProjectionMatrix' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='float[]'] and parameter[3][@type='int']]"
		[Register ("getProjectionMatrix", "(J[FI)V", "GetGetProjectionMatrix_JarrayFIHandler")]
		public virtual unsafe void GetProjectionMatrix (long p0, float[] p1, int p2)
		{
			const string __id = "getProjectionMatrix.(J[FI)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getViewMatrix_JarrayFI;
#pragma warning disable 0169
		static Delegate GetGetViewMatrix_JarrayFIHandler ()
		{
			if (cb_getViewMatrix_JarrayFI == null)
				cb_getViewMatrix_JarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_GetViewMatrix_JarrayFI);
			return cb_getViewMatrix_JarrayFI;
		}

		static void n_GetViewMatrix_JarrayFI (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetViewMatrix (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getViewMatrix' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='float[]'] and parameter[3][@type='int']]"
		[Register ("getViewMatrix", "(J[FI)V", "GetGetViewMatrix_JarrayFIHandler")]
		public virtual unsafe void GetViewMatrix (long p0, float[] p1, int p2)
		{
			const string __id = "getViewMatrix.(J[FI)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getfocusedBaseIndoorMapInfo_J;
#pragma warning disable 0169
		static Delegate GetGetfocusedBaseIndoorMapInfo_JHandler ()
		{
			if (cb_getfocusedBaseIndoorMapInfo_J == null)
				cb_getfocusedBaseIndoorMapInfo_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetfocusedBaseIndoorMapInfo_J);
			return cb_getfocusedBaseIndoorMapInfo_J;
		}

		static IntPtr n_GetfocusedBaseIndoorMapInfo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetfocusedBaseIndoorMapInfo (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='getfocusedBaseIndoorMapInfo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getfocusedBaseIndoorMapInfo", "(J)Ljava/lang/String;", "GetGetfocusedBaseIndoorMapInfo_JHandler")]
		public virtual unsafe string GetfocusedBaseIndoorMapInfo (long p0)
		{
			const string __id = "getfocusedBaseIndoorMapInfo.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isDrawHouseHeightEnable_J;
#pragma warning disable 0169
		static Delegate GetIsDrawHouseHeightEnable_JHandler ()
		{
			if (cb_isDrawHouseHeightEnable_J == null)
				cb_isDrawHouseHeightEnable_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_IsDrawHouseHeightEnable_J);
			return cb_isDrawHouseHeightEnable_J;
		}

		static bool n_IsDrawHouseHeightEnable_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawHouseHeightEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='isDrawHouseHeightEnable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isDrawHouseHeightEnable", "(J)Z", "GetIsDrawHouseHeightEnable_JHandler")]
		public virtual unsafe bool IsDrawHouseHeightEnable (long p0)
		{
			const string __id = "isDrawHouseHeightEnable.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeOneOverlayItem_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRemoveOneOverlayItem_JLandroid_os_Bundle_Handler ()
		{
			if (cb_removeOneOverlayItem_JLandroid_os_Bundle_ == null)
				cb_removeOneOverlayItem_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_RemoveOneOverlayItem_JLandroid_os_Bundle_);
			return cb_removeOneOverlayItem_JLandroid_os_Bundle_;
		}

		static void n_RemoveOneOverlayItem_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOneOverlayItem (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='removeOneOverlayItem' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("removeOneOverlayItem", "(JLandroid/os/Bundle;)V", "GetRemoveOneOverlayItem_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void RemoveOneOverlayItem (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "removeOneOverlayItem.(JLandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_resetBackgroundTransparent_J;
#pragma warning disable 0169
		static Delegate GetResetBackgroundTransparent_JHandler ()
		{
			if (cb_resetBackgroundTransparent_J == null)
				cb_resetBackgroundTransparent_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_ResetBackgroundTransparent_J);
			return cb_resetBackgroundTransparent_J;
		}

		static void n_ResetBackgroundTransparent_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetBackgroundTransparent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='resetBackgroundTransparent' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("resetBackgroundTransparent", "(J)V", "GetResetBackgroundTransparent_JHandler")]
		public virtual unsafe void ResetBackgroundTransparent (long p0)
		{
			const string __id = "resetBackgroundTransparent.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundTransparent_J;
#pragma warning disable 0169
		static Delegate GetSetBackgroundTransparent_JHandler ()
		{
			if (cb_setBackgroundTransparent_J == null)
				cb_setBackgroundTransparent_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBackgroundTransparent_J);
			return cb_setBackgroundTransparent_J;
		}

		static void n_SetBackgroundTransparent_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundTransparent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='setBackgroundTransparent' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setBackgroundTransparent", "(J)V", "GetSetBackgroundTransparent_JHandler")]
		public virtual unsafe void SetBackgroundTransparent (long p0)
		{
			const string __id = "setBackgroundTransparent.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCustomMapStyleParam_JLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetCustomMapStyleParam_JLjava_lang_String_IHandler ()
		{
			if (cb_setCustomMapStyleParam_JLjava_lang_String_I == null)
				cb_setCustomMapStyleParam_JLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_SetCustomMapStyleParam_JLjava_lang_String_I);
			return cb_setCustomMapStyleParam_JLjava_lang_String_I;
		}

		static void n_SetCustomMapStyleParam_JLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomMapStyleParam (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='setCustomMapStyleParam' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setCustomMapStyleParam", "(JLjava/lang/String;I)V", "GetSetCustomMapStyleParam_JLjava_lang_String_IHandler")]
		public virtual unsafe void SetCustomMapStyleParam (long p0, string p1, int p2)
		{
			const string __id = "setCustomMapStyleParam.(JLjava/lang/String;I)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setCustomTrafficColor_JJJJJZ;
#pragma warning disable 0169
		static Delegate GetSetCustomTrafficColor_JJJJJZHandler ()
		{
			if (cb_setCustomTrafficColor_JJJJJZ == null)
				cb_setCustomTrafficColor_JJJJJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, long, long, long, bool>) n_SetCustomTrafficColor_JJJJJZ);
			return cb_setCustomTrafficColor_JJJJJZ;
		}

		static void n_SetCustomTrafficColor_JJJJJZ (IntPtr jnienv, IntPtr native__this, long p0, long p1, long p2, long p3, long p4, bool p5)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomTrafficColor (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='setCustomTrafficColor' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean']]"
		[Register ("setCustomTrafficColor", "(JJJJJZ)V", "GetSetCustomTrafficColor_JJJJJZHandler")]
		public virtual unsafe void SetCustomTrafficColor (long p0, long p1, long p2, long p3, long p4, bool p5)
		{
			const string __id = "setCustomTrafficColor.(JJJJJZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMapCustomEnableDynamic_JZ;
#pragma warning disable 0169
		static Delegate GetSetMapCustomEnableDynamic_JZHandler ()
		{
			if (cb_setMapCustomEnableDynamic_JZ == null)
				cb_setMapCustomEnableDynamic_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_SetMapCustomEnableDynamic_JZ);
			return cb_setMapCustomEnableDynamic_JZ;
		}

		static void n_SetMapCustomEnableDynamic_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMapCustomEnableDynamic (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='setMapCustomEnableDynamic' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("setMapCustomEnableDynamic", "(JZ)V", "GetSetMapCustomEnableDynamic_JZHandler")]
		public virtual unsafe void SetMapCustomEnableDynamic (long p0, bool p1)
		{
			const string __id = "setMapCustomEnableDynamic.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMapStatusLimits_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetMapStatusLimits_JLandroid_os_Bundle_Handler ()
		{
			if (cb_setMapStatusLimits_JLandroid_os_Bundle_ == null)
				cb_setMapStatusLimits_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_SetMapStatusLimits_JLandroid_os_Bundle_);
			return cb_setMapStatusLimits_JLandroid_os_Bundle_;
		}

		static void n_SetMapStatusLimits_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMapStatusLimits (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='setMapStatusLimits' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("setMapStatusLimits", "(JLandroid/os/Bundle;)V", "GetSetMapStatusLimits_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void SetMapStatusLimits (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "setMapStatusLimits.(JLandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateOneOverlayItem_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUpdateOneOverlayItem_JLandroid_os_Bundle_Handler ()
		{
			if (cb_updateOneOverlayItem_JLandroid_os_Bundle_ == null)
				cb_updateOneOverlayItem_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateOneOverlayItem_JLandroid_os_Bundle_);
			return cb_updateOneOverlayItem_JLandroid_os_Bundle_;
		}

		static void n_UpdateOneOverlayItem_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateOneOverlayItem (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='updateOneOverlayItem' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("updateOneOverlayItem", "(JLandroid/os/Bundle;)V", "GetUpdateOneOverlayItem_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void UpdateOneOverlayItem (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "updateOneOverlayItem.(JLandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateSDKTile_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUpdateSDKTile_JLandroid_os_Bundle_Handler ()
		{
			if (cb_updateSDKTile_JLandroid_os_Bundle_ == null)
				cb_updateSDKTile_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_UpdateSDKTile_JLandroid_os_Bundle_);
			return cb_updateSDKTile_JLandroid_os_Bundle_;
		}

		static bool n_UpdateSDKTile_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap.JNIBaseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSDKTile (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='JNIBaseMap']/method[@name='updateSDKTile' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("updateSDKTile", "(JLandroid/os/Bundle;)Z", "GetUpdateSDKTile_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool UpdateSDKTile (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "updateSDKTile.(JLandroid/os/Bundle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
