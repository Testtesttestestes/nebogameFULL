using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model.PurchasePayload
{
	// Token: 0x02000BEC RID: 3052
	[Token(Token = "0x2000BEC")]
	public class DevPayloadPrefs
	{
		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06004AEF RID: 19183 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x17000F27")]
		public int Count
		{
			[Token(Token = "0x6004AEF")]
			[Address(RVA = "0x994C", Offset = "0x994C", VA = "0x994C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x994D", Offset = "0x994D", VA = "0x994D")]
		public DevPayloadPrefs(string nameId, string platformName)
		{
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0000DD88 File Offset: 0x0000BF88
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x994E", Offset = "0x994E", VA = "0x994E")]
		private bool Contains(string v)
		{
			return default(bool);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x994F", Offset = "0x994F", VA = "0x994F")]
		public bool TryAdd(string v)
		{
			return default(bool);
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x9950", Offset = "0x9950", VA = "0x9950")]
		public bool TryRemove(string v)
		{
			return default(bool);
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x9951", Offset = "0x9951", VA = "0x9951")]
		public string[] GetAll(ulong optionId)
		{
			return null;
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x9952", Offset = "0x9952", VA = "0x9952")]
		public bool TryGetValue(ulong optionId, long timestamp, out string developerPayload, out DeveloperPayloadId developerPayloadId)
		{
			return default(bool);
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x9953", Offset = "0x9953", VA = "0x9953")]
		public void Commit()
		{
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x9954", Offset = "0x9954", VA = "0x9954", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		public const string NameID = "PURCHASE_DEV_PAYLOADS";

		// Token: 0x040028C8 RID: 10440
		[Token(Token = "0x40028C8")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _platformName;

		// Token: 0x040028C9 RID: 10441
		[Token(Token = "0x40028C9")]
		[FieldOffset(Offset = "0xC")]
		private readonly DevPayloadPrefs.ValuesWrapper _data;

		// Token: 0x040028CA RID: 10442
		[Token(Token = "0x40028CA")]
		[FieldOffset(Offset = "0x10")]
		public readonly string NameId;

		// Token: 0x02000BED RID: 3053
		[Token(Token = "0x2000BED")]
		[Serializable]
		private class ValuesWrapper
		{
			// Token: 0x06004AF8 RID: 19192 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004AF8")]
			[Address(RVA = "0x9955", Offset = "0x9955", VA = "0x9955", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004AF9 RID: 19193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004AF9")]
			[Address(RVA = "0x9956", Offset = "0x9956", VA = "0x9956")]
			public ValuesWrapper()
			{
			}

			// Token: 0x040028CB RID: 10443
			[Token(Token = "0x40028CB")]
			[FieldOffset(Offset = "0x8")]
			public List<DeveloperPayload> Values;
		}
	}
}
