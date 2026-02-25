using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Tabs;
using UI.Toggle;
using UnityEngine;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000875 RID: 2165
	[Token(Token = "0x2000875")]
	public class DailyQuestsView : MonoBehaviour
	{
		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A04")]
		public Toggle SwitchActiveToggle
		{
			[Token(Token = "0x60032DE")]
			[Address(RVA = "0x8330", Offset = "0x8330", VA = "0x8330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A05")]
		public CounterBacklight Counter
		{
			[Token(Token = "0x60032DF")]
			[Address(RVA = "0x8331", Offset = "0x8331", VA = "0x8331")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A06")]
		public TabBar TabBar
		{
			[Token(Token = "0x60032E0")]
			[Address(RVA = "0x8332", Offset = "0x8332", VA = "0x8332")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x8333", Offset = "0x8333", VA = "0x8333")]
		public void Init(IList<DailyQuestsListElementArgs> items)
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x8334", Offset = "0x8334", VA = "0x8334")]
		public DailyQuestsView()
		{
		}

		// Token: 0x04001BD6 RID: 7126
		[Token(Token = "0x4001BD6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04001BD7 RID: 7127
		[Token(Token = "0x4001BD7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private DailyQuestsListAdapter _questsListAdapter;

		// Token: 0x04001BD8 RID: 7128
		[Token(Token = "0x4001BD8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _switchActiveToggle;

		// Token: 0x04001BD9 RID: 7129
		[Token(Token = "0x4001BD9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterBacklight _counter;
	}
}
