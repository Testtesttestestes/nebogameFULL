using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F0C RID: 3852
	[Token(Token = "0x2000F0C")]
	public static class IListExt
	{
		// Token: 0x06005D30 RID: 23856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D30")]
		public static T GetRandom<T>(this IList<T> array)
		{
			return null;
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		[Token(Token = "0x6005D31")]
		public static int GetIndexRandom<T>(this IList<T> array, out T item)
		{
			return 0;
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D32")]
		public static TListElement BinarySearch<TListElement, SValue>(this IList<TListElement> list, Func<TListElement, SValue> getter, SValue searchValue) where SValue : IComparable
		{
			return null;
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		[Token(Token = "0x6005D33")]
		public static bool IsSorted<TListElement, SValue>(this IList<TListElement> list, Func<TListElement, SValue> getter) where SValue : IComparable
		{
			return default(bool);
		}
	}
}
