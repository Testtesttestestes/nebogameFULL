using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E5 RID: 1765
	[Token(Token = "0x20006E5")]
	public class TakeFromDropItemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x17000809")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A69")]
			[Address(RVA = "0x7B0C", Offset = "0x7B0C", VA = "0x7B0C", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x7B0D", Offset = "0x7B0D", VA = "0x7B0D", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x7B0E", Offset = "0x7B0E", VA = "0x7B0E", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x7B0F", Offset = "0x7B0F", VA = "0x7B0F")]
		public TakeFromDropItemContextMenuElement()
		{
		}
	}
}
