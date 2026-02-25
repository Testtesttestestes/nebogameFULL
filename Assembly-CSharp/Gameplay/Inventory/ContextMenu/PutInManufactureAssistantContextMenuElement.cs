using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DB RID: 1755
	[Token(Token = "0x20006DB")]
	public class PutInManufactureAssistantContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x170007FF")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A42")]
			[Address(RVA = "0x7AE5", Offset = "0x7AE5", VA = "0x7AE5", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x7AE6", Offset = "0x7AE6", VA = "0x7AE6", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x7AE7", Offset = "0x7AE7", VA = "0x7AE7", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x7AE8", Offset = "0x7AE8", VA = "0x7AE8")]
		public PutInManufactureAssistantContextMenuElement()
		{
		}
	}
}
