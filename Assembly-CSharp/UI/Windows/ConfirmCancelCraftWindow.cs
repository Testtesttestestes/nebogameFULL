using System;
using Core.Data;
using Gameplay.Craft.View;
using Il2CppDummyDll;
using Protocol.Craft;
using UI.Price;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	public class ConfirmCancelCraftWindow : BaseDialogWindow<ConfirmCancelCraftWindow.ConfirmCancelCraftWindowArgs>
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021F")]
		public override string WindowId
		{
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x617D", Offset = "0x617D", VA = "0x617D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x617E", Offset = "0x617E", VA = "0x617E", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x617F", Offset = "0x617F", VA = "0x617F")]
		public static ConfirmCancelCraftWindow Show(UserData user, CraftSlotListElement element, Action<uint> resultCallback)
		{
			return null;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x6180", Offset = "0x6180", VA = "0x6180")]
		public ConfirmCancelCraftWindow()
		{
		}

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/ConfirmCancelCraftWindow";

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Price _pricePrefab;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _spacerPrefab;

		// Token: 0x02000289 RID: 649
		[Token(Token = "0x2000289")]
		public class ConfirmCancelCraftWindowArgs : BaseDialogWindow<ConfirmCancelCraftWindow.ConfirmCancelCraftWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F56 RID: 3926 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x6181", Offset = "0x6181", VA = "0x6181")]
			public ConfirmCancelCraftWindowArgs(UserData user, UserCraftSlotInfo slotInfo, CraftSchemeData.CraftSchemeInfo schemeInfo)
			{
			}

			// Token: 0x06000F57 RID: 3927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F57")]
			[Address(RVA = "0x6182", Offset = "0x6182", VA = "0x6182")]
			private void InitInstance()
			{
			}

			// Token: 0x040007CA RID: 1994
			[Token(Token = "0x40007CA")]
			[FieldOffset(Offset = "0x2C")]
			public readonly UserCraftSlotInfo SlotInfo;

			// Token: 0x040007CB RID: 1995
			[Token(Token = "0x40007CB")]
			[FieldOffset(Offset = "0x30")]
			public readonly UserData User;

			// Token: 0x040007CC RID: 1996
			[Token(Token = "0x40007CC")]
			[FieldOffset(Offset = "0x34")]
			public readonly CraftSchemeData.CraftSchemeInfo SchemeInfo;
		}
	}
}
