using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']"
	[global::Android.Runtime.Register ("com/baidu/location/LocationClient", DoNotGenerateAcw=true)]
	public sealed partial class LocationClient : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='CONNECT_HOT_SPOT_FALSE']"
		[Register ("CONNECT_HOT_SPOT_FALSE")]
		public const int ConnectHotSpotFalse = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='CONNECT_HOT_SPOT_TRUE']"
		[Register ("CONNECT_HOT_SPOT_TRUE")]
		public const int ConnectHotSpotTrue = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='CONNECT_HOT_SPOT_UNKNOWN']"
		[Register ("CONNECT_HOT_SPOT_UNKNOWN")]
		public const int ConnectHotSpotUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_BETTER_OPEN_GPS']"
		[Register ("LOC_DIAGNOSTIC_TYPE_BETTER_OPEN_GPS")]
		public const int LocDiagnosticTypeBetterOpenGps = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_BETTER_OPEN_WIFI']"
		[Register ("LOC_DIAGNOSTIC_TYPE_BETTER_OPEN_WIFI")]
		public const int LocDiagnosticTypeBetterOpenWifi = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_FAIL_UNKNOWN']"
		[Register ("LOC_DIAGNOSTIC_TYPE_FAIL_UNKNOWN")]
		public const int LocDiagnosticTypeFailUnknown = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_NEED_CHECK_LOC_PERMISSION']"
		[Register ("LOC_DIAGNOSTIC_TYPE_NEED_CHECK_LOC_PERMISSION")]
		public const int LocDiagnosticTypeNeedCheckLocPermission = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_NEED_CHECK_NET']"
		[Register ("LOC_DIAGNOSTIC_TYPE_NEED_CHECK_NET")]
		public const int LocDiagnosticTypeNeedCheckNet = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_NEED_CLOSE_FLYMODE']"
		[Register ("LOC_DIAGNOSTIC_TYPE_NEED_CLOSE_FLYMODE")]
		public const int LocDiagnosticTypeNeedCloseFlymode = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_NEED_INSERT_SIMCARD_OR_OPEN_WIFI']"
		[Register ("LOC_DIAGNOSTIC_TYPE_NEED_INSERT_SIMCARD_OR_OPEN_WIFI")]
		public const int LocDiagnosticTypeNeedInsertSimcardOrOpenWifi = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_NEED_OPEN_PHONE_LOC_SWITCH']"
		[Register ("LOC_DIAGNOSTIC_TYPE_NEED_OPEN_PHONE_LOC_SWITCH")]
		public const int LocDiagnosticTypeNeedOpenPhoneLocSwitch = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/field[@name='LOC_DIAGNOSTIC_TYPE_SERVER_FAIL']"
		[Register ("LOC_DIAGNOSTIC_TYPE_SERVER_FAIL")]
		public const int LocDiagnosticTypeServerFail = (int) 8;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/LocationClient", typeof (LocationClient));
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

		internal LocationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/constructor[@name='LocationClient' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LocationClient (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/constructor[@name='LocationClient' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.location.LocationClientOption']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;)V", "")]
		public unsafe LocationClient (global::Android.Content.Context p0, global::Com.Baidu.Location.LocationClientOption p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe string AccessKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getAccessKey' and count(parameter)=0]"
			[Register ("getAccessKey", "()Ljava/lang/String;", "GetGetAccessKeyHandler")]
			get {
				const string __id = "getAccessKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				const string __id = "isStarted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Location.BDLocation LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Lcom/baidu/location/BDLocation;", "GetGetLastKnownLocationHandler")]
			get {
				const string __id = "getLastKnownLocation.()Lcom/baidu/location/BDLocation;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Location.LocationClientOption LocOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getLocOption' and count(parameter)=0]"
			[Register ("getLocOption", "()Lcom/baidu/location/LocationClientOption;", "GetGetLocOptionHandler")]
			get {
				const string __id = "getLocOption.()Lcom/baidu/location/LocationClientOption;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='setLocOption' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption']]"
			[Register ("setLocOption", "(Lcom/baidu/location/LocationClientOption;)V", "GetSetLocOption_Lcom_baidu_location_LocationClientOption_Handler")]
			set {
				const string __id = "setLocOption.(Lcom/baidu/location/LocationClientOption;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='disableAssistantLocation' and count(parameter)=0]"
		[Register ("disableAssistantLocation", "()V", "")]
		public unsafe void DisableAssistantLocation ()
		{
			const string __id = "disableAssistantLocation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='disableLocInForeground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disableLocInForeground", "(Z)V", "")]
		public unsafe void DisableLocInForeground (bool p0)
		{
			const string __id = "disableLocInForeground.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='enableAssistantLocation' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("enableAssistantLocation", "(Landroid/webkit/WebView;)V", "")]
		public unsafe void EnableAssistantLocation (global::Android.Webkit.WebView p0)
		{
			const string __id = "enableAssistantLocation.(Landroid/webkit/WebView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='enableLocInForeground' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Notification']]"
		[Register ("enableLocInForeground", "(ILandroid/app/Notification;)V", "")]
		public unsafe void EnableLocInForeground (int p0, global::Android.App.Notification p1)
		{
			const string __id = "enableLocInForeground.(ILandroid/app/Notification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='getBDLocationInCoorType' and count(parameter)=2 and parameter[1][@type='com.baidu.location.BDLocation'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBDLocationInCoorType", "(Lcom/baidu/location/BDLocation;Ljava/lang/String;)Lcom/baidu/location/BDLocation;", "")]
		public static unsafe global::Com.Baidu.Location.BDLocation GetBDLocationInCoorType (global::Com.Baidu.Location.BDLocation p0, string p1)
		{
			const string __id = "getBDLocationInCoorType.(Lcom/baidu/location/BDLocation;Ljava/lang/String;)Lcom/baidu/location/BDLocation;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='onReceiveLightLocString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReceiveLightLocString", "(Ljava/lang/String;)V", "")]
		public unsafe void OnReceiveLightLocString (string p0)
		{
			const string __id = "onReceiveLightLocString.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='onReceiveLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register ("onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V", "")]
		public unsafe void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
		{
			const string __id = "onReceiveLocation.(Lcom/baidu/location/BDLocation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='registerLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDAbstractLocationListener']]"
		[Register ("registerLocationListener", "(Lcom/baidu/location/BDAbstractLocationListener;)V", "")]
		public unsafe void RegisterLocationListener (global::Com.Baidu.Location.BDAbstractLocationListener p0)
		{
			const string __id = "registerLocationListener.(Lcom/baidu/location/BDAbstractLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='registerLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocationListener']]"
		[Obsolete (@"deprecated")]
		[Register ("registerLocationListener", "(Lcom/baidu/location/BDLocationListener;)V", "")]
		public unsafe void RegisterLocationListener (global::Com.Baidu.Location.IBDLocationListener p0)
		{
			const string __id = "registerLocationListener.(Lcom/baidu/location/BDLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='registerNotify' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDNotifyListener']]"
		[Register ("registerNotify", "(Lcom/baidu/location/BDNotifyListener;)V", "")]
		public unsafe void RegisterNotify (global::Com.Baidu.Location.BDNotifyListener p0)
		{
			const string __id = "registerNotify.(Lcom/baidu/location/BDNotifyListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='registerNotifyLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocationListener']]"
		[Register ("registerNotifyLocationListener", "(Lcom/baidu/location/BDLocationListener;)V", "")]
		public unsafe void RegisterNotifyLocationListener (global::Com.Baidu.Location.IBDLocationListener p0)
		{
			const string __id = "registerNotifyLocationListener.(Lcom/baidu/location/BDLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='removeNotifyEvent' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDNotifyListener']]"
		[Register ("removeNotifyEvent", "(Lcom/baidu/location/BDNotifyListener;)V", "")]
		public unsafe void RemoveNotifyEvent (global::Com.Baidu.Location.BDNotifyListener p0)
		{
			const string __id = "removeNotifyEvent.(Lcom/baidu/location/BDNotifyListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestHotSpotState' and count(parameter)=0]"
		[Register ("requestHotSpotState", "()Z", "")]
		public unsafe bool RequestHotSpotState ()
		{
			const string __id = "requestHotSpotState.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestLocation' and count(parameter)=0]"
		[Register ("requestLocation", "()I", "")]
		public unsafe int RequestLocation ()
		{
			const string __id = "requestLocation.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestNotifyLocation' and count(parameter)=0]"
		[Register ("requestNotifyLocation", "()V", "")]
		public unsafe void RequestNotifyLocation ()
		{
			const string __id = "requestNotifyLocation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='requestOfflineLocation' and count(parameter)=0]"
		[Register ("requestOfflineLocation", "()I", "")]
		public unsafe int RequestOfflineLocation ()
		{
			const string __id = "requestOfflineLocation.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='restart' and count(parameter)=0]"
		[Register ("restart", "()V", "")]
		public unsafe void Restart ()
		{
			const string __id = "restart.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='startIndoorMode' and count(parameter)=0]"
		[Register ("startIndoorMode", "()Z", "")]
		public unsafe bool StartIndoorMode ()
		{
			const string __id = "startIndoorMode.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='stopIndoorMode' and count(parameter)=0]"
		[Register ("stopIndoorMode", "()Z", "")]
		public unsafe bool StopIndoorMode ()
		{
			const string __id = "stopIndoorMode.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='unRegisterLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDAbstractLocationListener']]"
		[Register ("unRegisterLocationListener", "(Lcom/baidu/location/BDAbstractLocationListener;)V", "")]
		public unsafe void UnRegisterLocationListener (global::Com.Baidu.Location.BDAbstractLocationListener p0)
		{
			const string __id = "unRegisterLocationListener.(Lcom/baidu/location/BDAbstractLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='unRegisterLocationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocationListener']]"
		[Obsolete (@"deprecated")]
		[Register ("unRegisterLocationListener", "(Lcom/baidu/location/BDLocationListener;)V", "")]
		public unsafe void UnRegisterLocationListener (global::Com.Baidu.Location.IBDLocationListener p0)
		{
			const string __id = "unRegisterLocationListener.(Lcom/baidu/location/BDLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClient']/method[@name='updateLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("updateLocation", "(Landroid/location/Location;)Z", "")]
		public unsafe bool UpdateLocation (global::Android.Locations.Location p0)
		{
			const string __id = "updateLocation.(Landroid/location/Location;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
