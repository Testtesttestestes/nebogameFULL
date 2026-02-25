using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Boss;
using Protocol.Dic;
using Utils;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B89 RID: 2953
	[Token(Token = "0x2000B89")]
	public class BossCreateRequestData
	{
		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x17000E61")]
		public ulong RequesterId
		{
			[Token(Token = "0x60047CB")]
			[Address(RVA = "0x9656", Offset = "0x9656", VA = "0x9656")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E62")]
		public BackTime BackTime
		{
			[Token(Token = "0x60047CC")]
			[Address(RVA = "0x9657", Offset = "0x9657", VA = "0x9657")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047CD")]
			[Address(RVA = "0x9658", Offset = "0x9658", VA = "0x9658")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E63")]
		public BossTypeDic BossTypeDic
		{
			[Token(Token = "0x60047CE")]
			[Address(RVA = "0x9659", Offset = "0x9659", VA = "0x9659")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047CF")]
			[Address(RVA = "0x965A", Offset = "0x965A", VA = "0x965A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E64")]
		public MonsterDic MonsterDic
		{
			[Token(Token = "0x60047D0")]
			[Address(RVA = "0x965B", Offset = "0x965B", VA = "0x965B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047D1")]
			[Address(RVA = "0x965C", Offset = "0x965C", VA = "0x965C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E65")]
		public AprDic AprDic
		{
			[Token(Token = "0x60047D2")]
			[Address(RVA = "0x965D", Offset = "0x965D", VA = "0x965D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047D3")]
			[Address(RVA = "0x965E", Offset = "0x965E", VA = "0x965E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D4")]
		[Address(RVA = "0x965F", Offset = "0x965F", VA = "0x965F")]
		public BossCreateRequestData(CreateRequestEvt createRequestEvt)
		{
		}

		// Token: 0x04002771 RID: 10097
		[Token(Token = "0x4002771")]
		[FieldOffset(Offset = "0x8")]
		private CreateRequestEvt _rawCreateRequestEvt;
	}
}
