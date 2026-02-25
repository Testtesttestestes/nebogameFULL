using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E9 RID: 1769
	[Token(Token = "0x20006E9")]
	public class ToBagArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x1700080D")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0x7B1C", Offset = "0x7B1C", VA = "0x7B1C", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x7B1D", Offset = "0x7B1D", VA = "0x7B1D", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x7B1E", Offset = "0x7B1E", VA = "0x7B1E", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x7B1F", Offset = "0x7B1F", VA = "0x7B1F")]
		public ToBagArtifactContextMenuElement()
		{
		}
	}
}
