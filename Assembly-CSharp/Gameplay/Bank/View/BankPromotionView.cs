using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C47 RID: 3143
	[Token(Token = "0x2000C47")]
	public class BankPromotionView : MonoBehaviour
	{
		// Token: 0x140001DD RID: 477
		// (add) Token: 0x06004CA4 RID: 19620 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CA5 RID: 19621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DD")]
		public event Action<PromotionsDic> InfoButtonClickedEvent
		{
			[Token(Token = "0x6004CA4")]
			[Address(RVA = "0x9AE5", Offset = "0x9AE5", VA = "0x9AE5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CA5")]
			[Address(RVA = "0x9AE6", Offset = "0x9AE6", VA = "0x9AE6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CA7 RID: 19623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F74")]
		public PromotionsDic PromotionsDic
		{
			[Token(Token = "0x6004CA6")]
			[Address(RVA = "0x9AE7", Offset = "0x9AE7", VA = "0x9AE7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CA7")]
			[Address(RVA = "0x9AE8", Offset = "0x9AE8", VA = "0x9AE8")]
			set
			{
			}
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x9AE9", Offset = "0x9AE9", VA = "0x9AE9")]
		private void Awake()
		{
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x9AEA", Offset = "0x9AEA", VA = "0x9AEA")]
		private void InfoButtonClickHandler()
		{
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x9AEB", Offset = "0x9AEB", VA = "0x9AEB")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x9AEC", Offset = "0x9AEC", VA = "0x9AEC")]
		public BankPromotionView()
		{
		}

		// Token: 0x040029D7 RID: 10711
		[Token(Token = "0x40029D7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _bgImage;

		// Token: 0x040029D8 RID: 10712
		[Token(Token = "0x40029D8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x040029D9 RID: 10713
		[Token(Token = "0x40029D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		[FieldOffset(Offset = "0x20")]
		private PromotionsDic _promotionsDic;
	}
}
