using System;
using System.Runtime.CompilerServices;
using Gameplay.Inventory.View.Info.InfoBox;
using Gameplay.SmallGames.View;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B5 RID: 2229
	[Token(Token = "0x20008B5")]
	public class CraftSpinPickerDialogWindow : BaseDialogWindow<CraftSpinPickerDialogWindow.CraftSpinPickerDialogWindowArgs>
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A62")]
		public override string WindowId
		{
			[Token(Token = "0x600345D")]
			[Address(RVA = "0x8487", Offset = "0x8487", VA = "0x8487", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x0000AA58 File Offset: 0x00008C58
		// (set) Token: 0x0600345F RID: 13407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A63")]
		public uint SelectedAttemptsNum
		{
			[Token(Token = "0x600345E")]
			[Address(RVA = "0x8488", Offset = "0x8488", VA = "0x8488")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600345F")]
			[Address(RVA = "0x8489", Offset = "0x8489", VA = "0x8489")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000170 RID: 368
		// (add) Token: 0x06003460 RID: 13408 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003461 RID: 13409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000170")]
		public event Action<uint> SelectedEvent
		{
			[Token(Token = "0x6003460")]
			[Address(RVA = "0x848A", Offset = "0x848A", VA = "0x848A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003461")]
			[Address(RVA = "0x848B", Offset = "0x848B", VA = "0x848B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x848C", Offset = "0x848C", VA = "0x848C", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x848D", Offset = "0x848D", VA = "0x848D", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x848E", Offset = "0x848E", VA = "0x848E")]
		private void ConfirmButtonClickedEventHandler()
		{
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x848F", Offset = "0x848F", VA = "0x848F")]
		private void SpinValuePickerOnSelectionChangedEvent(uint attemptsNum)
		{
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003466")]
		[Address(RVA = "0x8490", Offset = "0x8490", VA = "0x8490", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003467")]
		[Address(RVA = "0x8491", Offset = "0x8491", VA = "0x8491")]
		public static CraftSpinPickerDialogWindow Show(int maxQuantity, int maxEnoughQuantity)
		{
			return null;
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003468")]
		[Address(RVA = "0x8492", Offset = "0x8492", VA = "0x8492")]
		public CraftSpinPickerDialogWindow()
		{
		}

		// Token: 0x04001C99 RID: 7321
		[Token(Token = "0x4001C99")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/SpinPickerDialogWindow";

		// Token: 0x04001C9A RID: 7322
		[Token(Token = "0x4001C9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpinValuePicker _spinValuePicker;

		// Token: 0x04001C9B RID: 7323
		[Token(Token = "0x4001C9B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ButtonWithCost _confirmButton;

		// Token: 0x04001C9C RID: 7324
		[Token(Token = "0x4001C9C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LoaderValueRowView _valueRow;

		// Token: 0x020008B6 RID: 2230
		[Token(Token = "0x20008B6")]
		public class CraftSpinPickerDialogWindowArgs : BaseDialogWindow<CraftSpinPickerDialogWindow.CraftSpinPickerDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06003469 RID: 13417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003469")]
			[Address(RVA = "0x8493", Offset = "0x8493", VA = "0x8493")]
			public CraftSpinPickerDialogWindowArgs()
			{
			}

			// Token: 0x04001C9F RID: 7327
			[Token(Token = "0x4001C9F")]
			[FieldOffset(Offset = "0x2C")]
			public int MaxQuantity;

			// Token: 0x04001CA0 RID: 7328
			[Token(Token = "0x4001CA0")]
			[FieldOffset(Offset = "0x30")]
			public int MaxEnoughQuantity;
		}
	}
}
