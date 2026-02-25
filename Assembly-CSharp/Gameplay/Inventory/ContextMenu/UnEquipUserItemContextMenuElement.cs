using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006ED RID: 1773
	[Token(Token = "0x20006ED")]
	public class UnEquipUserItemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x17000811")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A89")]
			[Address(RVA = "0x7B2C", Offset = "0x7B2C", VA = "0x7B2C", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x7B2D", Offset = "0x7B2D", VA = "0x7B2D", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x7B2E", Offset = "0x7B2E", VA = "0x7B2E", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x7B2F", Offset = "0x7B2F", VA = "0x7B2F")]
		public UnEquipUserItemContextMenuElement()
		{
		}
	}
}
