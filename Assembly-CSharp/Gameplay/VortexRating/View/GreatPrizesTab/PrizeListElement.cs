using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.GreatPrizesTab
{
	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	public class PrizeListElement : MonoBehaviour
	{
		// Token: 0x1400010D RID: 269
		// (add) Token: 0x06001533 RID: 5427 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010D")]
		public event Action<PrizeListElement> ElementClickedEvent
		{
			[Token(Token = "0x6001533")]
			[Address(RVA = "0x66F5", Offset = "0x66F5", VA = "0x66F5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001534")]
			[Address(RVA = "0x66F6", Offset = "0x66F6", VA = "0x66F6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037E")]
		public RatingPrizeDic Prize
		{
			[Token(Token = "0x6001535")]
			[Address(RVA = "0x66F7", Offset = "0x66F7", VA = "0x66F7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001536")]
			[Address(RVA = "0x66F8", Offset = "0x66F8", VA = "0x66F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037F")]
		public bool Selected
		{
			[Token(Token = "0x6001537")]
			[Address(RVA = "0x66F9", Offset = "0x66F9", VA = "0x66F9")]
			set
			{
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x66FA", Offset = "0x66FA", VA = "0x66FA")]
		private void Awake()
		{
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x66FB", Offset = "0x66FB", VA = "0x66FB")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x66FC", Offset = "0x66FC", VA = "0x66FC")]
		public void Init(RatingPrizeDic prize, string period)
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x66FD", Offset = "0x66FD", VA = "0x66FD")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x66FE", Offset = "0x66FE", VA = "0x66FE")]
		public PrizeListElement()
		{
		}

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _timePeriod;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _bgImage;
	}
}
