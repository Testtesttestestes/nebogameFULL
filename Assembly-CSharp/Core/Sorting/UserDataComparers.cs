using System;
using Core.Data;
using Il2CppDummyDll;

namespace Core.Sorting
{
	// Token: 0x02000E75 RID: 3701
	[Token(Token = "0x2000E75")]
	public static class UserDataComparers
	{
		// Token: 0x06005A2A RID: 23082 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0xA734", Offset = "0xA734", VA = "0xA734")]
		private static int CompareLevel(UserData x, UserData y)
		{
			return 0;
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x00010068 File Offset: 0x0000E268
		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0xA735", Offset = "0xA735", VA = "0xA735")]
		private static int CompareNick(UserData x, UserData y)
		{
			return 0;
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0xA736", Offset = "0xA736", VA = "0xA736")]
		private static int CompareCult(UserData x, UserData y)
		{
			return 0;
		}

		// Token: 0x02000E76 RID: 3702
		[Token(Token = "0x2000E76")]
		public class ByNick : AbstractGameDataComparer<UserData>
		{
			// Token: 0x06005A2D RID: 23085 RVA: 0x00010098 File Offset: 0x0000E298
			[Token(Token = "0x6005A2D")]
			[Address(RVA = "0xA737", Offset = "0xA737", VA = "0xA737", Slot = "8")]
			public override int Compare(UserData x, UserData y)
			{
				return 0;
			}

			// Token: 0x1700125D RID: 4701
			// (get) Token: 0x06005A2E RID: 23086 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700125D")]
			public override string Title
			{
				[Token(Token = "0x6005A2E")]
				[Address(RVA = "0xA738", Offset = "0xA738", VA = "0xA738", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A2F RID: 23087 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A2F")]
			[Address(RVA = "0xA739", Offset = "0xA739", VA = "0xA739")]
			public ByNick()
			{
			}
		}

		// Token: 0x02000E77 RID: 3703
		[Token(Token = "0x2000E77")]
		public class ByLevel : AbstractGameDataComparer<UserData>
		{
			// Token: 0x06005A30 RID: 23088 RVA: 0x000100B0 File Offset: 0x0000E2B0
			[Token(Token = "0x6005A30")]
			[Address(RVA = "0xA73A", Offset = "0xA73A", VA = "0xA73A", Slot = "8")]
			public override int Compare(UserData x, UserData y)
			{
				return 0;
			}

			// Token: 0x1700125E RID: 4702
			// (get) Token: 0x06005A31 RID: 23089 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700125E")]
			public override string Title
			{
				[Token(Token = "0x6005A31")]
				[Address(RVA = "0xA73B", Offset = "0xA73B", VA = "0xA73B", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A32")]
			[Address(RVA = "0xA73C", Offset = "0xA73C", VA = "0xA73C")]
			public ByLevel()
			{
			}
		}

		// Token: 0x02000E78 RID: 3704
		[Token(Token = "0x2000E78")]
		public class ByCult : AbstractGameDataComparer<UserData>
		{
			// Token: 0x06005A33 RID: 23091 RVA: 0x000100C8 File Offset: 0x0000E2C8
			[Token(Token = "0x6005A33")]
			[Address(RVA = "0xA73D", Offset = "0xA73D", VA = "0xA73D", Slot = "8")]
			public override int Compare(UserData x, UserData y)
			{
				return 0;
			}

			// Token: 0x1700125F RID: 4703
			// (get) Token: 0x06005A34 RID: 23092 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700125F")]
			public override string Title
			{
				[Token(Token = "0x6005A34")]
				[Address(RVA = "0xA73E", Offset = "0xA73E", VA = "0xA73E", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A35 RID: 23093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A35")]
			[Address(RVA = "0xA73F", Offset = "0xA73F", VA = "0xA73F")]
			public ByCult()
			{
			}
		}
	}
}
