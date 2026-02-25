using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006C8 RID: 1736
	[Token(Token = "0x20006C8")]
	public class BuyShopAndEquipContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x170007ED")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60029F9")]
			[Address(RVA = "0x7A9C", Offset = "0x7A9C", VA = "0x7A9C", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x7A9D", Offset = "0x7A9D", VA = "0x7A9D", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x7A9E", Offset = "0x7A9E", VA = "0x7A9E", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x7A9F", Offset = "0x7A9F", VA = "0x7A9F")]
		public BuyShopAndEquipContextMenuElement()
		{
		}
	}
}
