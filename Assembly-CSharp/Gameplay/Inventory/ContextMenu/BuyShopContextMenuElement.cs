using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x20006C9")]
	public class BuyShopContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x170007EE")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60029FD")]
			[Address(RVA = "0x7AA0", Offset = "0x7AA0", VA = "0x7AA0", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x7AA1", Offset = "0x7AA1", VA = "0x7AA1", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x7AA2", Offset = "0x7AA2", VA = "0x7AA2", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x7AA3", Offset = "0x7AA3", VA = "0x7AA3")]
		public BuyShopContextMenuElement()
		{
		}
	}
}
