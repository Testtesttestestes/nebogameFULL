using System;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Auchan.View.ContextMenu
{
	// Token: 0x02000C92 RID: 3218
	[Token(Token = "0x2000C92")]
	public class BuyAuchanContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06004E5F RID: 20063 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x17000FDE")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6004E5F")]
			[Address(RVA = "0x9C91", Offset = "0x9C91", VA = "0x9C91", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x6004E60")]
		[Address(RVA = "0x9C92", Offset = "0x9C92", VA = "0x9C92", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E61")]
		[Address(RVA = "0x9C93", Offset = "0x9C93", VA = "0x9C93", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E62")]
		[Address(RVA = "0x9C94", Offset = "0x9C94", VA = "0x9C94")]
		public BuyAuchanContextMenuElement()
		{
		}
	}
}
