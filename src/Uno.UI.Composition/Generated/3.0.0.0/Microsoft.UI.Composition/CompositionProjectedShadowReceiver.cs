#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionProjectedShadowReceiver : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Visual ReceivingVisual
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual CompositionProjectedShadowReceiver.ReceivingVisual is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Visual%20CompositionProjectedShadowReceiver.ReceivingVisual");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionProjectedShadowReceiver", "Visual CompositionProjectedShadowReceiver.ReceivingVisual");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.ReceivingVisual.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowReceiver.ReceivingVisual.set
	}
}