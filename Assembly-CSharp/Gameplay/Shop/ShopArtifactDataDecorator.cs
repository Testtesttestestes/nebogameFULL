using System;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Shop;

namespace Gameplay.Shop
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	public class ShopArtifactDataDecorator : ArtifactData
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E9")]
		public new ResourceSet Price
		{
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x71CE", Offset = "0x71CE", VA = "0x71CE")]
			get
			{
				return null;
			}
			[Token(Token = "0x600206A")]
			[Address(RVA = "0x71CF", Offset = "0x71CF", VA = "0x71CF")]
			set
			{
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206B")]
		[Address(RVA = "0x71D0", Offset = "0x71D0", VA = "0x71D0")]
		public ShopArtifactDataDecorator(ArtifactData artifact, UserArtifactWithPrice artifactWhitPrice, IDictProvider dictProvider)
		{
		}

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x94")]
		private ResourceSet _price;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x98")]
		public readonly ArtifactData Artifact;
	}
}
