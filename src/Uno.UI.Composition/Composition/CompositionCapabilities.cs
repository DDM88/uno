﻿#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace Windows.UI.Composition
{
	public partial class CompositionCapabilities
	{
		private Compositor? _compositor;

		internal CompositionCapabilities(Compositor? compositor) => _compositor = compositor;

		public static CompositionCapabilities GetForCurrentView() => new CompositionCapabilities(Compositor.Current);

		public partial bool AreEffectsSupported();

		public partial bool AreEffectsFast();

		public TypedEventHandler<CompositionCapabilities, object>? Changed;
	}
}