using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C80 RID: 3200
	[Token(Token = "0x2000C80")]
	public class AuchanActionInfoDisplay : MonoBehaviourWithStates<AuchanActionInfoDisplay.State>
	{
		// Token: 0x06004E19 RID: 19993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x9C4C", Offset = "0x9C4C", VA = "0x9C4C")]
		private void Awake()
		{
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x9C4D", Offset = "0x9C4D", VA = "0x9C4D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x9C4E", Offset = "0x9C4E", VA = "0x9C4E")]
		private void HandleItemBought()
		{
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x9C4F", Offset = "0x9C4F", VA = "0x9C4F")]
		public void Init(IArtifactView artifactData, Image marker, UserData user)
		{
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x9C50", Offset = "0x9C50", VA = "0x9C50")]
		private void SetIndefiniteTime(bool isIndefinite)
		{
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x9C51", Offset = "0x9C51", VA = "0x9C51")]
		public AuchanActionInfoDisplay()
		{
		}

		// Token: 0x04002A9A RID: 10906
		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _timeText;

		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _indefinetelyText;

		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtime;

		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _timeBg;

		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _left;

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _oldPriceText;

		// Token: 0x04002AA0 RID: 10912
		[Token(Token = "0x4002AA0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _newPriceText;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Price _oldPrice;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _newPrice;

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Image[] _markers;

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x48")]
		private IArtifactView _artifactView;

		// Token: 0x02000C81 RID: 3201
		[Token(Token = "0x2000C81")]
		public enum State
		{
			// Token: 0x04002AA7 RID: 10919
			[Token(Token = "0x4002AA7")]
			UNKNOWN_STATE,
			// Token: 0x04002AA8 RID: 10920
			[Token(Token = "0x4002AA8")]
			MARKET_ITEM
		}
	}
}
