using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Isles.Base;
using Il2CppDummyDll;

namespace Gameplay.World.Model
{
	// Token: 0x0200036A RID: 874
	[Token(Token = "0x200036A")]
	public class IsleHeap<T> : IDisposable where T : IIsle
	{
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00004EF0 File Offset: 0x000030F0
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000342")]
		public bool IsInvalid
		{
			[Token(Token = "0x600142E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600142F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000343")]
		public uint HeapLimit
		{
			[Token(Token = "0x6001430")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001431")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001432")]
		public IsleHeap()
		{
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001433")]
		public T GetLastIsleFromHeap()
		{
			return null;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000344")]
		public List<T> List
		{
			[Token(Token = "0x6001434")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001435")]
		public T GetNextIsle(T isle, int depth)
		{
			return null;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001436")]
		public void AddToHeap(T isle)
		{
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001437")]
		public T GetIsle(ulong id)
		{
			return null;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x6001438")]
		public bool IsHeapNeedUpdate(T isle)
		{
			return default(bool);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001439")]
		public void Dispose()
		{
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143A")]
		public void Remove(T isle)
		{
		}
	}
}
