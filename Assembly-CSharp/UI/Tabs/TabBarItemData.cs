using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI.Tabs
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public class TabBarItemData
	{
		// Token: 0x140000DD RID: 221
		// (add) Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000AAA RID: 2730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DD")]
		public event Action<int> OnCountChangedEvent
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x5DF1", Offset = "0x5DF1", VA = "0x5DF1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x5DF2", Offset = "0x5DF2", VA = "0x5DF2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000166")]
		public int Count
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x5DF3", Offset = "0x5DF3", VA = "0x5DF3")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x1B79", Offset = "0x1B79", VA = "0x1B79")]
			set
			{
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000167")]
		public string Title
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x5DF4", Offset = "0x5DF4", VA = "0x5DF4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x5DF5", Offset = "0x5DF5", VA = "0x5DF5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		public uint Id
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x5DF6", Offset = "0x5DF6", VA = "0x5DF6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x5DF7", Offset = "0x5DF7", VA = "0x5DF7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		public TabBarItemData.State TabBarState
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x5DF8", Offset = "0x5DF8", VA = "0x5DF8")]
			[CompilerGenerated]
			get
			{
				return TabBarItemData.State.UNKNOWN_STATE;
			}
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x5DF9", Offset = "0x5DF9", VA = "0x5DF9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016A")]
		public bool AnimationEnabled
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x5DFA", Offset = "0x5DFA", VA = "0x5DFA")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x5DFB", Offset = "0x5DFB", VA = "0x5DFB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x5DFC", Offset = "0x5DFC", VA = "0x5DFC")]
		public TabBarItemData(uint id, string title)
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x4886", Offset = "0x4886", VA = "0x4886")]
		public TabBarItemData()
		{
		}

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0xC")]
		private int _count;

		// Token: 0x0200017B RID: 379
		[Token(Token = "0x200017B")]
		public enum State
		{
			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			UNKNOWN_STATE,
			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			DEFAULT,
			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			CUSTOM
		}
	}
}
