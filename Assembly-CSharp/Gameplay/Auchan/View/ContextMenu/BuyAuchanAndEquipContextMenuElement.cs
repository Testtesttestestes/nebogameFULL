using System;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Auchan.View.ContextMenu
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x2000C91")]
	public class BuyAuchanAndEquipContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06004E5B RID: 20059 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x17000FDD")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6004E5B")]
			[Address(RVA = "0x9C8D", Offset = "0x9C8D", VA = "0x9C8D", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x6004E5C")]
		[Address(RVA = "0x9C8E", Offset = "0x9C8E", VA = "0x9C8E", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x9C8F", Offset = "0x9C8F", VA = "0x9C8F", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x9C90", Offset = "0x9C90", VA = "0x9C90")]
		public BuyAuchanAndEquipContextMenuElement()
		{
		}
	}
}
