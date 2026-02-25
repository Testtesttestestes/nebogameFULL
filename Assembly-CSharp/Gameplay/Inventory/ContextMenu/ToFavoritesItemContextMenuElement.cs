using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	public class ToFavoritesItemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x1700080F")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A81")]
			[Address(RVA = "0x7B24", Offset = "0x7B24", VA = "0x7B24", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x7B25", Offset = "0x7B25", VA = "0x7B25", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x7B26", Offset = "0x7B26", VA = "0x7B26", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x7B27", Offset = "0x7B27", VA = "0x7B27")]
		public ToFavoritesItemContextMenuElement()
		{
		}
	}
}
