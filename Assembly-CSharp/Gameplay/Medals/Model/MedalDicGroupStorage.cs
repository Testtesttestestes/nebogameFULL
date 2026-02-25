using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Il2CppDummyDll;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000600 RID: 1536
	[Token(Token = "0x2000600")]
	public class MedalDicGroupStorage : IDisposable
	{
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000705")]
		public Dictionary<uint, MedalDicGroup> MedalDicGroupsByMedalId
		{
			[Token(Token = "0x600254F")]
			[Address(RVA = "0x7696", Offset = "0x7696", VA = "0x7696")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002550")]
			[Address(RVA = "0x7697", Offset = "0x7697", VA = "0x7697")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000706")]
		public List<MedalDicGroup> MedalDicGroups
		{
			[Token(Token = "0x6002551")]
			[Address(RVA = "0x7698", Offset = "0x7698", VA = "0x7698")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002552")]
			[Address(RVA = "0x7699", Offset = "0x7699", VA = "0x7699")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x769A", Offset = "0x769A", VA = "0x769A")]
		public MedalDicGroupStorage(IDictProvider dictProvider)
		{
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x769B", Offset = "0x769B", VA = "0x769B")]
		public bool IsMedalHasRanks(uint medalId)
		{
			return default(bool);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x769C", Offset = "0x769C", VA = "0x769C")]
		public uint GetMaxRank(uint medalId)
		{
			return 0U;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x769D", Offset = "0x769D", VA = "0x769D")]
		private void Init(IDictProvider dictProvider)
		{
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x769E", Offset = "0x769E", VA = "0x769E", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
