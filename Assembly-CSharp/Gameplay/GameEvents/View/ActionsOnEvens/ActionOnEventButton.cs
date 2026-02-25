using System;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GameEvents.View.ActionsOnEvens
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	public class ActionOnEventButton : AbstractActionOnEventView
	{
		// Token: 0x06002DFA RID: 11770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x7E78", Offset = "0x7E78", VA = "0x7E78")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x7E79", Offset = "0x7E79", VA = "0x7E79")]
		private void Awake()
		{
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x7E7A", Offset = "0x7E7A", VA = "0x7E7A", Slot = "4")]
		public override void SetOnTriggeredCallback(EventHandler<AbstractActionOnEvent> callback)
		{
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x7E7B", Offset = "0x7E7B", VA = "0x7E7B")]
		private void HandleOnClickEvent()
		{
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x7E7C", Offset = "0x7E7C", VA = "0x7E7C")]
		public ActionOnEventButton()
		{
		}

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<AbstractActionOnEvent> _onTriggeredCallback;
	}
}
