#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ExponentialEasingFunction : global::Microsoft.UI.Composition.CompositionEasingFunction
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Exponent
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ExponentialEasingFunction.Exponent is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20ExponentialEasingFunction.Exponent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionEasingFunctionMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionEasingFunctionMode ExponentialEasingFunction.Mode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionEasingFunctionMode%20ExponentialEasingFunction.Mode");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.ExponentialEasingFunction.Exponent.get
		// Forced skipping of method Microsoft.UI.Composition.ExponentialEasingFunction.Mode.get
	}
}