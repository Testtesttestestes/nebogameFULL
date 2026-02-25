using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	public class TakeoffFromShopContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x1700080C")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A75")]
			[Address(RVA = "0x7B18", Offset = "0x7B18", VA = "0x7B18", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x7B19", Offset = "0x7B19", VA = "0x7B19", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x7B1A", Offset = "0x7B1A", VA = "0x7B1A", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x7B1B", Offset = "0x7B1B", VA = "0x7B1B")]
		public TakeoffFromShopContextMenuElement()
		{
		}
	}
}
