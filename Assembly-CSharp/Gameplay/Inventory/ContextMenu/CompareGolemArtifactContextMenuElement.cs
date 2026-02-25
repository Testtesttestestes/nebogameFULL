using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006CB RID: 1739
	[Token(Token = "0x20006CB")]
	public class CompareGolemArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x170007F0")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A05")]
			[Address(RVA = "0x7AA8", Offset = "0x7AA8", VA = "0x7AA8", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x7AA9", Offset = "0x7AA9", VA = "0x7AA9", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A07")]
		[Address(RVA = "0x7AAA", Offset = "0x7AAA", VA = "0x7AAA", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x7AAB", Offset = "0x7AAB", VA = "0x7AAB")]
		public CompareGolemArtifactContextMenuElement()
		{
		}
	}
}
