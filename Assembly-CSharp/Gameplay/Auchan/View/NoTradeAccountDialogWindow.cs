using System;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C8E RID: 3214
	[Token(Token = "0x2000C8E")]
	public class NoTradeAccountDialogWindow : BaseDialogWindow<NoTradeAccountDialogWindow.NoTradeAccountDialogWindowArgs>
	{
		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FDC")]
		public override string WindowId
		{
			[Token(Token = "0x6004E54")]
			[Address(RVA = "0x9C86", Offset = "0x9C86", VA = "0x9C86", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x9C87", Offset = "0x9C87", VA = "0x9C87")]
		public static NoTradeAccountDialogWindow Show(UserData user, AccountsManager accountsManager, params ArtifactData[] artifacts)
		{
			return null;
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x9C88", Offset = "0x9C88", VA = "0x9C88", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x9C89", Offset = "0x9C89", VA = "0x9C89")]
		public NoTradeAccountDialogWindow()
		{
		}

		// Token: 0x04002ACF RID: 10959
		[Token(Token = "0x4002ACF")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Auchan/NoTradeAccountDialogWindow";

		// Token: 0x04002AD0 RID: 10960
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x02000C8F RID: 3215
		[Token(Token = "0x2000C8F")]
		public class NoTradeAccountDialogWindowArgs : BaseDialogWindow<NoTradeAccountDialogWindow.NoTradeAccountDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004E58 RID: 20056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E58")]
			[Address(RVA = "0x9C8A", Offset = "0x9C8A", VA = "0x9C8A")]
			public NoTradeAccountDialogWindowArgs(ArtifactData[] artifacts, UserData user)
			{
			}

			// Token: 0x04002AD1 RID: 10961
			[Token(Token = "0x4002AD1")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x04002AD2 RID: 10962
			[Token(Token = "0x4002AD2")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}
}
