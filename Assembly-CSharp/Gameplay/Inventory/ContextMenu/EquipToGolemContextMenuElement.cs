using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D4 RID: 1748
	[Token(Token = "0x20006D4")]
	internal class EquipToGolemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x170007F8")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A28")]
			[Address(RVA = "0x7ACB", Offset = "0x7ACB", VA = "0x7ACB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x7ACC", Offset = "0x7ACC", VA = "0x7ACC", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x7ACD", Offset = "0x7ACD", VA = "0x7ACD", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x7ACE", Offset = "0x7ACE", VA = "0x7ACE")]
		public EquipToGolemContextMenuElement()
		{
		}
	}
}
