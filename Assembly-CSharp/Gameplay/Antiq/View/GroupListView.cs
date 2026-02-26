using System;
using Gameplay.Antiq.View.Grid;
using Il2CppDummyDll;
using UI;
using UI.Tabs;
using UI.Toggle;
using UnityEngine;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D7E RID: 3454
	[Token(Token = "0x2000D7E")]
	[AddComponentMenu("Antiq/View/GroupListView")]
	internal class GroupListView : MonoBehaviour
	{
		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001130")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6005495")]
			[Address(RVA = "0xA244", Offset = "0xA244", VA = "0xA244")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06005496 RID: 21654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001131")]
		public CounterBacklight Counter
		{
			[Token(Token = "0x6005496")]
			[Address(RVA = "0xA245", Offset = "0xA245", VA = "0xA245")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06005497 RID: 21655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001132")]
		public GridList List
		{
			[Token(Token = "0x6005497")]
			[Address(RVA = "0xA246", Offset = "0xA246", VA = "0xA246")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06005498 RID: 21656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001133")]
		public IToggleControl Toggle
		{
			[Token(Token = "0x6005498")]
			[Address(RVA = "0xA247", Offset = "0xA247", VA = "0xA247")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001134")]
		public SearchInput SearchInput
		{
			[Token(Token = "0x6005499")]
			[Address(RVA = "0xA248", Offset = "0xA248", VA = "0xA248")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549A")]
		[Address(RVA = "0xA249", Offset = "0xA249", VA = "0xA249")]
		public GroupListView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Antiq_View_GroupListView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5947e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12559);
		    DAT_ram_00a5947e = '\x01';
		  }
		  return StringLiteral_12559;
		}
		*/

		}

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04002DC4 RID: 11716
		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CounterBacklight _counter;

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GridList _list;

		// Token: 0x04002DC6 RID: 11718
		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x04002DC7 RID: 11719
		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Toggle _toggle;
	}
}
