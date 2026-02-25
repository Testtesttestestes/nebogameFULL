using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Gifts.Model;
using Il2CppDummyDll;

namespace Gameplay.Gifts.GdEvents.Model
{
	// Token: 0x02000713 RID: 1811
	[Token(Token = "0x2000713")]
	public class GiftModel : GiftsModel
	{
		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B59 RID: 11097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000847")]
		public IUserCache UserChache
		{
			[Token(Token = "0x6002B58")]
			[Address(RVA = "0x7BF2", Offset = "0x7BF2", VA = "0x7BF2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B59")]
			[Address(RVA = "0x7BF3", Offset = "0x7BF3", VA = "0x7BF3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x7BF4", Offset = "0x7BF4", VA = "0x7BF4", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x7BF5", Offset = "0x7BF5", VA = "0x7BF5")]
		public GiftModel(IGame game, IDictProvider dictProvider, IUserCache userCache, int usersLimit, UserData user)
		{
		}

		// Token: 0x040017C1 RID: 6081
		[Token(Token = "0x40017C1")]
		[FieldOffset(Offset = "0x20")]
		public readonly int UsersLimit;
	}
}
