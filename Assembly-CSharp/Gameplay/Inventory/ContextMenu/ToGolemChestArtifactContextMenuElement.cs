using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EC RID: 1772
	[Token(Token = "0x20006EC")]
	public class ToGolemChestArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x17000810")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A85")]
			[Address(RVA = "0x7B28", Offset = "0x7B28", VA = "0x7B28", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x7B29", Offset = "0x7B29", VA = "0x7B29", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x7B2A", Offset = "0x7B2A", VA = "0x7B2A", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x7B2B", Offset = "0x7B2B", VA = "0x7B2B")]
		public ToGolemChestArtifactContextMenuElement()
		{
		}
	}
}
