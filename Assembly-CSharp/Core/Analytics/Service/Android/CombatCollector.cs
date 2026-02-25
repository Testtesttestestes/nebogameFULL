using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001290 RID: 4752
	[Token(Token = "0x2001290")]
	public class CombatCollector : IDisposable
	{
		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x000147D8 File Offset: 0x000129D8
		// (set) Token: 0x060070EA RID: 28906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001702")]
		public bool IsFinished
		{
			[Token(Token = "0x60070E9")]
			[Address(RVA = "0xBB10", Offset = "0xBB10", VA = "0xBB10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60070EA")]
			[Address(RVA = "0xBB11", Offset = "0xBB11", VA = "0xBB11")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x060070EB RID: 28907 RVA: 0x000147F0 File Offset: 0x000129F0
		// (set) Token: 0x060070EC RID: 28908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001703")]
		public bool? Win
		{
			[Token(Token = "0x60070EB")]
			[Address(RVA = "0xBB12", Offset = "0xBB12", VA = "0xBB12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60070EC")]
			[Address(RVA = "0xBB13", Offset = "0xBB13", VA = "0xBB13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070ED")]
		[Address(RVA = "0xBB14", Offset = "0xBB14", VA = "0xBB14", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070EE")]
		[Address(RVA = "0xBB15", Offset = "0xBB15", VA = "0xBB15")]
		public void Finish(bool win)
		{
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070EF")]
		[Address(RVA = "0xBB16", Offset = "0xBB16", VA = "0xBB16")]
		public void UseElixir(uint elixirId)
		{
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F0")]
		[Address(RVA = "0xBB17", Offset = "0xBB17", VA = "0xBB17")]
		public void UseSpell(uint spellId)
		{
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F1")]
		[Address(RVA = "0xBB18", Offset = "0xBB18", VA = "0xBB18")]
		public void Combo(string stoneType, int numStones)
		{
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60070F2")]
		[Address(RVA = "0xBB19", Offset = "0xBB19", VA = "0xBB19", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F3")]
		[Address(RVA = "0xBB1A", Offset = "0xBB1A", VA = "0xBB1A")]
		public CombatCollector()
		{
		}

		// Token: 0x04003AED RID: 15085
		[Token(Token = "0x4003AED")]
		[FieldOffset(Offset = "0x8")]
		private bool _isDisposed;

		// Token: 0x04003AEE RID: 15086
		[Token(Token = "0x4003AEE")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<uint> _elixirs;

		// Token: 0x04003AEF RID: 15087
		[Token(Token = "0x4003AEF")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<uint> _spells;

		// Token: 0x04003AF0 RID: 15088
		[Token(Token = "0x4003AF0")]
		[FieldOffset(Offset = "0x14")]
		[TupleElementNames(new string[]
		{
			"type",
			"numStones"
		})]
		private readonly List<ValueTuple<StonesTypes, int>> _combos;
	}
}
