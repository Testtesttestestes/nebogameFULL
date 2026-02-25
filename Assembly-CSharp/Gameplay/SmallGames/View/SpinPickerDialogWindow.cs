using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	public class SpinPickerDialogWindow : BaseDialogWindow<SpinPickerDialogWindow.SpinPickerDialogWindowArgs>
	{
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BB")]
		public override string WindowId
		{
			[Token(Token = "0x6001F60")]
			[Address(RVA = "0x70C6", Offset = "0x70C6", VA = "0x70C6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00006648 File Offset: 0x00004848
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BC")]
		public uint SelectedAttemptsNum
		{
			[Token(Token = "0x6001F61")]
			[Address(RVA = "0x70C7", Offset = "0x70C7", VA = "0x70C7")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F62")]
			[Address(RVA = "0x70C8", Offset = "0x70C8", VA = "0x70C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400013A RID: 314
		// (add) Token: 0x06001F63 RID: 8035 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F64 RID: 8036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013A")]
		public event Action<uint> SelectedEvent
		{
			[Token(Token = "0x6001F63")]
			[Address(RVA = "0x70C9", Offset = "0x70C9", VA = "0x70C9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F64")]
			[Address(RVA = "0x70CA", Offset = "0x70CA", VA = "0x70CA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x70CB", Offset = "0x70CB", VA = "0x70CB", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x70CC", Offset = "0x70CC", VA = "0x70CC", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x70CD", Offset = "0x70CD", VA = "0x70CD")]
		private void ConfirmButtonClickHandler()
		{
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x70CE", Offset = "0x70CE", VA = "0x70CE")]
		private void SpinValuePickerOnSelectionChangedEvent(uint attemptsNum)
		{
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x70CF", Offset = "0x70CF", VA = "0x70CF", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x70D0", Offset = "0x70D0", VA = "0x70D0")]
		public static SpinPickerDialogWindow Show(SpinPickerDialogWindow.SpinPickerDialogWindowArgs args)
		{
			return null;
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x70D1", Offset = "0x70D1", VA = "0x70D1")]
		public SpinPickerDialogWindow()
		{
		}

		// Token: 0x04001115 RID: 4373
		[Token(Token = "0x4001115")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/SpinPickerDialogWindow";

		// Token: 0x04001116 RID: 4374
		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpinValuePicker _spinValuePicker;

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x02000526 RID: 1318
		[Token(Token = "0x2000526")]
		public class SpinPickerDialogWindowArgs : BaseDialogWindow<SpinPickerDialogWindow.SpinPickerDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06001F6C RID: 8044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F6C")]
			[Address(RVA = "0x70D2", Offset = "0x70D2", VA = "0x70D2")]
			public SpinPickerDialogWindowArgs(uint startValue, uint[] values, Money price, UserData user)
			{
			}

			// Token: 0x0400111A RID: 4378
			[Token(Token = "0x400111A")]
			[FieldOffset(Offset = "0x2C")]
			public readonly Money Price;

			// Token: 0x0400111B RID: 4379
			[Token(Token = "0x400111B")]
			[FieldOffset(Offset = "0x30")]
			public readonly UserData User;

			// Token: 0x0400111C RID: 4380
			[Token(Token = "0x400111C")]
			[FieldOffset(Offset = "0x34")]
			public readonly uint StartValue;

			// Token: 0x0400111D RID: 4381
			[Token(Token = "0x400111D")]
			[FieldOffset(Offset = "0x38")]
			public readonly uint[] Values;
		}
	}
}
