using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000ABE RID: 2750
	[Token(Token = "0x2000ABE")]
	public class ConfirmSellGolemArtifactWindow : ConfirmSellUserArtifactWindow
	{
		// Token: 0x06004262 RID: 16994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004262")]
		[Address(RVA = "0x9116", Offset = "0x9116", VA = "0x9116")]
		public new static ConfirmSellGolemArtifactWindow Show(UserData user, Action<ArtifactData[]> resultCallback, params ArtifactData[] artifacts)
		{
			return null;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004263")]
		[Address(RVA = "0x9117", Offset = "0x9117", VA = "0x9117")]
		public ConfirmSellGolemArtifactWindow()
		{
		}

		// Token: 0x0400249A RID: 9370
		[Token(Token = "0x400249A")]
		public new const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/ConfirmSellGolemArtifactWindow";

		// Token: 0x02000ABF RID: 2751
		[Token(Token = "0x2000ABF")]
		public class SellGolemArtifactWindowArgs : ConfirmSellUserArtifactWindow.SellUserArtifactWindowArgs
		{
			// Token: 0x06004264 RID: 16996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004264")]
			[Address(RVA = "0x9118", Offset = "0x9118", VA = "0x9118")]
			public SellGolemArtifactWindowArgs(ArtifactData[] artifacts, UserData user)
			{
			}

			// Token: 0x06004265 RID: 16997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004265")]
			[Address(RVA = "0x9119", Offset = "0x9119", VA = "0x9119", Slot = "6")]
			protected override void DefineTitle()
			{
			}

			// Token: 0x06004266 RID: 16998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004266")]
			[Address(RVA = "0x911A", Offset = "0x911A", VA = "0x911A", Slot = "7")]
			protected override void DetermineNonZeroDescription()
			{
			}
		}
	}
}
