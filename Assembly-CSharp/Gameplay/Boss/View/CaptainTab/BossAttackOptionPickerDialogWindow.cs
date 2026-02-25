using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	public class BossAttackOptionPickerDialogWindow : BaseDialogWindow<BossAttackOptionPickerDialogWindow.BossAttackOptionPickerDialogWindowArgs>
	{
		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E35")]
		public override string WindowId
		{
			[Token(Token = "0x6004734")]
			[Address(RVA = "0x95CA", Offset = "0x95CA", VA = "0x95CA", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001C0 RID: 448
		// (add) Token: 0x06004735 RID: 18229 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004736 RID: 18230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C0")]
		public event Action<BossInfo.BossAttackOption.BossAttackOptionVariant> SelectedEvent
		{
			[Token(Token = "0x6004735")]
			[Address(RVA = "0x95CB", Offset = "0x95CB", VA = "0x95CB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004736")]
			[Address(RVA = "0x95CC", Offset = "0x95CC", VA = "0x95CC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06004737 RID: 18231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004738 RID: 18232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E36")]
		public BossInfo.BossAttackOption.BossAttackOptionVariant SelectedVariant
		{
			[Token(Token = "0x6004737")]
			[Address(RVA = "0x95CD", Offset = "0x95CD", VA = "0x95CD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004738")]
			[Address(RVA = "0x95CE", Offset = "0x95CE", VA = "0x95CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004739")]
		[Address(RVA = "0x95CF", Offset = "0x95CF", VA = "0x95CF", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473A")]
		[Address(RVA = "0x95D0", Offset = "0x95D0", VA = "0x95D0", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473B")]
		[Address(RVA = "0x95D1", Offset = "0x95D1", VA = "0x95D1")]
		private void ConfirmButtonClickHandler()
		{
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473C")]
		[Address(RVA = "0x95D2", Offset = "0x95D2", VA = "0x95D2")]
		private void ValuePickerOnSelectionChangedEvent(BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473D")]
		[Address(RVA = "0x95D3", Offset = "0x95D3", VA = "0x95D3", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600473E")]
		[Address(RVA = "0x95D4", Offset = "0x95D4", VA = "0x95D4")]
		public static BossAttackOptionPickerDialogWindow Show(BossInfo.BossAttackOption bossAttackOption, BossInfo.BossAttackOption.BossAttackOptionVariant initialVariant)
		{
			return null;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473F")]
		[Address(RVA = "0x95D5", Offset = "0x95D5", VA = "0x95D5")]
		public BossAttackOptionPickerDialogWindow()
		{
		}

		// Token: 0x0400270D RID: 9997
		[Token(Token = "0x400270D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossAttackOptionPickerDialogWindow";

		// Token: 0x0400270E RID: 9998
		[Token(Token = "0x400270E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BossAttackOptionValuePicker _valuePicker;

		// Token: 0x0400270F RID: 9999
		[Token(Token = "0x400270F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04002710 RID: 10000
		[Token(Token = "0x4002710")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BossAttackSkillBonusView _skillBonusView;

		// Token: 0x02000B74 RID: 2932
		[Token(Token = "0x2000B74")]
		public class BossAttackOptionPickerDialogWindowArgs : BaseDialogWindow<BossAttackOptionPickerDialogWindow.BossAttackOptionPickerDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004740 RID: 18240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004740")]
			[Address(RVA = "0x95D6", Offset = "0x95D6", VA = "0x95D6")]
			public BossAttackOptionPickerDialogWindowArgs()
			{
			}

			// Token: 0x04002713 RID: 10003
			[Token(Token = "0x4002713")]
			[FieldOffset(Offset = "0x2C")]
			public BossInfo.BossAttackOption BossAttackOption;

			// Token: 0x04002714 RID: 10004
			[Token(Token = "0x4002714")]
			[FieldOffset(Offset = "0x30")]
			public BossInfo.BossAttackOption.BossAttackOptionVariant InitialVariant;
		}
	}
}
