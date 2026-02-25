using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	public class ShopItemData
	{
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006CC")]
		public ArtifactItem Item
		{
			[Token(Token = "0x60023FF")]
			[Address(RVA = "0x7550", Offset = "0x7550", VA = "0x7550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006CD")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6002400")]
			[Address(RVA = "0x7551", Offset = "0x7551", VA = "0x7551")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x7552", Offset = "0x7552", VA = "0x7552")]
		public ShopItemData(ArtifactItem item, ArtifactData artifactData)
		{
		}
	}
}
