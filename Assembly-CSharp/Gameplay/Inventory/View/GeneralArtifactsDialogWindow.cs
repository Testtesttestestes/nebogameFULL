using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	public class GeneralArtifactsDialogWindow : BaseDialogWindow<GeneralArtifactsDialogWindow.GeneralArtifactsDialogWindowArgs>
	{
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000780")]
		public override string WindowId
		{
			[Token(Token = "0x60027A8")]
			[Address(RVA = "0x78D7", Offset = "0x78D7", VA = "0x78D7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x78D8", Offset = "0x78D8", VA = "0x78D8", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x78D9", Offset = "0x78D9", VA = "0x78D9")]
		public GeneralArtifactsDialogWindow()
		{
		}

		// Token: 0x040015B8 RID: 5560
		[Token(Token = "0x40015B8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/GeneralArtifactsDialogWindow";

		// Token: 0x040015B9 RID: 5561
		[Token(Token = "0x40015B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x02000661 RID: 1633
		[Token(Token = "0x2000661")]
		public class GeneralArtifactsDialogWindowArgs : BaseDialogWindow<GeneralArtifactsDialogWindow.GeneralArtifactsDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060027AB RID: 10155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027AB")]
			[Address(RVA = "0x78DA", Offset = "0x78DA", VA = "0x78DA")]
			public GeneralArtifactsDialogWindowArgs(UserData user, params ArtifactData[] artifacts)
			{
			}

			// Token: 0x040015BA RID: 5562
			[Token(Token = "0x40015BA")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x040015BB RID: 5563
			[Token(Token = "0x40015BB")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}
}
