using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	public class ReforgeUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x17000802")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A4C")]
			[Address(RVA = "0x7AEF", Offset = "0x7AEF", VA = "0x7AEF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x7AF0", Offset = "0x7AF0", VA = "0x7AF0", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x7AF1", Offset = "0x7AF1", VA = "0x7AF1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x7AF2", Offset = "0x7AF2", VA = "0x7AF2")]
		public ReforgeUserArtifactContextMenuElement()
		{
		}
	}
}
