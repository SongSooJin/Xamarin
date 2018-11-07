using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Topc290.Helloaar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.example.topc290.helloaar']/class[@name='SayHelloImpl']"
	[global::Android.Runtime.Register ("com/example/topc290/helloaar/SayHelloImpl", DoNotGenerateAcw=true)]
	public partial class SayHelloImpl : global::Java.Lang.Object, global::Com.Example.Topc290.Helloaar.ISayHello {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/example/topc290/helloaar/SayHelloImpl", typeof (SayHelloImpl));
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

		protected SayHelloImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.example.topc290.helloaar']/class[@name='SayHelloImpl']/constructor[@name='SayHelloImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SayHelloImpl ()
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

		static Delegate cb_sayHello_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSayHello_Ljava_lang_String_Handler ()
		{
			if (cb_sayHello_Ljava_lang_String_ == null)
				cb_sayHello_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SayHello_Ljava_lang_String_);
			return cb_sayHello_Ljava_lang_String_;
		}

		static IntPtr n_SayHello_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Example.Topc290.Helloaar.SayHelloImpl __this = global::Java.Lang.Object.GetObject<global::Com.Example.Topc290.Helloaar.SayHelloImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SayHello (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.topc290.helloaar']/class[@name='SayHelloImpl']/method[@name='sayHello' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sayHello", "(Ljava/lang/String;)Ljava/lang/String;", "GetSayHello_Ljava_lang_String_Handler")]
		public virtual unsafe string SayHello (string name)
		{
			const string __id = "sayHello.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
