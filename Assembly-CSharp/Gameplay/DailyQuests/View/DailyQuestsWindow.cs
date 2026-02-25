using System;
using Gameplay.DailyQuests.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000877 RID: 2167
	[Token(Token = "0x2000877")]
	public class DailyQuestsWindow : ClosableBaseWindow<DailyQuestsWindowArgs>
	{
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A07")]
		public override string WindowId
		{
			[Token(Token = "0x60032E5")]
			[Address(RVA = "0x8337", Offset = "0x8337", VA = "0x8337", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x8338", Offset = "0x8338", VA = "0x8338", Slot = "22")]
		protected override void OnShow(DailyQuestsWindowArgs args)
		{
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x8339", Offset = "0x8339", VA = "0x8339")]
		private void OnDestroy()
		{
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x833A", Offset = "0x833A", VA = "0x833A")]
		public DailyQuestsWindow()
		{
		}

		// Token: 0x04001BDC RID: 7132
		[Token(Token = "0x4001BDC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DailyQuests/DailyQuestsWindow";

		// Token: 0x04001BDD RID: 7133
		[Token(Token = "0x4001BDD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private DailyQuestsView _dailyQuestsView;

		// Token: 0x04001BDE RID: 7134
		[Token(Token = "0x4001BDE")]
		[FieldOffset(Offset = "0x40")]
		private DailyQuestsViewMediator _mediator;
	}
}
