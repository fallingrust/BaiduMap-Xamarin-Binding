using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/map/favorite/JNIFavorite", DoNotGenerateAcw=true)]
	public partial class JNIFavorite : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/map/favorite/JNIFavorite", typeof (JNIFavorite));
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

		protected JNIFavorite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/constructor[@name='JNIFavorite' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNIFavorite ()
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

		static Delegate cb_Add_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Add_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_Add_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_Add_JLjava_lang_String_Ljava_lang_String_);
			return cb_Add_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_Add_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Add' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("Add", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetAdd_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Add (long p0, string p1, string p2)
		{
			const string __id = "Add.(JLjava/lang/String;Ljava/lang/String;)Z";
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

		static Delegate cb_Clear_J;
#pragma warning disable 0169
		static Delegate GetClear_JHandler ()
		{
			if (cb_Clear_J == null)
				cb_Clear_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Clear_J);
			return cb_Clear_J;
		}

		static bool n_Clear_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Clear' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Clear", "(J)Z", "GetClear_JHandler")]
		public virtual unsafe bool Clear (long p0)
		{
			const string __id = "Clear.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Create' and count(parameter)=0]"
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

		static Delegate cb_GetAll_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAll_JLandroid_os_Bundle_Handler ()
		{
			if (cb_GetAll_JLandroid_os_Bundle_ == null)
				cb_GetAll_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int>) n_GetAll_JLandroid_os_Bundle_);
			return cb_GetAll_JLandroid_os_Bundle_;
		}

		static int n_GetAll_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAll (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='GetAll' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("GetAll", "(JLandroid/os/Bundle;)I", "GetGetAll_JLandroid_os_Bundle_Handler")]
		public virtual unsafe int GetAll (long p0, global::Android.OS.Bundle p1)
		{
			const string __id = "GetAll.(JLandroid/os/Bundle;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_GetValue_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetValue_JLjava_lang_String_Handler ()
		{
			if (cb_GetValue_JLjava_lang_String_ == null)
				cb_GetValue_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetValue_JLjava_lang_String_);
			return cb_GetValue_JLjava_lang_String_;
		}

		static IntPtr n_GetValue_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='GetValue' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("GetValue", "(JLjava/lang/String;)Ljava/lang/String;", "GetGetValue_JLjava_lang_String_Handler")]
		public virtual unsafe string GetValue (long p0, string p1)
		{
			const string __id = "GetValue.(JLjava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_IsExist_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsExist_JLjava_lang_String_Handler ()
		{
			if (cb_IsExist_JLjava_lang_String_ == null)
				cb_IsExist_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_IsExist_JLjava_lang_String_);
			return cb_IsExist_JLjava_lang_String_;
		}

		static bool n_IsExist_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsExist (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='IsExist' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("IsExist", "(JLjava/lang/String;)Z", "GetIsExist_JLjava_lang_String_Handler")]
		public virtual unsafe bool IsExist (long p0, string p1)
		{
			const string __id = "IsExist.(JLjava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetLoad_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_IIIHandler ()
		{
			if (cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III == null)
				cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, int, int, int, bool>) n_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III);
			return cb_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III;
		}

		static bool n_Load_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, int p6)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Load (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Load' and count(parameter)=7 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("Load", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;III)Z", "GetLoad_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_IIIHandler")]
		public virtual unsafe bool Load (long p0, string p1, string p2, string p3, int p4, int p5, int p6)
		{
			const string __id = "Load.(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;III)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Release' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_Remove_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_JLjava_lang_String_Handler ()
		{
			if (cb_Remove_JLjava_lang_String_ == null)
				cb_Remove_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_Remove_JLjava_lang_String_);
			return cb_Remove_JLjava_lang_String_;
		}

		static bool n_Remove_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Remove' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("Remove", "(JLjava/lang/String;)Z", "GetRemove_JLjava_lang_String_Handler")]
		public virtual unsafe bool Remove (long p0, string p1)
		{
			const string __id = "Remove.(JLjava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_SaveCache_J;
#pragma warning disable 0169
		static Delegate GetSaveCache_JHandler ()
		{
			if (cb_SaveCache_J == null)
				cb_SaveCache_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SaveCache_J);
			return cb_SaveCache_J;
		}

		static bool n_SaveCache_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaveCache (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='SaveCache' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("SaveCache", "(J)Z", "GetSaveCache_JHandler")]
		public virtual unsafe bool SaveCache (long p0)
		{
			const string __id = "SaveCache.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_SetType_JI;
#pragma warning disable 0169
		static Delegate GetSetType_JIHandler ()
		{
			if (cb_SetType_JI == null)
				cb_SetType_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool>) n_SetType_JI);
			return cb_SetType_JI;
		}

		static bool n_SetType_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetType (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='SetType' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("SetType", "(JI)Z", "GetSetType_JIHandler")]
		public virtual unsafe bool SetType (long p0, int p1)
		{
			const string __id = "SetType.(JI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_Update_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Update_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_Update_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_Update_JLjava_lang_String_Ljava_lang_String_);
			return cb_Update_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_Update_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Map.Favorite.JNIFavorite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Update (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.favorite']/class[@name='JNIFavorite']/method[@name='Update' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("Update", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetUpdate_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Update (long p0, string p1, string p2)
		{
			const string __id = "Update.(JLjava/lang/String;Ljava/lang/String;)Z";
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

	}
}
