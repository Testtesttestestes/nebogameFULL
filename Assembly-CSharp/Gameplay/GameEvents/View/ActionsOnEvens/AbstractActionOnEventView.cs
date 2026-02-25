using System;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.GameEvents.View.ActionsOnEvens
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	public abstract class AbstractActionOnEventView : MonoBehaviour
	{
		// Token: 0x06002DF5 RID: 11765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF5")]
		[Address(RVA = "0x7E73", Offset = "0x7E73", VA = "0x7E73", Slot = "4")]
		public virtual void SetOnTriggeredCallback(EventHandler<AbstractActionOnEvent> callback)
		{
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D6")]
		public AbstractActionOnEvent Data
		{
			[Token(Token = "0x6002DF6")]
			[Address(RVA = "0x7E74", Offset = "0x7E74", VA = "0x7E74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF7")]
			[Address(RVA = "0x7E75", Offset = "0x7E75", VA = "0x7E75")]
			set
			{
			}
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x7E76", Offset = "0x7E76", VA = "0x7E76", Slot = "5")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x7E77", Offset = "0x7E77", VA = "0x7E77")]
		protected AbstractActionOnEventView()
		{
		}

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _labelField;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x14")]
		private AbstractActionOnEvent _data;
	}
}
