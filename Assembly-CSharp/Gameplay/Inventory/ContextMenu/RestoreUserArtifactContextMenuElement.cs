using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	public class RestoreUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x17000805")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A58")]
			[Address(RVA = "0x7AFB", Offset = "0x7AFB", VA = "0x7AFB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x7AFC", Offset = "0x7AFC", VA = "0x7AFC", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x7AFD", Offset = "0x7AFD", VA = "0x7AFD", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x7AFE", Offset = "0x7AFE", VA = "0x7AFE")]
		public RestoreUserArtifactContextMenuElement()
		{
		}
	}
}
