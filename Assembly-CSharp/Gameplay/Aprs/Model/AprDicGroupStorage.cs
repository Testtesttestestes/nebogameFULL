using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D63 RID: 3427
	[Token(Token = "0x2000D63")]
	public class AprDicGroupStorage : IDisposable
	{
		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06005405 RID: 21509 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005406 RID: 21510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001118")]
		public Dictionary<uint, AprDicGroup> AprDicGroupsByMedalId
		{
			[Token(Token = "0x6005405")]
			[Address(RVA = "0xA1BC", Offset = "0xA1BC", VA = "0xA1BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005406")]
			[Address(RVA = "0xA1BD", Offset = "0xA1BD", VA = "0xA1BD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06005407 RID: 21511 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005408 RID: 21512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001119")]
		public List<AprDicGroup> AprDicGroups
		{
			[Token(Token = "0x6005407")]
			[Address(RVA = "0xA1BE", Offset = "0xA1BE", VA = "0xA1BE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005408")]
			[Address(RVA = "0xA1BF", Offset = "0xA1BF", VA = "0xA1BF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005409")]
		[Address(RVA = "0xA1C0", Offset = "0xA1C0", VA = "0xA1C0")]
		public AprDicGroupStorage(IDictProvider dictionaries)
		{
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540A")]
		[Address(RVA = "0xA1C1", Offset = "0xA1C1", VA = "0xA1C1")]
		public void Collect(IDictProvider dictProvider)
		{
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540B")]
		[Address(RVA = "0xA1C2", Offset = "0xA1C2", VA = "0xA1C2")]
		public void Reset()
		{
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540C")]
		[Address(RVA = "0xA1C3", Offset = "0xA1C3", VA = "0xA1C3", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002D85 RID: 11653
		[Token(Token = "0x4002D85")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<MedalDicWrapper> MedalsWhitDiscount;
	}
}
