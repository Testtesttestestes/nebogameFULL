using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Duel.View
{
	// Token: 0x02000854 RID: 2132
	[Token(Token = "0x2000854")]
	public class AttackDeclinedDialogWindow : BaseDialogWindow<AttackDeclinedDialogWindow.AttackDeclinedDialogWindowArgs>
	{
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E4")]
		public override string WindowId
		{
			[Token(Token = "0x600322B")]
			[Address(RVA = "0x8281", Offset = "0x8281", VA = "0x8281", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x8282", Offset = "0x8282", VA = "0x8282", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x8283", Offset = "0x8283", VA = "0x8283")]
		public static AttackDeclinedDialogWindow Show(DuelUserStateFlags[] stateFlags)
		{
			return null;
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600322E")]
		[Address(RVA = "0x8284", Offset = "0x8284", VA = "0x8284")]
		public AttackDeclinedDialogWindow()
		{
		}

		// Token: 0x04001B69 RID: 7017
		[Token(Token = "0x4001B69")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Duel/AttackDeclinedDialogWindow";

		// Token: 0x04001B6A RID: 7018
		[Token(Token = "0x4001B6A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LoaderValueRowView _rowPrefab;

		// Token: 0x02000855 RID: 2133
		[Token(Token = "0x2000855")]
		public class AttackDeclinedDialogWindowArgs : BaseDialogWindow<AttackDeclinedDialogWindow.AttackDeclinedDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x0600322F RID: 12847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600322F")]
			[Address(RVA = "0x8285", Offset = "0x8285", VA = "0x8285")]
			public AttackDeclinedDialogWindowArgs(DuelUserStateFlags[] stateFlags)
			{
			}

			// Token: 0x06003230 RID: 12848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003230")]
			[Address(RVA = "0x8286", Offset = "0x8286", VA = "0x8286")]
			private void InitInstance()
			{
			}

			// Token: 0x04001B6B RID: 7019
			[Token(Token = "0x4001B6B")]
			[FieldOffset(Offset = "0x2C")]
			public readonly DuelUserStateFlags[] StateFlags;
		}
	}
}
