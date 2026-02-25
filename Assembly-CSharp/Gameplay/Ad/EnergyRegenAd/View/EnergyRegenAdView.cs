using System;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen;
using Gameplay.Ad.EnergyRegenAd.Controller;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.EnergyRegenAd.View
{
	// Token: 0x02000DAB RID: 3499
	[Token(Token = "0x2000DAB")]
	public class EnergyRegenAdView : MonoBehaviour
	{
		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06005586 RID: 21894 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700115D")]
		public EnergyRegenAdViewStateController StateController
		{
			[Token(Token = "0x6005586")]
			[Address(RVA = "0xA326", Offset = "0xA326", VA = "0xA326")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700115E")]
		public Button WatchButton
		{
			[Token(Token = "0x6005587")]
			[Address(RVA = "0xA327", Offset = "0xA327", VA = "0xA327")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06005588 RID: 21896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700115F")]
		public TextMeshProUGUI MessageTextField
		{
			[Token(Token = "0x6005588")]
			[Address(RVA = "0xA328", Offset = "0xA328", VA = "0xA328")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005589")]
		[Address(RVA = "0xA329", Offset = "0xA329", VA = "0xA329")]
		public void Init(EnergyRegenAdPlacementManager manager)
		{
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558A")]
		[Address(RVA = "0xA32A", Offset = "0xA32A", VA = "0xA32A")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558B")]
		[Address(RVA = "0xA32B", Offset = "0xA32B", VA = "0xA32B")]
		public EnergyRegenAdView()
		{
		}

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _messageTextField;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EnergyRegenAdViewStateController _stateController;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x1C")]
		private EnergyRegenAdViewMediator _mediator;
	}
}
