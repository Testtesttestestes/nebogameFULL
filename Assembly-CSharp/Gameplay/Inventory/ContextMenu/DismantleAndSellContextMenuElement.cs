using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006CD RID: 1741
	[Token(Token = "0x20006CD")]
	public class DismantleAndSellContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x170007F2")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A0D")]
			[Address(RVA = "0x7AB0", Offset = "0x7AB0", VA = "0x7AB0", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x7AB1", Offset = "0x7AB1", VA = "0x7AB1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x7AB2", Offset = "0x7AB2", VA = "0x7AB2", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x7AB3", Offset = "0x7AB3", VA = "0x7AB3")]
		public DismantleAndSellContextMenuElement()
		{
		}
	}
}
