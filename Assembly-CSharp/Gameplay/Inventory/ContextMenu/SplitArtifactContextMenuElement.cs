using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E4 RID: 1764
	[Token(Token = "0x20006E4")]
	public class SplitArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x17000808")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A64")]
			[Address(RVA = "0x7B07", Offset = "0x7B07", VA = "0x7B07", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x7B08", Offset = "0x7B08", VA = "0x7B08", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x7B09", Offset = "0x7B09", VA = "0x7B09", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x7B0A", Offset = "0x7B0A", VA = "0x7B0A")]
		private void ConfirmArtifactSplitEventHandler(uint slotId, uint quantity)
		{
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x7B0B", Offset = "0x7B0B", VA = "0x7B0B")]
		public SplitArtifactContextMenuElement()
		{
		}
	}
}
