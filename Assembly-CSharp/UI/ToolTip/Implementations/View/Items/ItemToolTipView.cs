using System;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UI.ToolTip.Implementations.View.Parts;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Items
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public class ItemToolTipView : BaseToolTip<IItemInformationProvider>
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x5D3C", Offset = "0x5D3C", VA = "0x5D3C", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x5D3D", Offset = "0x5D3D", VA = "0x5D3D", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x5D3E", Offset = "0x5D3E", VA = "0x5D3E")]
		public ItemToolTipView()
		{
		}

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ItemToolTipView";

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtikulViewWhitTitle _header;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ArtifactInformationBox _informationBox;
	}
}
