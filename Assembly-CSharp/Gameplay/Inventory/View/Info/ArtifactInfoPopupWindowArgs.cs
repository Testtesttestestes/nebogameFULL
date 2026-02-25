using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x02000669 RID: 1641
	[Token(Token = "0x2000669")]
	public class ArtifactInfoPopupWindowArgs : BaseWindowArgs
	{
		// Token: 0x060027E2 RID: 10210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x7908", Offset = "0x7908", VA = "0x7908")]
		public ArtifactInfoPopupWindowArgs()
		{
		}

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x18")]
		public IArtifactView ArtifactView;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x1C")]
		public UserData User;
	}
}
