#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DataTemplate : global::Microsoft.UI.Xaml.FrameworkTemplate,global::Microsoft.UI.Xaml.IElementFactory
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ExtensionInstanceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"ExtensionInstance", typeof(global::Microsoft.UI.Xaml.IDataTemplateExtension), 
			typeof(global::Microsoft.UI.Xaml.DataTemplate), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.IDataTemplateExtension)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.DataTemplate.DataTemplate()
		// Forced skipping of method Microsoft.UI.Xaml.DataTemplate.DataTemplate()
		// Skipping already declared method Microsoft.UI.Xaml.DataTemplate.LoadContent()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement GetElement( global::Microsoft.UI.Xaml.ElementFactoryGetArgs args)
		{
			throw new global::System.NotImplementedException("The member UIElement DataTemplate.GetElement(ElementFactoryGetArgs args) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UIElement%20DataTemplate.GetElement%28ElementFactoryGetArgs%20args%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void RecycleElement( global::Microsoft.UI.Xaml.ElementFactoryRecycleArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.DataTemplate", "void DataTemplate.RecycleElement(ElementFactoryRecycleArgs args)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.DataTemplate.ExtensionInstanceProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.IDataTemplateExtension GetExtensionInstance( global::Microsoft.UI.Xaml.FrameworkElement element)
		{
			return (global::Microsoft.UI.Xaml.IDataTemplateExtension)element.GetValue(ExtensionInstanceProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetExtensionInstance( global::Microsoft.UI.Xaml.FrameworkElement element,  global::Microsoft.UI.Xaml.IDataTemplateExtension value)
		{
			element.SetValue(ExtensionInstanceProperty, value);
		}
		#endif
		// Processing: Microsoft.UI.Xaml.IElementFactory
	}
}