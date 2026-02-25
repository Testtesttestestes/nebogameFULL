using System;
using Gameplay.DailyQuests.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x0200086D RID: 2157
	[Token(Token = "0x200086D")]
	public class DailyQuestReadViewWindow : ClosableBaseWindow<DailyQuestReadViewWindowArgs>
	{
		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FF")]
		public override string WindowId
		{
			[Token(Token = "0x60032B5")]
			[Address(RVA = "0x8307", Offset = "0x8307", VA = "0x8307", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B6")]
		[Address(RVA = "0x8308", Offset = "0x8308", VA = "0x8308", Slot = "22")]
		protected override void OnShow(DailyQuestReadViewWindowArgs args)
		{
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x8309", Offset = "0x8309", VA = "0x8309", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B8")]
		[Address(RVA = "0x830A", Offset = "0x830A", VA = "0x830A")]
		public DailyQuestReadViewWindow()
		{
		}

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DailyQuests/DailyQuestReadViewWindow";

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private DailyQuestReadView _view;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[FieldOffset(Offset = "0x40")]
		private DailyQuestReadViewMediator _mediator;
	}
}
