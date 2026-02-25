using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006F7 RID: 1783
	[Token(Token = "0x20006F7")]
	public class ConfirmRepairUserArtifactWindow : BaseDialogWindow<ConfirmRepairUserArtifactWindow.RepairUserArtifactWindowArgs>
	{
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000819")]
		public override string WindowId
		{
			[Token(Token = "0x6002AB3")]
			[Address(RVA = "0x7B4E", Offset = "0x7B4E", VA = "0x7B4E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x7B4F", Offset = "0x7B4F", VA = "0x7B4F")]
		public static ConfirmRepairUserArtifactWindow Show(UserData user, Action<ArtifactData[]> resultCallback, params ArtifactData[] artifacts)
		{
			return null;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x7B50", Offset = "0x7B50", VA = "0x7B50", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x7B51", Offset = "0x7B51", VA = "0x7B51")]
		public ConfirmRepairUserArtifactWindow()
		{
		}

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Horde/ConfirmRepairUserArtifactWindow";

		// Token: 0x04001750 RID: 5968
		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x020006F8 RID: 1784
		[Token(Token = "0x20006F8")]
		public class RepairUserArtifactWindowArgs : BaseDialogWindow<ConfirmRepairUserArtifactWindow.RepairUserArtifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002AB7 RID: 10935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AB7")]
			[Address(RVA = "0x7B52", Offset = "0x7B52", VA = "0x7B52")]
			public RepairUserArtifactWindowArgs(ArtifactData[] artifacts, UserData user)
			{
			}

			// Token: 0x04001751 RID: 5969
			[Token(Token = "0x4001751")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x04001752 RID: 5970
			[Token(Token = "0x4001752")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}
}
