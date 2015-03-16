﻿using System;

namespace Hover.Common.Items.Types {

	/*================================================================================================*/
	interface ISliderItem : ISelectableItem<float> {

		int Ticks { get; set; }
		int Snaps { get; set; }
		float RangeMin { get; set; }
		float RangeMax { get; set; }
		Func<SliderItem, string> ValueToLabel { get; set; }
		bool AllowJump { get; set; }

		float SnappedValue { get; }
		float? HoverValue { get; set; }
		float? HoverSnappedValue { get; }
		float RangeValue { get; }
		float RangeSnappedValue { get; }

	}

}
