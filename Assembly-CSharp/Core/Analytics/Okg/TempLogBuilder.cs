using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Okg
{
	// Token: 0x020012B0 RID: 4784
	[Token(Token = "0x20012B0")]
	public class TempLogBuilder : ILogBuilder
	{
		// Token: 0x0600718C RID: 29068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600718C")]
		[Address(RVA = "0xBB9A", Offset = "0xBB9A", VA = "0xBB9A")]
		public TempLogBuilder()
		{
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600718D")]
		[Address(RVA = "0xBB9B", Offset = "0xBB9B", VA = "0xBB9B")]
		public TempLogBuilder(string initialString)
		{
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x00014AA8 File Offset: 0x00012CA8
		[Token(Token = "0x600718E")]
		[Address(RVA = "0xBB9C", Offset = "0xBB9C", VA = "0xBB9C", Slot = "4")]
		public bool AddLine(OkgAnalyticsData record, out string error)
		{
			return default(bool);
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600718F")]
		[Address(RVA = "0xBB9D", Offset = "0xBB9D", VA = "0xBB9D", Slot = "5")]
		public void Clear()
		{
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007190")]
		[Address(RVA = "0xBB9E", Offset = "0xBB9E", VA = "0xBB9E", Slot = "6")]
		public string Extract()
		{
			return null;
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007191")]
		[Address(RVA = "0xBB9F", Offset = "0xBB9F", VA = "0xBB9F", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007192")]
		[Address(RVA = "0xBBA0", Offset = "0xBBA0", VA = "0xBBA0")]
		public void SetUserId(long userId)
		{
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007193")]
		[Address(RVA = "0xBBA1", Offset = "0xBBA1", VA = "0xBBA1")]
		public void SetUserLevel(int userLevel)
		{
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007194")]
		[Address(RVA = "0xBBA2", Offset = "0xBBA2", VA = "0xBBA2")]
		public void SetServerTimeOffset(long deltaTimeMs)
		{
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007195")]
		[Address(RVA = "0xBBA3", Offset = "0xBBA3", VA = "0xBBA3")]
		public void SetIsTempUserFlag(bool isTempUser)
		{
		}

		// Token: 0x04003B7E RID: 15230
		[Token(Token = "0x4003B7E")]
		[FieldOffset(Offset = "0x8")]
		private string _initialData;

		// Token: 0x04003B7F RID: 15231
		[Token(Token = "0x4003B7F")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<OkgAnalyticsData> _collector;
	}
}
