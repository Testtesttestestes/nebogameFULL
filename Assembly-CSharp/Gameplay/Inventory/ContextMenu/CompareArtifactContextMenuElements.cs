using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006CA RID: 1738
	[Token(Token = "0x20006CA")]
	public class CompareArtifactContextMenuElements : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x170007EF")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A01")]
			[Address(RVA = "0x7AA4", Offset = "0x7AA4", VA = "0x7AA4", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x7AA5", Offset = "0x7AA5", VA = "0x7AA5", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x7AA6", Offset = "0x7AA6", VA = "0x7AA6", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x7AA7", Offset = "0x7AA7", VA = "0x7AA7")]
		public CompareArtifactContextMenuElements()
		{
		}
	}
}
