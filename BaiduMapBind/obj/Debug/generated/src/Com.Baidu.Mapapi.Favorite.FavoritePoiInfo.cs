using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Favorite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/favorite/FavoritePoiInfo", DoNotGenerateAcw=true)]
	public partial class FavoritePoiInfo : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/favorite/FavoritePoiInfo", typeof (FavoritePoiInfo));
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

		protected FavoritePoiInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/constructor[@name='FavoritePoiInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FavoritePoiInfo ()
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

		static Delegate cb_getAddr;
#pragma warning disable 0169
		static Delegate GetGetAddrHandler ()
		{
			if (cb_getAddr == null)
				cb_getAddr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddr);
			return cb_getAddr;
		}

		static IntPtr n_GetAddr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Addr);
		}
#pragma warning restore 0169

		public virtual unsafe string Addr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getAddr' and count(parameter)=0]"
			[Register ("getAddr", "()Ljava/lang/String;", "GetGetAddrHandler")]
			get {
				const string __id = "getAddr.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCityName;
#pragma warning disable 0169
		static Delegate GetGetCityNameHandler ()
		{
			if (cb_getCityName == null)
				cb_getCityName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCityName);
			return cb_getCityName;
		}

		static IntPtr n_GetCityName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CityName);
		}
#pragma warning restore 0169

		public virtual unsafe string CityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getCityName' and count(parameter)=0]"
			[Register ("getCityName", "()Ljava/lang/String;", "GetGetCityNameHandler")]
			get {
				const string __id = "getCityName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getID;
#pragma warning disable 0169
		static Delegate GetGetIDHandler ()
		{
			if (cb_getID == null)
				cb_getID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetID);
			return cb_getID;
		}

		static IntPtr n_GetID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ID);
		}
#pragma warning restore 0169

		public virtual unsafe string ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()Ljava/lang/String;", "GetGetIDHandler")]
			get {
				const string __id = "getID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPoiName;
#pragma warning disable 0169
		static Delegate GetGetPoiNameHandler ()
		{
			if (cb_getPoiName == null)
				cb_getPoiName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiName);
			return cb_getPoiName;
		}

		static IntPtr n_GetPoiName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PoiName);
		}
#pragma warning restore 0169

		public virtual unsafe string PoiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getPoiName' and count(parameter)=0]"
			[Register ("getPoiName", "()Ljava/lang/String;", "GetGetPoiNameHandler")]
			get {
				const string __id = "getPoiName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPt;
#pragma warning disable 0169
		static Delegate GetGetPtHandler ()
		{
			if (cb_getPt == null)
				cb_getPt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPt);
			return cb_getPt;
		}

		static IntPtr n_GetPt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pt);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Pt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getPt' and count(parameter)=0]"
			[Register ("getPt", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPtHandler")]
			get {
				const string __id = "getPt.()Lcom/baidu/mapapi/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static long n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		public virtual unsafe long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler")]
			get {
				const string __id = "getTimeStamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				const string __id = "getUid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeAddr_Ljava_lang_String_Handler ()
		{
			if (cb_addr_Ljava_lang_String_ == null)
				cb_addr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeAddr_Ljava_lang_String_);
			return cb_addr_Ljava_lang_String_;
		}

		static IntPtr n_InvokeAddr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeAddr (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='addr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addr", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokeAddr_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokeAddr (string p0)
		{
			const string __id = "addr.(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cityName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeCityName_Ljava_lang_String_Handler ()
		{
			if (cb_cityName_Ljava_lang_String_ == null)
				cb_cityName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeCityName_Ljava_lang_String_);
			return cb_cityName_Ljava_lang_String_;
		}

		static IntPtr n_InvokeCityName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeCityName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='cityName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cityName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokeCityName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokeCityName (string p0)
		{
			const string __id = "cityName.(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_poiName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokePoiName_Ljava_lang_String_Handler ()
		{
			if (cb_poiName_Ljava_lang_String_ == null)
				cb_poiName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokePoiName_Ljava_lang_String_);
			return cb_poiName_Ljava_lang_String_;
		}

		static IntPtr n_InvokePoiName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokePoiName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='poiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("poiName", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokePoiName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokePoiName (string p0)
		{
			const string __id = "poiName.(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pt_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokePt_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_pt_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_pt_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokePt_Lcom_baidu_mapapi_model_LatLng_);
			return cb_pt_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_InvokePt_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokePt (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='pt' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("pt", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokePt_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokePt (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "pt.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_uid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeUid_Ljava_lang_String_Handler ()
		{
			if (cb_uid_Ljava_lang_String_ == null)
				cb_uid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeUid_Ljava_lang_String_);
			return cb_uid_Ljava_lang_String_;
		}

		static IntPtr n_InvokeUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeUid (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoritePoiInfo']/method[@name='uid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uid", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetInvokeUid_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo InvokeUid (string p0)
		{
			const string __id = "uid.(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
