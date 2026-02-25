using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Isles.User.Model
{
	// Token: 0x02000D2B RID: 3371
	[Token(Token = "0x2000D2B")]
	public class UserIsleAccountMarkerData
	{
		// Token: 0x06005265 RID: 21093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005265")]
		[Address(RVA = "0xA03C", Offset = "0xA03C", VA = "0xA03C")]
		private UserIsleAccountMarkerData(IAccountDataDecorator account)
		{
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06005266 RID: 21094 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005267 RID: 21095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C5")]
		public IAccountDataDecorator Account
		{
			[Token(Token = "0x6005266")]
			[Address(RVA = "0xA03D", Offset = "0xA03D", VA = "0xA03D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005267")]
			[Address(RVA = "0xA03E", Offset = "0xA03E", VA = "0xA03E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06005268 RID: 21096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005269 RID: 21097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C6")]
		public Point Position
		{
			[Token(Token = "0x6005268")]
			[Address(RVA = "0xA03F", Offset = "0xA03F", VA = "0xA03F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005269")]
			[Address(RVA = "0xA040", Offset = "0xA040", VA = "0xA040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600526A")]
		[Address(RVA = "0xA041", Offset = "0xA041", VA = "0xA041")]
		public static UserIsleAccountMarkerData Create(UserIsleModel model, IAccountDataDecorator account)
		{
			return null;
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600526B")]
		[Address(RVA = "0xA042", Offset = "0xA042", VA = "0xA042")]
		public static List<UserIsleAccountMarkerData> Create(UserIsleModel model)
		{
			return null;
		}
	}
}
