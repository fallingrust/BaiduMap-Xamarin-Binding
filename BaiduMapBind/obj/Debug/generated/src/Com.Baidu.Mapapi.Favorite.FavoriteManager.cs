using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Favorite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/favorite/FavoriteManager", DoNotGenerateAcw=true)]
	public partial class FavoriteManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/favorite/FavoriteManager", typeof (FavoriteManager));
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

		protected FavoriteManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllFavPois;
#pragma warning disable 0169
		static Delegate GetGetAllFavPoisHandler ()
		{
			if (cb_getAllFavPois == null)
				cb_getAllFavPois = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllFavPois);
			return cb_getAllFavPois;
		}

		static IntPtr n_GetAllFavPois (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo>.ToLocalJniHandle (__this.AllFavPois);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> AllFavPois {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='getAllFavPois' and count(parameter)=0]"
			[Register ("getAllFavPois", "()Ljava/util/List;", "GetGetAllFavPoisHandler")]
			get {
				const string __id = "getAllFavPois.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Baidu.Mapapi.Favorite.FavoriteManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapapi/favorite/FavoriteManager;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/baidu/mapapi/favorite/FavoriteManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler ()
		{
			if (cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ == null)
				cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_);
			return cb_add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
		}

		static int n_Add_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.favorite.FavoritePoiInfo']]"
		[Register ("add", "(Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)I", "GetAdd_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler")]
		public virtual unsafe int Add (global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p0)
		{
			const string __id = "add.(Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clearAllFavPois;
#pragma warning disable 0169
		static Delegate GetClearAllFavPoisHandler ()
		{
			if (cb_clearAllFavPois == null)
				cb_clearAllFavPois = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearAllFavPois);
			return cb_clearAllFavPois;
		}

		static bool n_ClearAllFavPois (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearAllFavPois ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='clearAllFavPois' and count(parameter)=0]"
		[Register ("clearAllFavPois", "()Z", "GetClearAllFavPoisHandler")]
		public virtual unsafe bool ClearAllFavPois ()
		{
			const string __id = "clearAllFavPois.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_deleteFavPoi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFavPoi_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFavPoi_Ljava_lang_String_ == null)
				cb_deleteFavPoi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteFavPoi_Ljava_lang_String_);
			return cb_deleteFavPoi_Ljava_lang_String_;
		}

		static bool n_DeleteFavPoi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFavPoi (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='deleteFavPoi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFavPoi", "(Ljava/lang/String;)Z", "GetDeleteFavPoi_Ljava_lang_String_Handler")]
		public virtual unsafe bool DeleteFavPoi (string p0)
		{
			const string __id = "deleteFavPoi.(Ljava/lang/String;)Z";
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
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getFavPoi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFavPoi_Ljava_lang_String_Handler ()
		{
			if (cb_getFavPoi_Ljava_lang_String_ == null)
				cb_getFavPoi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFavPoi_Ljava_lang_String_);
			return cb_getFavPoi_Ljava_lang_String_;
		}

		static IntPtr n_GetFavPoi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFavPoi (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='getFavPoi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFavPoi", "(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;", "GetGetFavPoi_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo GetFavPoi (string p0)
		{
			const string __id = "getFavPoi.(Ljava/lang/String;)Lcom/baidu/mapapi/favorite/FavoritePoiInfo;";
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

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
#pragma warning disable 0169
		static Delegate GetUpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler ()
		{
			if (cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ == null)
				cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_);
			return cb_updateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_;
		}

		static bool n_UpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Favorite.FavoriteManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoriteManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateFavPoi (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.favorite']/class[@name='FavoriteManager']/method[@name='updateFavPoi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.baidu.mapapi.favorite.FavoritePoiInfo']]"
		[Register ("updateFavPoi", "(Ljava/lang/String;Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)Z", "GetUpdateFavPoi_Ljava_lang_String_Lcom_baidu_mapapi_favorite_FavoritePoiInfo_Handler")]
		public virtual unsafe bool UpdateFavPoi (string p0, global::Com.Baidu.Mapapi.Favorite.FavoritePoiInfo p1)
		{
			const string __id = "updateFavPoi.(Ljava/lang/String;Lcom/baidu/mapapi/favorite/FavoritePoiInfo;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
