using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI.Tabs
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public class TabBarItemData<T> : TabBarItemData
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		public T Data
		{
			[Token(Token = "0x6000AB7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB9")]
		public TabBarItemData()
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABA")]
		public TabBarItemData(string title, T data)
		{
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABB")]
		public TabBarItemData(uint id, string title, T data)
		{
		}
	}
}
