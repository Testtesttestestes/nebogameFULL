using System;
using System.Collections.Generic;
using System.Linq;
using Core.Sorting;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Extensions
{
	// Token: 0x02000F0B RID: 3851
	[Token(Token = "0x2000F0B")]
	public static class IEnumerableExt
	{
		// Token: 0x06005D2D RID: 23853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D2D")]
		public static IOrderedEnumerable<TSource> SortGameData<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IGameDataComparer<TKey> comparer)
		{
			return null;
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D2E")]
		public static YResult MinOrDefault<TSource, YResult>(this IEnumerable<TSource> sequence, Func<TSource, YResult> selector)
		{
			return null;
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D2F")]
		[NotNull]
		public static string ToString<T>(this IEnumerable<T> source, string separator)
		{
			return null;
		}
	}
}
