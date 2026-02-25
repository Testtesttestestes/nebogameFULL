using System;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Portals.View.ContextMenu
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	public class BuyPortalsContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x1700069F")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002386")]
			[Address(RVA = "0x74D8", Offset = "0x74D8", VA = "0x74D8", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x74D9", Offset = "0x74D9", VA = "0x74D9", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x74DA", Offset = "0x74DA", VA = "0x74DA", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x74DB", Offset = "0x74DB", VA = "0x74DB")]
		public BuyPortalsContextMenuElement()
		{
		}
	}
}
