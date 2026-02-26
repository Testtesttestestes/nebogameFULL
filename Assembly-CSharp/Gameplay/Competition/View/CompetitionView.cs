using System;
using Animations;
using Gameplay.Competition.View.Sections;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Competition.View
{
	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	[AddComponentMenu("Competition/View/CompetitionView")]
	public class CompetitionView : MonoBehaviour
	{
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A86")]
		public SectionContainer Sections
		{
			[Token(Token = "0x6003555")]
			[Address(RVA = "0x8578", Offset = "0x8578", VA = "0x8578")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A87")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6003556")]
			[Address(RVA = "0x8579", Offset = "0x8579", VA = "0x8579")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A88")]
		public BacktimeViewUGUI BackTime
		{
			[Token(Token = "0x6003557")]
			[Address(RVA = "0x857A", Offset = "0x857A", VA = "0x857A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A89")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6003558")]
			[Address(RVA = "0x857B", Offset = "0x857B", VA = "0x857B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A8A")]
		public SpineUiButtonAnimation ClockAnimation
		{
			[Token(Token = "0x6003559")]
			[Address(RVA = "0x857C", Offset = "0x857C", VA = "0x857C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x857D", Offset = "0x857D", VA = "0x857D")]
		public CompetitionView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Competition_View_CompetitionView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a81 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12602);
		    DAT_ram_00a63a81 = '\x01';
		  }
		  return StringLiteral_12602;
		}
		*/

		}

		// Token: 0x04001D2A RID: 7466
		[Token(Token = "0x4001D2A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SectionContainer _sections;

		// Token: 0x04001D2B RID: 7467
		[Token(Token = "0x4001D2B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04001D2C RID: 7468
		[Token(Token = "0x4001D2C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _backTime;

		// Token: 0x04001D2D RID: 7469
		[Token(Token = "0x4001D2D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001D2E RID: 7470
		[Token(Token = "0x4001D2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpineUiButtonAnimation _clockAnimation;
	}
}
