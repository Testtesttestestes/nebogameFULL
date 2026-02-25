using System;
using Core.Data;
using Gameplay.Discounts.View;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using Utils;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000687 RID: 1671
	[Token(Token = "0x2000687")]
	public class InventoryConfirmBuySlotWindow : BaseDialogWindow<InventoryConfirmBuySlotWindow.InventoryConfirmBuySlotWindowArgs>
	{
		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AB")]
		public override string WindowId
		{
			[Token(Token = "0x600286B")]
			[Address(RVA = "0x798B", Offset = "0x798B", VA = "0x798B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x798C", Offset = "0x798C", VA = "0x798C", Slot = "25")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x798D", Offset = "0x798D", VA = "0x798D", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x798E", Offset = "0x798E", VA = "0x798E")]
		public static OpToken<int, int> Show(uint quantity, InvetoryScope scope)
		{
			return null;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x798F", Offset = "0x798F", VA = "0x798F")]
		public static OpToken<int, int> ShowForGolem(uint quantity, InvetoryScope scope)
		{
			return null;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x7990", Offset = "0x7990", VA = "0x7990")]
		public InventoryConfirmBuySlotWindow()
		{
		}

		// Token: 0x0400164B RID: 5707
		[Token(Token = "0x400164B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/InventoryConfirmBuySlotWindow";

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x02000688 RID: 1672
		[Token(Token = "0x2000688")]
		public class InventoryConfirmBuySlotWindowArgs : BaseDialogWindow<InventoryConfirmBuySlotWindow.InventoryConfirmBuySlotWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002871 RID: 10353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002871")]
			[Address(RVA = "0x7991", Offset = "0x7991", VA = "0x7991")]
			public InventoryConfirmBuySlotWindowArgs()
			{
			}

			// Token: 0x0400164D RID: 5709
			[Token(Token = "0x400164D")]
			[FieldOffset(Offset = "0x2C")]
			public OpToken<int, int> OpToken;

			// Token: 0x0400164E RID: 5710
			[Token(Token = "0x400164E")]
			[FieldOffset(Offset = "0x30")]
			public DiscountData DiscountData;
		}
	}
}
