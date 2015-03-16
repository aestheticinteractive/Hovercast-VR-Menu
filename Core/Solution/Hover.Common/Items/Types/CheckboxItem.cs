﻿namespace Hover.Common.Items.Types {

	/*================================================================================================*/
	public class CheckboxItem : SelectableItem<bool>, ICheckboxItem {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public override void Select() {
			Value = !Value;
			base.Select();
		}

	}

}
