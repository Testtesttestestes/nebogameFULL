using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Main;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	public class ForgotArtifactWindow : BaseDialogWindow<ForgotArtifactWindow.ForgotItemsWindowArgs>
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022D")]
		public override string WindowId
		{
			[Token(Token = "0x6000F89")]
			[Address(RVA = "0x61B2", Offset = "0x61B2", VA = "0x61B2", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x61B3", Offset = "0x61B3", VA = "0x61B3")]
		public static ForgotArtifactWindow Show(DropTypes dropType, ArtifactData[] artifacts)
		{
			return null;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x61B4", Offset = "0x61B4", VA = "0x61B4")]
		public static ForgotArtifactWindow Show(ArtifactData[] artifacts, Action targetCallback)
		{
			return null;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x61B5", Offset = "0x61B5", VA = "0x61B5", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x61B6", Offset = "0x61B6", VA = "0x61B6")]
		public ForgotArtifactWindow()
		{
		}

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ForgotArtifactWindow";

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		public const int MAX_DISPLAYED_IN_DIALOG_ARTIFACTS_COUNT = 4;

		// Token: 0x02000295 RID: 661
		[Token(Token = "0x2000295")]
		public class ForgotItemsWindowArgs : BaseDialogWindow<ForgotArtifactWindow.ForgotItemsWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x61B7", Offset = "0x61B7", VA = "0x61B7")]
			public ForgotItemsWindowArgs(ArtifactData[] artifacts)
			{
			}

			// Token: 0x040007E6 RID: 2022
			[Token(Token = "0x40007E6")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;
		}
	}
}
