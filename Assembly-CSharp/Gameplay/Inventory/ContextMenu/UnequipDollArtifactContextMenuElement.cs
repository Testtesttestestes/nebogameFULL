using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x20006EE")]
	public class UnequipDollArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x17000812")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A8D")]
			[Address(RVA = "0x7B30", Offset = "0x7B30", VA = "0x7B30", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x7B31", Offset = "0x7B31", VA = "0x7B31", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x7B32", Offset = "0x7B32", VA = "0x7B32", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x7B33", Offset = "0x7B33", VA = "0x7B33")]
		public UnequipDollArtifactContextMenuElement()
		{
		}
	}
}
