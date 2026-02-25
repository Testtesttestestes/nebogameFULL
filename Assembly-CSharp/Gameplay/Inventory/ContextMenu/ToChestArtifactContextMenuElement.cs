using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EA RID: 1770
	[Token(Token = "0x20006EA")]
	public class ToChestArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x1700080E")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A7D")]
			[Address(RVA = "0x7B20", Offset = "0x7B20", VA = "0x7B20", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x7B21", Offset = "0x7B21", VA = "0x7B21", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x7B22", Offset = "0x7B22", VA = "0x7B22", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x7B23", Offset = "0x7B23", VA = "0x7B23")]
		public ToChestArtifactContextMenuElement()
		{
		}
	}
}
