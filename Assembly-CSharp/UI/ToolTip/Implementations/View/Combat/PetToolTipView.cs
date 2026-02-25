using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	public class PetToolTipView : BaseToolTip<PetData>
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x5D4D", Offset = "0x5D4D", VA = "0x5D4D", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x5D4E", Offset = "0x5D4E", VA = "0x5D4E")]
		public PetToolTipView()
		{
		}

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/PetToolTipView";

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _descriptionTitle;
	}
}
