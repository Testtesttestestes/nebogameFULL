using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	public class InventoryChestWindowOptions : BaseWindowArgs
	{
		// Token: 0x06002866 RID: 10342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002866")]
		[Address(RVA = "0x7986", Offset = "0x7986", VA = "0x7986")]
		public InventoryChestWindowOptions()
		{
		}

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x18")]
		public ArtikulMenuActionDic.Types.Actions[] CustomActions;

		// Token: 0x04001649 RID: 5705
		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x1C")]
		public ArtikulMenuActionDic.Types.Actions[] CloseWindowActions;

		// Token: 0x0400164A RID: 5706
		[Token(Token = "0x400164A")]
		[FieldOffset(Offset = "0x20")]
		public InventoryChestWindowOptions.ArtifactFilterDelegate CustomFilterFunction;

		// Token: 0x02000686 RID: 1670
		// (Invoke) Token: 0x06002868 RID: 10344
		[Token(Token = "0x2000686")]
		public delegate bool ArtifactFilterDelegate(ArtifactData artifactData);
	}
}
