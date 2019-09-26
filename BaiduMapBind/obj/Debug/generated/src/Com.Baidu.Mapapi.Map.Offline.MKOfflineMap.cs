using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/offline/MKOfflineMap", DoNotGenerateAcw=true)]
	public partial class MKOfflineMap : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/field[@name='TYPE_DOWNLOAD_UPDATE']"
		[Register ("TYPE_DOWNLOAD_UPDATE")]
		public const int TypeDownloadUpdate = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/field[@name='TYPE_NETWORK_ERROR']"
		[Register ("TYPE_NETWORK_ERROR")]
		public const int TypeNetworkError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/field[@name='TYPE_NEW_OFFLINE']"
		[Register ("TYPE_NEW_OFFLINE")]
		public const int TypeNewOffline = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/field[@name='TYPE_VER_UPDATE']"
		[Register ("TYPE_VER_UPDATE")]
		public const int TypeVerUpdate = (int) 4;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/offline/MKOfflineMap", typeof (MKOfflineMap));
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

		protected MKOfflineMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/constructor[@name='MKOfflineMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKOfflineMap ()
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

		static Delegate cb_getAllUpdateInfo;
#pragma warning disable 0169
		static Delegate GetGetAllUpdateInfoHandler ()
		{
			if (cb_getAllUpdateInfo == null)
				cb_getAllUpdateInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllUpdateInfo);
			return cb_getAllUpdateInfo;
		}

		static IntPtr n_GetAllUpdateInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLUpdateElement>.ToLocalJniHandle (__this.AllUpdateInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Offline.MKOLUpdateElement> AllUpdateInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='getAllUpdateInfo' and count(parameter)=0]"
			[Register ("getAllUpdateInfo", "()Ljava/util/ArrayList;", "GetGetAllUpdateInfoHandler")]
			get {
				const string __id = "getAllUpdateInfo.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLUpdateElement>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHotCityList;
#pragma warning disable 0169
		static Delegate GetGetHotCityListHandler ()
		{
			if (cb_getHotCityList == null)
				cb_getHotCityList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHotCityList);
			return cb_getHotCityList;
		}

		static IntPtr n_GetHotCityList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord>.ToLocalJniHandle (__this.HotCityList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord> HotCityList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='getHotCityList' and count(parameter)=0]"
			[Register ("getHotCityList", "()Ljava/util/ArrayList;", "GetGetHotCityListHandler")]
			get {
				const string __id = "getHotCityList.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOfflineCityList;
#pragma warning disable 0169
		static Delegate GetGetOfflineCityListHandler ()
		{
			if (cb_getOfflineCityList == null)
				cb_getOfflineCityList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOfflineCityList);
			return cb_getOfflineCityList;
		}

		static IntPtr n_GetOfflineCityList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord>.ToLocalJniHandle (__this.OfflineCityList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord> OfflineCityList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='getOfflineCityList' and count(parameter)=0]"
			[Register ("getOfflineCityList", "()Ljava/util/ArrayList;", "GetGetOfflineCityListHandler")]
			get {
				const string __id = "getOfflineCityList.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getUpdateInfo_I;
#pragma warning disable 0169
		static Delegate GetGetUpdateInfo_IHandler ()
		{
			if (cb_getUpdateInfo_I == null)
				cb_getUpdateInfo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetUpdateInfo_I);
			return cb_getUpdateInfo_I;
		}

		static IntPtr n_GetUpdateInfo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUpdateInfo (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='getUpdateInfo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUpdateInfo", "(I)Lcom/baidu/mapapi/map/offline/MKOLUpdateElement;", "GetGetUpdateInfo_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.Offline.MKOLUpdateElement GetUpdateInfo (int p0)
		{
			const string __id = "getUpdateInfo.(I)Lcom/baidu/mapapi/map/offline/MKOLUpdateElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOLUpdateElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_importOfflineData;
#pragma warning disable 0169
		static Delegate GetImportOfflineDataHandler ()
		{
			if (cb_importOfflineData == null)
				cb_importOfflineData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ImportOfflineData);
			return cb_importOfflineData;
		}

		static int n_ImportOfflineData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportOfflineData ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='importOfflineData' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("importOfflineData", "()I", "GetImportOfflineDataHandler")]
		public virtual unsafe int ImportOfflineData ()
		{
			const string __id = "importOfflineData.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_importOfflineData_Z;
#pragma warning disable 0169
		static Delegate GetImportOfflineData_ZHandler ()
		{
			if (cb_importOfflineData_Z == null)
				cb_importOfflineData_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int>) n_ImportOfflineData_Z);
			return cb_importOfflineData_Z;
		}

		static int n_ImportOfflineData_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportOfflineData (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='importOfflineData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("importOfflineData", "(Z)I", "GetImportOfflineData_ZHandler")]
		public virtual unsafe int ImportOfflineData (bool p0)
		{
			const string __id = "importOfflineData.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_init_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_Handler ()
		{
			if (cb_init_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_ == null)
				cb_init_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Init_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_);
			return cb_init_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_;
		}

		static bool n_Init_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListener p0 = (global::Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Init (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.offline.MKOfflineMapListener']]"
		[Register ("init", "(Lcom/baidu/mapapi/map/offline/MKOfflineMapListener;)Z", "GetInit_Lcom_baidu_mapapi_map_offline_MKOfflineMapListener_Handler")]
		public virtual unsafe bool Init (global::Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListener p0)
		{
			const string __id = "init.(Lcom/baidu/mapapi/map/offline/MKOfflineMapListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pause_I;
#pragma warning disable 0169
		static Delegate GetPause_IHandler ()
		{
			if (cb_pause_I == null)
				cb_pause_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Pause_I);
			return cb_pause_I;
		}

		static bool n_Pause_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pause (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pause", "(I)Z", "GetPause_IHandler")]
		public virtual unsafe bool Pause (int p0)
		{
			const string __id = "pause.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Remove_I);
			return cb_remove_I;
		}

		static bool n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Remove (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Z", "GetRemove_IHandler")]
		public virtual unsafe bool Remove (int p0)
		{
			const string __id = "remove.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_searchCity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSearchCity_Ljava_lang_String_Handler ()
		{
			if (cb_searchCity_Ljava_lang_String_ == null)
				cb_searchCity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SearchCity_Ljava_lang_String_);
			return cb_searchCity_Ljava_lang_String_;
		}

		static IntPtr n_SearchCity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord>.ToLocalJniHandle (__this.SearchCity (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='searchCity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("searchCity", "(Ljava/lang/String;)Ljava/util/ArrayList;", "GetSearchCity_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord> SearchCity (string p0)
		{
			const string __id = "searchCity.(Ljava/lang/String;)Ljava/util/ArrayList;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Offline.MKOLSearchRecord>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_start_I;
#pragma warning disable 0169
		static Delegate GetStart_IHandler ()
		{
			if (cb_start_I == null)
				cb_start_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Start_I);
			return cb_start_I;
		}

		static bool n_Start_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='start' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("start", "(I)Z", "GetStart_IHandler")]
		public virtual unsafe bool Start (int p0)
		{
			const string __id = "start.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_update_I;
#pragma warning disable 0169
		static Delegate GetUpdate_IHandler ()
		{
			if (cb_update_I == null)
				cb_update_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Update_I);
			return cb_update_I;
		}

		static bool n_Update_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Offline.MKOfflineMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Update (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOfflineMap']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)Z", "GetUpdate_IHandler")]
		public virtual unsafe bool Update (int p0)
		{
			const string __id = "update.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
