using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000655 RID: 1621
	[Token(Token = "0x2000655")]
	public class ArtifactActionsView : MonoBehaviourWithStates<ArtifactActionPopupWindow.ActionType>
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000767")]
		public ButtonWithCost CostButton
		{
			[Token(Token = "0x600274D")]
			[Address(RVA = "0x7880", Offset = "0x7880", VA = "0x7880")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000768")]
		public GameObject SaleObjectsParent
		{
			[Token(Token = "0x600274E")]
			[Address(RVA = "0x7881", Offset = "0x7881", VA = "0x7881")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000769")]
		public TextMeshProUGUI CurrentDurability
		{
			[Token(Token = "0x600274F")]
			[Address(RVA = "0x7882", Offset = "0x7882", VA = "0x7882")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076A")]
		public TextMeshProUGUI FutureDurability
		{
			[Token(Token = "0x6002750")]
			[Address(RVA = "0x7883", Offset = "0x7883", VA = "0x7883")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x7884", Offset = "0x7884", VA = "0x7884")]
		public ArtifactActionsView()
		{
		}

		// Token: 0x04001583 RID: 5507
		[Token(Token = "0x4001583")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x04001584 RID: 5508
		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _saleObjectsParent;

		// Token: 0x04001585 RID: 5509
		[Token(Token = "0x4001585")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _currentDurability;

		// Token: 0x04001586 RID: 5510
		[Token(Token = "0x4001586")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _futureDurability;
	}
}
