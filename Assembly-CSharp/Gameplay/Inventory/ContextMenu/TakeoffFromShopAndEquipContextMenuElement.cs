using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E7 RID: 1767
	[Token(Token = "0x20006E7")]
	public class TakeoffFromShopAndEquipContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x1700080B")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A71")]
			[Address(RVA = "0x7B14", Offset = "0x7B14", VA = "0x7B14", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x7B15", Offset = "0x7B15", VA = "0x7B15", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x7B16", Offset = "0x7B16", VA = "0x7B16", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x7B17", Offset = "0x7B17", VA = "0x7B17")]
		public TakeoffFromShopAndEquipContextMenuElement()
		{
		}
	}
}
