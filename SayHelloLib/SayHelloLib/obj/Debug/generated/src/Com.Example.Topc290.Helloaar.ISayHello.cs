using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Example.Topc290.Helloaar {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.example.topc290.helloaar']/interface[@name='SayHello']"
	[Register ("com/example/topc290/helloaar/SayHello", "", "Com.Example.Topc290.Helloaar.ISayHelloInvoker")]
	public partial interface ISayHello : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.example.topc290.helloaar']/interface[@name='SayHello']/method[@name='sayHello' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sayHello", "(Ljava/lang/String;)Ljava/lang/String;", "GetSayHello_Ljava_lang_String_Handler:Com.Example.Topc290.Helloaar.ISayHelloInvoker, SayHelloLib")]
		string SayHello (string p0);

	}

	[global::Android.Runtime.Register ("com/example/topc290/helloaar/SayHello", DoNotGenerateAcw=true)]
	internal class ISayHelloInvoker : global::Java.Lang.Object, ISayHello {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/example/topc290/helloaar/SayHello", typeof (ISayHelloInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ISayHello GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISayHello> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.example.topc290.helloaar.SayHello"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISayHelloInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sayHello_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSayHello_Ljava_lang_String_Handler ()
		{
			if (cb_sayHello_Ljava_lang_String_ == null)
				cb_sayHello_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SayHello_Ljava_lang_String_);
			return cb_sayHello_Ljava_lang_String_;
		}

		static IntPtr n_SayHello_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Example.Topc290.Helloaar.ISayHello __this = global::Java.Lang.Object.GetObject<global::Com.Example.Topc290.Helloaar.ISayHello> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SayHello (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sayHello_Ljava_lang_String_;
		public unsafe string SayHello (string p0)
		{
			if (id_sayHello_Ljava_lang_String_ == IntPtr.Zero)
				id_sayHello_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sayHello", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sayHello_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
